namespace MFCC;
public class ImageTintColor : Image
{
	public static readonly BindableProperty TintColorProperty =
		BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(ImageTintColor), Colors.Transparent, propertyChanged: OnTintColorChanged);

	public Color TintColor
	{
		get => (Color)GetValue(TintColorProperty);
		set => SetValue(TintColorProperty, value);
	}


	static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
	{
		var control = (ImageTintColor)bindable;
		var tintColor = control.TintColor;

		// TODO: Implement this code
	}
}
