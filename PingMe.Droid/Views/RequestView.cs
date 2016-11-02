using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;

namespace PingMe.Droid.Views
{
    [Activity(Label = "Ping Me!")]
    public class RequestView : MvxAppCompatActivity {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
        }
    }

}
