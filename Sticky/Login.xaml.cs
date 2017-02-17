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
using Sticky.Utils;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sticky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            ErrorMessage.Text = "";

            if (UsernameTextBox.Text == "")
            {
               // ErrorMessage.Text = "Please input a valid username";
                var dialog = new Windows.UI.Popups.MessageDialog("Please enter a valid username");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();
            }
            else if(PasswordTextBox.Password == "")
            {
                //ErrorMessage.Text = "Please input a valid password";
                var dialog = new Windows.UI.Popups.MessageDialog("Please enter a valid password");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();
            }
            //TODO: Connect to DB

            if(UsernameTextBox.Text == "ashley" && PasswordTextBox.Password == "ashley") //dummy values standing in for database
            {
                ErrorMessage.Text = "aaayyyyeee you did it";
            }
            else
            {
                // ErrorMessage.Text = "try again";
                var dialog = new Windows.UI.Popups.MessageDialog("Your email and password do not match. Please try again");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();
            }

            

        }
      
        private void RegisterButtonTextBlock_OnPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Signup));
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
       {
            // Check Microsoft Passport is setup and available on this machine
            
        }
    }
}

