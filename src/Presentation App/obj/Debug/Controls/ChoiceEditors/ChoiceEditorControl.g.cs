﻿#pragma checksum "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD6B98878D6AB024E3C93D66D6DB81C3CFB535107722993470A4669AAB43D6AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Presentation_App;
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


namespace Presentation_App {
    
    
    /// <summary>
    /// ChoiceEditorControl
    /// </summary>
    public partial class ChoiceEditorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border mainBorder;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChoiceSelectButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChoiceLetterText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChoiceTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Presentation App;component/controls/choiceeditors/choiceeditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
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
            this.mainBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.ChoiceSelectButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
            this.ChoiceSelectButton.Click += new System.Windows.RoutedEventHandler(this.ChoiceSelectButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChoiceLetterText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ChoiceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
            this.ChoiceTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChoiceTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
            this.ChoiceTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.ChoiceTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 37 "..\..\..\..\Controls\ChoiceEditors\ChoiceEditorControl.xaml"
            this.ChoiceTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.ChoiceTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

