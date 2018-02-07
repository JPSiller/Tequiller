using UIKit;
using Foundation;

namespace Tequiller.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.Init();

#if DEBUG
			Xamarin.Calabash.Start();
#endif
            LoadApplication(new App(new IosInitializer()));

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
