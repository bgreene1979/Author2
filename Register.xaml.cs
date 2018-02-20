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
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Storage;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Author
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private MobileServiceCollection<User_Db, User_Db> items;
        private IMobileServiceTable<User_Db> UserItem = App.author.GetTable<User_Db>();

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
            btnRegister.IsEnabled = false;

            await Register_User();

            btnRegister.IsEnabled = true;

        }

        private async Task Register_User()
        {
            try
            {

                User_Db item = new User_Db
                {
                    Email = txtEmail.Text,
                    Fname = txtFirstName.Text,
                    Lname = txtLastName.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    Zip = txtZip.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text
                };
                await App.author.GetTable<User_Db>().InsertAsync(item);

                //using Windows.UI.Popups;
                MessageDialog messageDialog = new MessageDialog("Thanks for registering " + txtEmail.Text, "Author App");
                await messageDialog.ShowAsync();

                txtEmail.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtZip.Text = "";
                txtPhone.Text = "";
                txtPassword.Text = "";
                this.Frame.Navigate(typeof(MainPage));


            }
            catch (Exception e)
            {
                MessageDialog messageDialog = new MessageDialog("An Error Occurred: " + e.Message, "Author App");
                await messageDialog.ShowAsync();
            }
        }
    }
}
