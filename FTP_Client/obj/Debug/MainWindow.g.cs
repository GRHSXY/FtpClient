﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "383334FC263F82DC5A9F466C34CA5E2C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FTP_Client {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview_dir_tree;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_connect;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_Hostname;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_username;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_password;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_port;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuitem_close;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuitem_about;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_log;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_clear;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_path;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_download;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_upload;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_go;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_home;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_refresh;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image_up;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FTP_Client;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.treeview_dir_tree = ((System.Windows.Controls.TreeView)(target));
            return;
            case 2:
            this.button_connect = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.button_connect.Click += new System.Windows.RoutedEventHandler(this.button_connect_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textbox_Hostname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textbox_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textbox_password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox_port = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.textbox_port.AddHandler(System.Windows.DataObject.PastingEvent, new System.Windows.DataObjectPastingEventHandler(this.textbox_port_Pasting));
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.textbox_port.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.textbox_port_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.menuitem_close = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\MainWindow.xaml"
            this.menuitem_close.Click += new System.Windows.RoutedEventHandler(this.menuitem_close_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.menuitem_about = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.menuitem_about.Click += new System.Windows.RoutedEventHandler(this.menuitem_about_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.textbox_log = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.textbox_log.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textbox_log_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.button_clear = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\MainWindow.xaml"
            this.button_clear.Click += new System.Windows.RoutedEventHandler(this.button_clear_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.textbox_path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.button_download = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.button_download.Click += new System.Windows.RoutedEventHandler(this.button_download_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.button_upload = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.button_upload.Click += new System.Windows.RoutedEventHandler(this.button_upload_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.button_go = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.button_go.Click += new System.Windows.RoutedEventHandler(this.button_go_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.image_home = ((System.Windows.Controls.Image)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.image_home.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MainWindow.xaml"
            this.image_home.MouseEnter += new System.Windows.Input.MouseEventHandler(this.image_home_MouseEnter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MainWindow.xaml"
            this.image_home.MouseLeave += new System.Windows.Input.MouseEventHandler(this.image_home_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 16:
            this.image_refresh = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.image_refresh.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.image_refresh_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.image_refresh.MouseEnter += new System.Windows.Input.MouseEventHandler(this.image_refresh_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.image_refresh.MouseLeave += new System.Windows.Input.MouseEventHandler(this.image_refresh_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 17:
            this.image_up = ((System.Windows.Controls.Image)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.image_up.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.image_up_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.image_up.MouseEnter += new System.Windows.Input.MouseEventHandler(this.image_up_MouseEnter);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.image_up.MouseLeave += new System.Windows.Input.MouseEventHandler(this.image_up_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

