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

		});
	}
}
