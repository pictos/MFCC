namespace MFCC;

public partial class TintColorBehavior
#if !(ANDROID || IOS || MACCATALYST)
	: PlatformBehavior<Image>
#endif
{
	public static readonly BindableProperty TintColorProperty =
		BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(TintColorBehavior));

	public Color TintColor
	{
		get => (Color)GetValue(TintColorProperty);
		set => SetValue(TintColorProperty, value);
	}
}
