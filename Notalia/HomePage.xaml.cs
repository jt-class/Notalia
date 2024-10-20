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
            new ButtonModel { Text = "Scrapbooks", HexColor = "#DFD7CC" }, // Light Blue
            new ButtonModel { Text = "Invites", HexColor = "#E7D7C8" }, // Light Green
            new ButtonModel { Text = "Settings", HexColor = "#CAD0B7" }    // Light Coral
        };

        // Set the ItemsSource for the CarouselView
        carousel_View.ItemsSource = buttons;
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        string buttonText = button.Text;

        // Handle button click actions based on the button's text
        if (buttonText == "Settings")
        {
            // Perform action for Settings
        }
        else if (buttonText == "Scrapbooks")
        {
            // Perform action for Scrapbooks
        }
        else if (buttonText == "Invites")
        {
            // Perform action for Invites
        }
    }
}