﻿

#pragma checksum "C:\Users\Rudi MK\Desktop\FBMetro III\FBMetro III\FbInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6874C441BD6E4C9DA2B3A7A81D4A6C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace FBMetro_III
{
    partial class FbInfo : Windows.UI.Xaml.Controls.Page
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.TextBlock txbUserName; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.Image imgProfilePic; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///FbInfo.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            txbUserName = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("txbUserName");
            imgProfilePic = (Windows.UI.Xaml.Controls.Image)this.FindName("imgProfilePic");
        }
    }
}



