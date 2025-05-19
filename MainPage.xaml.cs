namespace sampledb;
using System.Diagnostics;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAddUserClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddUserPage());
    }

    private async void OnShowUsersClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShowUsersPage());
    }
    private void OnToggleThemeClicked(object sender, EventArgs e)
    {
        (Application.Current as App)?.ToggleTheme();
    }

}
