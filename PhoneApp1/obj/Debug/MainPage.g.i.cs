﻿#pragma checksum "c:\users\mohammed\documents\visual studio 2013\Projects\MyWcfService\PhoneApp1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D911D66EF4675A89CE35171AD44D97F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel txtBoxes;
        
        internal System.Windows.Controls.TextBox txtUserName;
        
        internal System.Windows.Controls.TextBox txtPassword;
        
        internal System.Windows.Controls.TextBox txtEmail;
        
        internal System.Windows.Controls.Button InsertBtn;
        
        internal System.Windows.Controls.TextBox txtFind;
        
        internal System.Windows.Controls.Button FindBtn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtBoxes = ((System.Windows.Controls.StackPanel)(this.FindName("txtBoxes")));
            this.txtUserName = ((System.Windows.Controls.TextBox)(this.FindName("txtUserName")));
            this.txtPassword = ((System.Windows.Controls.TextBox)(this.FindName("txtPassword")));
            this.txtEmail = ((System.Windows.Controls.TextBox)(this.FindName("txtEmail")));
            this.InsertBtn = ((System.Windows.Controls.Button)(this.FindName("InsertBtn")));
            this.txtFind = ((System.Windows.Controls.TextBox)(this.FindName("txtFind")));
            this.FindBtn = ((System.Windows.Controls.Button)(this.FindName("FindBtn")));
        }
    }
}

