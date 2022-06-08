using Microsoft.Maui.Handlers;

namespace MFCC;
public static class TintColorMapper
{
	public static readonly BindableProperty TintColorProperty =
		BindableProperty.CreateAttached("TintColor", typeof(Color), typeof(Image), null);

	public static Color GetTintColor(BindableObject view)
			=> (Color)view.GetValue(TintColorProperty);

	public static void SetTintColor(BindableObject view, Color value)
		=> view.SetValue(TintColorProperty, value);

	public static void ApplyMapper()
	{
		ImageHandler.Mapper.Add("TintColor", (handler, view) =>
		{
			if (handler.VirtualView is null || handler.PlatformView is null)
				return;
			var tintColor = GetTintColor((Image)view);
			if (tintColor is not null)
			{
#if ANDROID
				ImageEx.ApplyColor(handler.PlatformView, tintColor);
#elif IOS
                ImageEx.ApplyColor(handler.PlatformView, tintColor);
#endif
            }
            else
            {

#if ANDROID
                ImageEx.ClearColor(handler.PlatformView);
#elif IOS
                ImageEx.ClearColor(handler.PlatformView);
#endif

            }
        });
	}
}
