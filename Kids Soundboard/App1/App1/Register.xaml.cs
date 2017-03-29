using App1.Databases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        Login db;
        public Register()
        {
            this.InitializeComponent();
            db = new Login();
        }
        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // Creating new user with their usernam, password and email
            int code = db.Register(new User()
            {
                UserName = txtUser.Text,
                Password = txtPassword.Password
            });
            // If user does not enter all details
            if (code == -1)
            {
                var message = new MessageDialog("Register failed");
                await message.ShowAsync();
            }
            // Otherwise if they do
            else
            {
                var message = new MessageDialog("Register Succeed");
                await message.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));
            }
        }
        // Return user Bacl to the Main Page
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
