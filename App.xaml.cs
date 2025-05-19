namespace sampledb;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
	 public void ToggleTheme()
    {
        if (Current.UserAppTheme == AppTheme.Light)
            Current.UserAppTheme = AppTheme.Dark;
        else
            Current.UserAppTheme = AppTheme.Light;
    }
}