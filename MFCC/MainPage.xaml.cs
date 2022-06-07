using MFCC.Pages;

namespace MFCC;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void ButtonCustomControl_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ImageControlPage));
	}
}

