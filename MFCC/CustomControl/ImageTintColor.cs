namespace MFCC;
public class ImageTintColor : Image
{
	public static readonly BindableProperty TintColorProperty =
		BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(ImageTintColor), propertyChanged: OnTintColorChanged);

	public Color TintColor
	{
		get => (Color)GetValue(TintColorProperty);
		set => SetValue(TintColorProperty, value);
	}


	static void OnTintColorChanged(BindableObject bindable, object oldValue, object newValue)
	{
		var control = (ImageTintColor)bindable;
		var tintColor = control.TintColor;

		if (control.Handler is null)
        {
			control.HandlerChanged += (_, __) =>
			{
				OnTintColorChanged(bindable, oldValue, newValue);
			};

			return;
        }

		if (tintColor is not null)
        {
#if ANDROID
			ImageEx.ApplyColor((Android.Widget.ImageView)control.Handler.PlatformView, tintColor);
#elif IOS
			ImageEx.ApplyColor((UIKit.UIImageView)control.Handler.PlatformView, tintColor);
#endif
		}
        else
        {
#if ANDROID
			ImageEx.ClearColor((Android.Widget.ImageView)control.Handler.PlatformView);
#elif IOS
            ImageEx.ClearColor((UIKit.UIImageView)control.Handler.PlatformView);
#endif

        }
    }
}
