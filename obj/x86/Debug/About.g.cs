﻿#pragma checksum "C:\Users\hp\Desktop\School\Author\Author\Author\About.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "327C9254C3F7A1214DAC99463E76E5DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Author
{
    partial class About : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.imgLogo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.hplHome = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 14 "..\..\..\About.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.hplHome).Click += this.hplAbout_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.hplBooks = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 15 "..\..\..\About.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.hplBooks).Click += this.hplBooks_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.hplContact = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 16 "..\..\..\About.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.hplContact).Click += this.hplContact_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.txtblkUserName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

