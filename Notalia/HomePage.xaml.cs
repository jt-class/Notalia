using Microsoft.Maui.Controls;

namespace Notalia;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);

        var buttons = new List<ButtonModel>
        {
            new ButtonModel { Text = "Scrapbooks", HexColor = "#DFD7CC" }, 
            new ButtonModel { Text = "Invites", HexColor = "#E7D7C8" }, 
            new ButtonModel { Text = "Settings", HexColor = "#CAD0B7" }    
        };

        
        carousel_View.ItemsSource = buttons;
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        string buttonText = button.Text;


        if (buttonText == "Settings")
        {
            // Perform action for Settings
            await Navigation.PushAsync(new SettingsPage());
        }
        else if (buttonText == "Scrapbooks")
        {
            await Navigation.PushAsync(new ScrapbookPage());
        }
        else if (buttonText == "Invites")
        {
            // Perform action for Invites
        }
    }
}