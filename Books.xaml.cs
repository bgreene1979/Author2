using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Author
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Books : Page
    {
        public Books()
        {
            this.InitializeComponent();
            txtblkUserName.Text = MainPage.UserName;
        }

        private void hplHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }

        private void hplAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void hplContact_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contact));
        }

        /*async private void hplSpiritLink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.xlibris.com/Bookstore/BookDetail.aspx?BookId=SKU-001160445");
            }
            catch (MobileServiceInvalidOperationException exception e)
            {
                var dialog = new MessageDialog( "User name or password does not match");
                await dialog.ShowAsync();
            }

        }*/
    }
}
