﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18A525C0E7B7E8C7F52650296669AF18CC411816"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CheckBox;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CheckBox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkToanBo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkCOngNghe;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDulich;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDabong;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkXemPhim;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CheckBox;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.chkToanBo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.chkToanBo.Checked += new System.Windows.RoutedEventHandler(this.ChkToanBo_Checked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.chkToanBo.Unchecked += new System.Windows.RoutedEventHandler(this.ChkToanBo_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkCOngNghe = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.chkCOngNghe.Checked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.chkCOngNghe.Unchecked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkDulich = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.chkDulich.Checked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.chkDulich.Unchecked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkDabong = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.chkDabong.Checked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.chkDabong.Unchecked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkXemPhim = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.chkXemPhim.Checked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.chkXemPhim.Unchecked += new System.Windows.RoutedEventHandler(this.chkSub_CheckedChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

