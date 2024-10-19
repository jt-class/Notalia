namespace Notalia
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
        }
        private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                // Checkbox is checked
                DisplayAlert("Checkbox", "Checked", "OK");
            }
            else
            {
                // Checkbox is unchecked
                DisplayAlert("Checkbox", "Unchecked", "OK");
            }
        }
        private async void OnDone(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void ToSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }

}
