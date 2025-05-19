using Microsoft.Extensions.Logging;
using sampledb.ViewModels; // Add this
using sampledb.Services;   // Add this
using CommunityToolkit.Maui;

namespace sampledb;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			 .UseMauiApp<App>()                  
            .UseMauiCommunityToolkit()          
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
 // Register HttpClient as Singleton for reuse
        // Consider configuring HttpClient base address or other settings here if needed
        builder.Services.AddSingleton<HttpClient>();

        // Register Services (Singleton is usually fine for stateless services)
        builder.Services.AddSingleton<WeatherService>();

        // Register ViewModels (Transient or Singleton depending on needs)
        // Singleton means the same instance is reused for MainPage
        // Transient means a new instance every time it's requested
        builder.Services.AddSingleton<WeatherViewModel>();

        // Register Pages/Views (Transient usually preferred for pages)
        builder.Services.AddSingleton<MainPage>(); // Use Singleton if ViewModel is Singleton and injected

		return builder.Build();
	}
}
