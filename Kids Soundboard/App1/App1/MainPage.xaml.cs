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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Login database;

        public MainPage()
        {
            this.InitializeComponent();
            database = new Login();
        }
        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // If user enters correct details
            if (database.LoginUser(txtUser.Text, txtPassword.Password))
            {
                // Message will appear
                var message = new MessageDialog("Login Success");
                await message.ShowAsync();
                this.Frame.Navigate(typeof(WelcomePage));
            }
            // If user enters wrong details
            else
            {
                var message = new MessageDialog("Login Failed");
                await message.ShowAsync();
            }

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Register));
        }

    }
}
