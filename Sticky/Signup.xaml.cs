using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Devices.Geolocation;
using Windows.ApplicationModel.Core;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sticky
{    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Signup : Page
    {
        HttpClient httpClient;
        public Signup()
        {
            this.InitializeComponent();
        }
               private async void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (UsernameTextBox.Text == "")
            {
               
                var dialog = new Windows.UI.Popups.MessageDialog("Please enter a username");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();
            }
           else if (PasswordTextBox.Password == "")
            {
              
                var dialog = new Windows.UI.Popups.MessageDialog("Please enter a password");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();
            }



            else if (!Regex.IsMatch(EmailTextBox.Text.Trim(), @"^([a-zA-Z_])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"))

            {
                
                var dialog = new Windows.UI.Popups.MessageDialog("Invalid email id");
                dialog.DefaultCommandIndex = 1;
                await dialog.ShowAsync();



            }

            

            else
            {
                httpClient = new HttpClient();
                string resourceAddress = "";
            }
            



        }

        private void RegisterButtonTextBlock_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }
    }
}
