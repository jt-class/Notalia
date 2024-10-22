namespace Notalia;

public partial class SignUpPage : ContentPage
{
    public SignUpPage()
    {
        InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    public async void OnDone(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
    public async void ToLogInPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
