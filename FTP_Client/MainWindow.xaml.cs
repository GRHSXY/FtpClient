using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Windows.Forms;
using FTP_Client.Code;

namespace FTP_Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private FtpClient ftp_client;
        private string path;        // 当前路径
        private bool isFilePath;
        private bool mylock;

        private FilenameDialog fileDialog;
       
        public MainWindow()
        {
            InitializeComponent();
            isFilePath = false; //默认是一个文件夹路径
            mylock = false;
            fileDialog = new FilenameDialog();
        }

        ~MainWindow()
        {
            if (ftp_client != null) ftp_client.DisConnect();
        }

        private void log(string logContent, int type=0)
        {
            string[] logType = new string[]{"info   ","warning","error   "};
            string time = DateTime.Now.ToUniversalTime().ToString();
            textbox_log.Text += "[" + time + "]:" +logType[type]+"->"+ logContent + "\n";
        }

        private void menuitem_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuitem_about_Click(object sender, RoutedEventArgs e)
        {
            new About().Show();
        }

        /// <summary>
        /// 点击连接ftp按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_Click(object sender, RoutedEventArgs e)
        {

            /*string host;
            string username;
            string password;
            string port;
            string info;

            host = textbox_Hostname.Text;
            username = textbox_username.Text;
            password = textbox_password.Text;
            port = textbox_port.Text;

            info = host + " " + username + " " + password + " " + port;

            log(info);

            if (button_connect.Content.Equals("close"))
            {
                if (ftp_client != null) ftp_client.DisConnect();
                button_connect.Content = "connect";
                button_connect.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
            }

            try
            {
                ftp_client = new FtpClient(host, "/", username, password, 21);
                log("请求连接" + host + ":" + port);
                ftp_client.Connect();
            }catch(Exception ex)
            {
                log(ex.ToString(), 2);
            }
            if (ftp_client.Connected)
            {
                log("连接服务器成功");

                listDir();
                // ftp_client.DisConnect();
            }
            button_connect.Content = "close";
            button_connect.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#100000"));
            //log(ftp_client.Connected.ToString());
             * */
            listDir(textbox_path.Text);
            ftp_client.ChDir(textbox_path.Text);
        }

        /// <summary>
        /// 在左边目录列出文件目录
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool listDir(string mypath="")
        {
            if (ftp_client == null) ftp_client = new FtpClient(textbox_Hostname.Text,"/", textbox_username.Text, textbox_password.Text, 21);
            if (!ftp_client.Connected) ftp_client.Connect() ;
            if (mypath.Equals(""))
                path = ftp_client.PWD();
            else path = mypath;
            log("list:" + path);
            try
            {
                treeview_dir_tree.Items.Clear();
                // 获得文件列表
                string[] dir = ftp_client.Dir(path);

                foreach (string d in dir)
                {
                    TreeViewItem tree_node = new TreeViewItem();
                    string[] path_list = d.Split('/');
                    tree_node.Header = path_list[path_list.Length - 1];
                    tree_node.Width = treeview_dir_tree.Width;
                    // 动态绑定事件
                    tree_node.Selected += TreeViewItem_Selected;
                    tree_node.MouseEnter += TreeViewItem_MouseEnter;
                    tree_node.MouseLeave += TreeViewItem_MouseLeave;

                    treeview_dir_tree.Items.Add(tree_node);
                    log("foreach:"+d);
                }
                log("update fold list");
                ftp_client.ChDir(path);
                textbox_path.Text = ftp_client.PWD();
            }
            catch (Exception e)
            {
                log(e.ToString(), 1);
                return false;
            }
            return true;
        }

        private void listView_file_list_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!isNumberic(e.Text))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        /// <summary>
        /// 是否是数字
        /// </summary>
        /// <param name="_string"></param>
        /// <returns></returns>
        public static bool isNumberic(string _string)
        {
            if (string.IsNullOrEmpty(_string))
                return false;
            foreach (char c in _string)
            {
                if (!char.IsDigit(c))
                    if(c<'0'|| c>'9')//最好的方法,在下面测试数据中再加一个0，然后这种方法效率会搞10毫秒左右
                    return false;
            }
            return true;
        }

        private void textbox_port_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void textbox_port_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!isNumberic(text))
                { e.CancelCommand(); }
            }
            else { e.CancelCommand(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_log_TextChanged(object sender, TextChangedEventArgs e)
        {
            textbox_log.ScrollToEnd();
        }

        private void textbox_log_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            textbox_log.ScrollToEnd();
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textbox_log.Text = "";
        }

        /// <summary>
        /// 文件item被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            string newPath;
            log("select a file/fold");
            string header = ((TreeViewItem)sender).Header.ToString();
            //log(header);
            //textbox_path.Text = path + header;
            // 获取文件大小

            //如果是目录的话，更换当前目录
            if (mylock) return;
            mylock = true;
            string pwdpath = ftp_client.PWD();//获取当时目录
            log("current:" + textbox_path.Text + " Remote:" + pwdpath);
            
            try
            {

                if (!path.Equals(pwdpath)) //如果服务器上的目录和当前目录不一样
                {
                    //更新为服务器目录
                    log("current:" + textbox_path.Text + ";\nRemote:" + path+";");
                    listDir(path);
                    ftp_client.ChDir(path);
                    textbox_path.Text = ftp_client.PWD();
                    isFilePath = false;
                    mylock = false;
                    return;
                }

               
                ftp_client.ChDir(path+"/" + header);
                listDir(path+"/"+header);

                //ftp_client.ChDir(path + "/" + header);
                log("Enter Dir:" + path);
                newPath = ftp_client.PWD();
                textbox_path.Text = newPath;
                path = newPath;
                isFilePath = false; //是一个文件夹目录
            }
            catch (Exception ex)//如果不是目录
            {
                //log(ex.ToString());
                log("selected file:"+header);
                pwdpath = ftp_client.PWD();
                if (pwdpath.Equals("/")) { textbox_path.Text = "/" + header;}
                else textbox_path.Text = ftp_client.PWD() + "/" + header;
                isFilePath = true;
                mylock = false;
                return;
            }
            mylock = false;

        }

        /// <summary>
        /// 鼠标经过目录变成蓝色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewItem_MouseEnter(object sender, MouseEventArgs e)
        {

            ((TreeViewItem)sender).Background=new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2786E4"));
        }

        /// <summary>
        /// 恢复为白色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewItem_MouseLeave(object sender, MouseEventArgs e)
        {
            ((TreeViewItem)sender).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        }

        /// <summary>
        /// 点击下载按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_download_Click(object sender, RoutedEventArgs e)
        {
            log(ftp_client.PWD());
            string fold_path="";
            if (isFilePath)
            {
                log("Please choose a directory");
                System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
                fbd.ShowDialog();
                if (fbd.SelectedPath != string.Empty)
                {
                    fold_path = fbd.SelectedPath;
                    log("Download to:" + fold_path);
                    try
                    {
                        string filename;
                        string[] path_list = textbox_path.Text.Split('/');
                        filename = path_list[path_list.Length-1];
                        ftp_client.Get(textbox_path.Text, fold_path, filename);
                        log("Download filename:" + filename);
                    }
                    catch (Exception ex)
                    {
                        log(ex.ToString());
                    }
                }
                    
            }
            else
            {
                log("Please choose a file first");
            }
        }

        private void button_upload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.DefaultExt = ".*";
            ofd.Filter = "file|*.*";
            if (ofd.ShowDialog() == true)
            {
                //此处做你想做的事 ...=ofd.FileName; 
                log(ofd.FileName);
                try
                {
                    ftp_client.Put(ofd.FileName);
                    log("Upload Success");
                }
                catch (Exception ex)
                {
                    log(ex.ToString());
                    log("Upload Failed", 2);
                }
            }
        }

        private void button_go_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listDir(textbox_path.Text);
                ftp_client.ChDir(textbox_path.Text);
                path = textbox_path.Text;
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
            
        }

        private bool check_ftp()
        {
            return true;
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                listDir("/");
                ftp_client.ChDir("/");
                path = "/";
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
            log("Back up to /");
        }

        private void image_refresh_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string newpath = ftp_client.PWD();
                listDir(newpath);
                ftp_client.ChDir(newpath);
                path = newpath;
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
        }

        private void image_up_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                
                ftp_client.ChDir("..");
                string newpath = ftp_client.PWD();
                listDir(newpath);
                path = newpath;
            }
            catch (Exception ex)
            {
                log(ex.ToString());
            }
        }

        private void image_up_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("up_b.jpg", UriKind.Relative));
        }

        private void image_up_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("up.jpg", UriKind.Relative));
        }

        private void image_refresh_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("refresh_b.png", UriKind.Relative));
        }

        private void image_refresh_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("refresh.png", UriKind.Relative));
        }

        private void image_home_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("home_b.png", UriKind.Relative));
        }

        private void image_home_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Image)sender).Source = new BitmapImage(new Uri("home.png", UriKind.Relative));
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            //log(ftp_client.PWD());
            string filename = textbox_path.Text;
            log("delete " + filename);
            if (isFilePath)
            {
                try
                {
                    ftp_client.Delete(filename);
                    log("delete success!");
                    listDir(ftp_client.PWD());
                }
                catch (Exception ex)
                {
                    log(ex.ToString());
                }

            }
            else
            {
                log("Please choose a file first");
            }
        }

        private void button_new_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                log("create a new fold at:" + ftp_client.PWD());
                fileDialog.ShowDialog();
                log("create new folder:"+ fileDialog.textbox_filename.Text);
                ftp_client.MkDir(fileDialog.textbox_filename.Text);
                log("create folder success!");
            }
            catch (Exception ex)
            {
                log("please connect to ftp server first!");
            }
            
        }
    }
}
