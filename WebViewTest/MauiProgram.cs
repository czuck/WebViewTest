using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace WebViewTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCompatibility()
			.ConfigureMauiHandlers((handlers) =>
				{


#if IOS
                        handlers.AddCompatibilityRenderer(typeof(WebViewTest.Renderers.CustomWebView), typeof(WebViewTest.Platforms.iOS.CustomWebViewRenderer));
#endif
				})
				.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
