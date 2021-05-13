﻿#pragma checksum "..\..\PageAccountAdministrator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2265013B65810D79E86FCD0B076EF08385DC3FF8FDF10024ACFDB8E12AAAFA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookStore;
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


namespace BookStore {
    
    
    /// <summary>
    /// PageAccountAdministrator
    /// </summary>
    public partial class PageAccountAdministrator : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataTableProduct;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataTableAdmin;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderDataGrid;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrationAdmin;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\PageAccountAdministrator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccountAdministratorExit;
        
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
            System.Uri resourceLocater = new System.Uri("/BookStore;component/pageaccountadministrator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageAccountAdministrator.xaml"
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
            this.DataTableProduct = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\PageAccountAdministrator.xaml"
            this.DataTableProduct.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.InfoOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataTableAdmin = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.OrderDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 191 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.RegistrationAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\PageAccountAdministrator.xaml"
            this.RegistrationAdmin.Click += new System.Windows.RoutedEventHandler(this.RegistrationAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 200 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AdminButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 208 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Product_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 216 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddProduct_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 224 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OrderProduct_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.AccountAdministratorExit = ((System.Windows.Controls.Button)(target));
            
            #line 232 "..\..\PageAccountAdministrator.xaml"
            this.AccountAdministratorExit.Click += new System.Windows.RoutedEventHandler(this.AccountAdministratorExit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 51 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditProductButton_Click);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 65 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteProductButton_Click);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 125 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 177 "..\..\PageAccountAdministrator.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteOrderButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

