﻿#pragma checksum "..\..\..\Views\SetupWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "087A03CDE874FB02650AD1F5ECBE46FE"
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


namespace DL.PhotoCollage.UI.StandAlone.Views {
    
    
    /// <summary>
    /// SetupWindow
    /// </summary>
    public partial class SetupWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DirectoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DirectorySelectButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider numberOfPhotosSlider;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock numberOfPhotosTextBlock;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpeedComboBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsRandomCheckBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsGrayscaleCheckBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ShowBordersCheckBox;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\Views\SetupWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DL.PhotoCollage.UI.StandAlone;component/views/setupwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SetupWindow.xaml"
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
            
            #line 9 "..\..\..\Views\SetupWindow.xaml"
            ((DL.PhotoCollage.UI.StandAlone.Views.SetupWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DirectoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DirectorySelectButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Views\SetupWindow.xaml"
            this.DirectorySelectButton.Click += new System.Windows.RoutedEventHandler(this.DirectorySelectButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.numberOfPhotosSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.numberOfPhotosTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.SpeedComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 77 "..\..\..\Views\SetupWindow.xaml"
            this.SpeedComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SpeedComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IsRandomCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.IsGrayscaleCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.ShowBordersCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\Views\SetupWindow.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\..\Views\SetupWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

