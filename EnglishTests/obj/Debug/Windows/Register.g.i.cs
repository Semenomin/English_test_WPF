﻿#pragma checksum "..\..\..\Windows\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A30DB29FAD898B6CAFBFE5EADA2D44371E9E72B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EnglishTests;
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


namespace EnglishTests {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameT;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginT;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassT;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Windows\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RPassT;
        
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
            System.Uri resourceLocater = new System.Uri("/EnglishTests;component/windows/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Register.xaml"
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
            this.NameT = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\..\Windows\Register.xaml"
            this.NameT.GotFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_GotFocus);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Windows\Register.xaml"
            this.NameT.LostFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_LostFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginT = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Windows\Register.xaml"
            this.LoginT.GotFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_GotFocus);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Windows\Register.xaml"
            this.LoginT.LostFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PassT = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\Windows\Register.xaml"
            this.PassT.GotFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_GotFocus);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\Windows\Register.xaml"
            this.PassT.LostFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RPassT = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Windows\Register.xaml"
            this.RPassT.GotFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_GotFocus);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\Windows\Register.xaml"
            this.RPassT.LostFocus += new System.Windows.RoutedEventHandler(this.Text_box_Login_text_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 38 "..\..\..\Windows\Register.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

