﻿#pragma checksum "..\..\..\ArrayA.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1DC099A0A80D52BD6B9EFF8FF2331F40B7FBBB9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainMenu;
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


namespace MainMenu {
    
    
    /// <summary>
    /// ArrayA
    /// </summary>
    public partial class ArrayA : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xInitial;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hStep;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox epsilon;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xFinal;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalculateSumSeries;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ArrayA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid outpuAarrayA;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MainMenu;V1.0.0.0;component/arraya.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ArrayA.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.xInitial = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\ArrayA.xaml"
            this.xInitial.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.XInitial_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.hStep = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\ArrayA.xaml"
            this.hStep.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.XInitial_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.epsilon = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\ArrayA.xaml"
            this.epsilon.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.XInitial_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.xFinal = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\ArrayA.xaml"
            this.xFinal.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.XInitial_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CalculateSumSeries = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\ArrayA.xaml"
            this.CalculateSumSeries.Click += new System.Windows.RoutedEventHandler(this.CalculateSumSeries_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.outpuAarrayA = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

