using Android.Widget;

namespace MFCC
{
	public partial class TintColorBehavior : PlatformBehavior<Image, ImageView>
    {
		protected override void OnAttachedTo(Image bindable, ImageView platformView)
		{
			ImageEx.ApplyColor(platformView, TintColor);
		}

		protected override void OnDetachedFrom(Image bindable, ImageView platformView)
		{
			ImageEx.ClearColor(platformView);
		}
	}
}
