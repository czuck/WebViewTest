using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using Microsoft.Maui.Controls.Platform;
using WebKit;
using WebViewTest.Platforms.iOS;
using WebViewTest.Renderers;


namespace WebViewTest.Platforms.iOS
{
	public class CustomWebViewRenderer : WkWebViewRenderer
	{

		public CustomWebViewRenderer()
		{
		}
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				//NavigationDelegate = new CustomWKNavigationDelegete();
			}
		}
		public class CustomWKNavigationDelegete : WKNavigationDelegate
		{

		}
	}
}
