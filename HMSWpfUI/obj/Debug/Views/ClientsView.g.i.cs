﻿#pragma checksum "..\..\..\Views\ClientsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2891979A2114AA97A114A4879348780A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HMSWpfUI.Views;
using HotelManagementSystem.Domain;
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


namespace HMSWpfUI.Views {
    
    
    /// <summary>
    /// ClientsView
    /// </summary>
    public partial class ClientsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Views\ClientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox clientListBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\ClientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\ClientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\ClientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\ClientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HMSWpfUI;component/views/clientsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ClientsView.xaml"
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
            
            #line 9 "..\..\..\Views\ClientsView.xaml"
            ((HMSWpfUI.Views.ClientsView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.clientListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 15 "..\..\..\Views\ClientsView.xaml"
            this.clientListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBox_OnSelectionChangedListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.saveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\ClientsView.xaml"
            this.saveBtn.Click += new System.Windows.RoutedEventHandler(this.saveBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.firstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Views\ClientsView.xaml"
            this.firstNameTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.firstNameTextBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\Views\ClientsView.xaml"
            this.firstNameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.firstNameTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.newBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\ClientsView.xaml"
            this.newBtn.Click += new System.Windows.RoutedEventHandler(this.newBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
