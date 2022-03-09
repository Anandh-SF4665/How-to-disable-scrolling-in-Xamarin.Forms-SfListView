#if Android
using Xamarin.Forms.Platform.Android;
#elif __IOS__
using UIKit;
using Xamarin.Forms.Platform.iOS;
#else
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;
#endif
using ListViewXamarin.Droid;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(ListViewDependencyService))]
namespace ListViewXamarin.Droid
{
    public class ListViewDependencyService : IDependencyServiceListView
    {
        ExtendedScrollView ExtendedScrollView;

        public void DisableScrolling(SfListView ListView)
        {
            ExtendedScrollView = ListView.GetScrollView();
            var extendedScrollViewRenderer = Platform.GetRenderer(ExtendedScrollView);
#if __IOS__
            (extendedScrollViewRenderer.NativeView as UIScrollView).ScrollEnabled = false;
#elif Android
            (extendedScrollViewRenderer.Element as ExtendedScrollView).IsEnabled = false;
#else
            var nativeView = extendedScrollViewRenderer.GetNativeElement();
            extendedScrollViewRenderer.Element.IsTabStop = false;
            (nativeView as ScrollViewer).IsEnabled = false;
#endif
        }
    }
}