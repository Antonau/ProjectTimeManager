﻿#pragma checksum "..\..\AddEmployee.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6177778D983A7E3FFD309B5F4F6F6F31"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientSide;
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


namespace ClientSide {
    
    
    /// <summary>
    /// AddEmployee
    /// </summary>
    public partial class AddEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Employee_Name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Employee_Last_Name;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDialogOk;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientSide;component/addemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEmployee.xaml"
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
            
            #line 10 "..\..\AddEmployee.xaml"
            ((ClientSide.AddEmployee)(target)).ContentRendered += new System.EventHandler(this.Window_ContentRendered);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Employee_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\AddEmployee.xaml"
            this.Employee_Name.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.SelectContent);
            
            #line default
            #line hidden
            
            #line 27 "..\..\AddEmployee.xaml"
            this.Employee_Name.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LetterValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Employee_Last_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\AddEmployee.xaml"
            this.Employee_Last_Name.GotMouseCapture += new System.Windows.Input.MouseEventHandler(this.SelectContent);
            
            #line default
            #line hidden
            
            #line 29 "..\..\AddEmployee.xaml"
            this.Employee_Last_Name.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LetterValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDialogOk = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddEmployee.xaml"
            this.btnDialogOk.Click += new System.Windows.RoutedEventHandler(this.btnDialogOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

