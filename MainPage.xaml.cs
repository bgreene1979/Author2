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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.MobileServices;
using SQLite;
using SQLite.Net;
using SQLite.Net.Async;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Storage;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Author
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void hplRegistration_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }

        private MobileServiceCollection<User_Db, User_Db> items;
        private IMobileServiceTable<User_Db> UserItem = App.author.GetTable<User_Db>();

        public static String UserName = "";

        public class User_Db
        {
            public string Id { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }

        }

        public void GetDBSync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new
                    Uri("https://brookauthor.azurewebsites.net");

                var json = client.GetStringAsync("/").Result;
                var contacts = JsonConvert.DeserializeObject<User_Db[]>(json);
            }
        }


        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnLogin.IsEnabled = false;

            await Login();

            btnLogin.IsEnabled = true;

        }

        private async Task Login()
        {
            MobileServiceInvalidOperationException exception = null;

            try
            {
                items = await UserItem
                         .ToCollectionAsync();
            }

            catch (MobileServiceInvalidOperationException e)
            {
                exception = e;
            }

            if (exception != null)
            {
                await new MessageDialog(exception.Message, "Error loading items").ShowAsync();
            }
            else
            {
                List<User_Db> items = await UserItem
                    .Where(User_Cred => User_Cred.Email == txtUserName.Text)
                    .Where(User_Cred => User_Cred.Password == txtPassword.Text)
                    .ToListAsync();

                int IsAuth = items.Count();

                if (IsAuth > 0)
                {
                    UserName = txtUserName.Text;
                    this.Frame.Navigate(typeof(Home));  
                }
                else
                {
                    var dialog = new MessageDialog("User name or password does not match");
                    await dialog.ShowAsync();
                }

            }
        }

    }
}
