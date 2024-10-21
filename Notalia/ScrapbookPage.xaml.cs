using System.Collections.ObjectModel;

namespace Notalia;

public partial class ScrapbookPage : ContentPage
{
    public ObservableCollection<ScrapbookButton> ScrapbookButtons { get; set; }

    public ScrapbookPage()
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);

        // Create a collection of buttons (the first one is the plus button)
        ScrapbookButtons = new ObservableCollection<ScrapbookButton>();

        // Create the "Add New Scrapbook" button programmatically
        var addNewButton = new ScrapbookButton
        {
            Text = "", // No text for the add button
            BackgroundColor = Colors.White,
            IsAddNew = true, // Mark this as the 'add new' button
        };

        // Add the "Add New Scrapbook" button to the collection
        ScrapbookButtons.Add(addNewButton);

        // Load user's scrapbooks dynamically
        LoadUserScrapbooks();

        // Set the data source for the CarouselView
        carousel_View.ItemsSource = ScrapbookButtons;
    }

    private void LoadUserScrapbooks()
    {
        // Dummy data: Replace this with the logic to load user's scrapbooks from the database
        var userScrapbooks = new List<Scrapbook>
        {
            //new Scrapbook { Name = "Vacation", ImageSource = "vacation.png" },
            //new Scrapbook { Name = "Birthday", ImageSource = "birthday.png" },
        };

        foreach (var scrapbook in userScrapbooks)
        {
            ScrapbookButtons.Add(new ScrapbookButton
            {
                Title = scrapbook.Name, // Set the title for the existing scrapbooks
                BackgroundColor = Colors.LightBlue, // Customize as needed
                ImageSource = scrapbook.ImageSource,
                IsAddNew = false // Not the add button
            });
        }
    }

    // Event handler for the button click
    private void OnButtonClicked(object sender, EventArgs e)
    {
        var entry = this.FindByName<Entry>("title_entry");
        var newScrapbookTitle = entry?.Text;

        if (!string.IsNullOrWhiteSpace(newScrapbookTitle))
        {
            // Logic to save the new scrapbook
            ScrapbookButtons.Add(new ScrapbookButton
            {
                Title = newScrapbookTitle,
                BackgroundColor = Colors.LightBlue,
                IsAddNew = false // Not the add button
            });

            // Clear the entry after adding
            entry.Text = string.Empty;

            // Optionally, save the new scrapbook to the database here
        }
    }
    // Event handler for the image button click
    private void OnImageButtonClicked(object sender, EventArgs e)
    {
        // Logic for when an existing scrapbook button is clicked
    }
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
    private async void OnTrashButtonClicked(object sender, EventArgs e)
    {

    }
}

// Class representing a scrapbook button
public class ScrapbookButton
{
    public string Text { get; set; }
    public string Title { get; set; } // New property for the scrapbook title
    public Color BackgroundColor { get; set; }
    public string ImageSource { get; set; }
    public bool IsAddNew { get; set; } // Determines if it's the "add new" button
}

// Class representing a scrapbook (for your data model)
public class Scrapbook
{
    public string Name { get; set; }
    public string ImageSource { get; set; }
}
