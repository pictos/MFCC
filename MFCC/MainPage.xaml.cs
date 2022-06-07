using MFCC.Pages;

namespace MFCC;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void ButtonCustomControl(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ImageControlPage));
	}

	private void ButtonMapper(object sender, EventArgs e)
	{
		TintColorMapper.ApplyMapper();
		Shell.Current.GoToAsync(nameof(ImageMapper));
	}

	private void ButtonBehavior(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(ImageBehaviorPage));
	}
}

