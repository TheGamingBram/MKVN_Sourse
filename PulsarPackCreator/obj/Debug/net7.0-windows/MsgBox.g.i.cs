﻿#pragma checksum "..\..\..\MsgBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5D72F7031AE2B2A28C151D1FBC560E04CFFCD010"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Pulsar_Pack_Creator {
    
    
    /// <summary>
    /// MsgWindow
    /// </summary>
    public partial class MsgWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Pulsar_Pack_Creator.MsgWindow ProgramSettings;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSpace;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\MsgBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button No;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Pulsar Pack Creator;component/msgbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MsgBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProgramSettings = ((Pulsar_Pack_Creator.MsgWindow)(target));
            
            #line 11 "..\..\..\MsgBox.xaml"
            this.ProgramSettings.Deactivated += new System.EventHandler(this.MsgWindowDeactivated);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MsgBox.xaml"
            this.ProgramSettings.Closing += new System.ComponentModel.CancelEventHandler(this.MsgWindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextSpace = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.OK = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\MsgBox.xaml"
            this.OK.Click += new System.Windows.RoutedEventHandler(this.OnOKClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.No = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\MsgBox.xaml"
            this.No.Click += new System.Windows.RoutedEventHandler(this.OnNoClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

