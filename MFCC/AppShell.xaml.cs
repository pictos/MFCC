using MFCC.Pages;

namespace MFCC;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ImageControlPage), typeof(ImageControlPage));
        Routing.RegisterRoute(nameof(ImageMapper), typeof(ImageMapper));
        Routing.RegisterRoute(nameof(ImageBehaviorPage), typeof(ImageBehaviorPage));
    }
}
