﻿#pragma checksum "..\..\Input.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E404A9218D3F7A8D39B7DDE532CD0169EF8D7F915B8A8EF4256E32E897CD9D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Sport;
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


namespace Sport {
    
    
    /// <summary>
    /// Input
    /// </summary>
    public partial class Input : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ToolBar;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Exit_Click;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Logo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Osnova;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inputt;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Osnova2;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Input.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Reg;
        
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
            System.Uri resourceLocater = new System.Uri("/Sport;component/input.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Input.xaml"
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
            this.ToolBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Exit_Click = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\Input.xaml"
            this.Exit_Click.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit_Click_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Logo = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Osnova = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.Inputt = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\Input.xaml"
            this.Inputt.Click += new System.Windows.RoutedEventHandler(this.Inputt_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Osnova2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.Reg = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\Input.xaml"
            this.Reg.Click += new System.Windows.RoutedEventHandler(this.Reg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

