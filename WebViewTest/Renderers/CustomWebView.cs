using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewTest.Renderers
{
	public class CustomWebView : WebView
	{
		public CustomWebView()
		{
			Navigated += OnLoadFinished;
		}
		private void OnLoadFinished(object sender, WebNavigatedEventArgs eventArgs)
		{
			var page = GetPage();
			if (page == null) return;
			if (((MainPage)page).IsLoading) ((MainPage)page).IsLoading = false;
		}
		public Element GetPage()
		{
			var e = Parent;
			while (!(bool)e?.GetType().IsSubclassOf(typeof(ContentPage)))
				e = e?.Parent;
			return e;
		}
	}
}
