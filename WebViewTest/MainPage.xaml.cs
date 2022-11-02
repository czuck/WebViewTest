namespace WebViewTest;

public partial class MainPage : ContentPage
{
	private bool _isLoading;
	public bool IsLoading
	{
		get => _isLoading;
		set
		{
			_isLoading = value;
			ShowIndicator(_isLoading);
		}
	}
	public MainPage()
	{
		IsLoading = true;
		InitializeComponent();
	}
	private void ShowIndicator(bool value)
	{
		if (ActivityIndicator != null)
		{
			ActivityIndicator.IsRunning = value;
			ActivityIndicator.IsVisible = value;
		}

		if (ActivityLayout != null)
		{
			ActivityLayout.IsVisible = value;
		}
	}

}

