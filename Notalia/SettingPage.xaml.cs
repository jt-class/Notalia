using System;
using System;
using Xamarin.Forms;

namespace Notalia
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnLogOutClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Log Out", "You have been logged out.", "OK");
        }

        private async void OnAboutUsClicked(object sender, EventArgs e)
        {
            await DisplayAlert("About Us", "This is the About Us section.", "OK");
        }

        private async void OnHelpClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Help", "This is the Help section.", "OK");
        }
    }
}



