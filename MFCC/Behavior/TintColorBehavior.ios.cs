using UIKit;

namespace MFCC;
public partial class TintColorBehavior : PlatformBehavior<Image, UIImageView>
{
	protected override void OnAttachedTo(Image bindable, UIImageView platformView)
	{
		ImageEx.ApplyColor(platformView, TintColor);
	}

	protected override void OnDetachedFrom(Image bindable, UIImageView platformView)
	{
		ImageEx.ClearColor(platformView);
	}
}
