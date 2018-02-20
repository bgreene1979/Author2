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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Author
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            txtblkUserName.Text = MainPage.UserName + " Home";   
        }

        private void hplAbout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }

        private void hplBooks_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Books));
        }

        private void hplContact_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Contact));
        }
    }
}
