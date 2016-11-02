using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using PingMe.Core.ViewModels;

namespace PingMe.Droid.Views {
    [Activity(Label = "Send your Location")]
    public class SendLocationView : MvxAppCompatActivity<SendLocationViewModel> {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SendLocationView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
        }
    }
}
