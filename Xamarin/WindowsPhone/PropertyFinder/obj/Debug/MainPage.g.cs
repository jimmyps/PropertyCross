﻿#pragma checksum "C:\Projects\PropertyFinder-Xamarin\WindowsPhone\PropertyFinder\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48463FACBFA9544700BD7C53193033D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PropertyFinder {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox searchText;
        
        internal System.Windows.Controls.Button buttonSearchGo;
        
        internal System.Windows.Controls.Button buttonMyLocation;
        
        internal System.Windows.Controls.ProgressBar loadingIndicator;
        
        internal System.Windows.Controls.TextBlock userMessage;
        
        internal System.Windows.Controls.StackPanel locationsContainer;
        
        internal System.Windows.Controls.ItemsControl locationsList;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PropertyFinder;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.searchText = ((System.Windows.Controls.TextBox)(this.FindName("searchText")));
            this.buttonSearchGo = ((System.Windows.Controls.Button)(this.FindName("buttonSearchGo")));
            this.buttonMyLocation = ((System.Windows.Controls.Button)(this.FindName("buttonMyLocation")));
            this.loadingIndicator = ((System.Windows.Controls.ProgressBar)(this.FindName("loadingIndicator")));
            this.userMessage = ((System.Windows.Controls.TextBlock)(this.FindName("userMessage")));
            this.locationsContainer = ((System.Windows.Controls.StackPanel)(this.FindName("locationsContainer")));
            this.locationsList = ((System.Windows.Controls.ItemsControl)(this.FindName("locationsList")));
        }
    }
}
