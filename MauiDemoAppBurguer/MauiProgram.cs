using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MauiDemoAppBurguer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("SpaceGrotesk-Bold.ttf", "SpaceB");
				fonts.AddFont("SpaceGrotesk-Regular.ttf", "SpaceR");
				fonts.AddFont("SpaceGrotesk-Medium.ttf", "SpaceM");
				fonts.AddFont("SpaceGrotesk-SemiBold.ttf", "SpaceSB");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoR");
				fonts.AddFont("Roboto-Light.ttf ", "RobotoL");
				fonts.AddFont("fontello.ttf", "icons");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
