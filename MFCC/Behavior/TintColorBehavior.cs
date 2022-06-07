namespace MFCC;

public class TintColorBehavior : Behavior<Image>
{
	public static readonly BindableProperty TintColorProperty =
		BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(TintColorBehavior));
	bool isInitialized;

	public Color TintColor
	{
		get => (Color)GetValue(TintColorProperty);
		set => SetValue(TintColorProperty, value);
	}

	protected override void OnAttachedTo(Image bindable)
	{
		if (!isInitialized)
			base.OnAttachedTo(bindable);

		#region Initialization

		//if (bindable.Handler is null)
		//{
		//	isInitialized = true;
		//	bindable.HandlerChanged += OnHandlerChanged;
		//	return;
		//}


		void OnHandlerChanged(object sender, EventArgs e)
		{
			OnAttachedTo(bindable);
			bindable.HandlerChanged -= OnHandlerChanged;
		}

		#endregion

#if ANDROID
		ImageEx.ApplyColor((Android.Widget.ImageView)bindable.Handler.PlatformView, TintColor);
#elif IOS
		ImageEx.ApplyColor((UIKit.UIImageView)bindable.Handler.PlatformView, TintColor);
#endif
	}

	protected override void OnDetachingFrom(Image bindable)
	{
		base.OnDetachingFrom(bindable);
#if ANDROID
		ImageEx.ClearColor((Android.Widget.ImageView)bindable.Handler.PlatformView);
#elif IOS
		ImageEx.ClearColor((UIKit.UIImageView)bindable.Handler.PlatformView);
#endif
	}
}
