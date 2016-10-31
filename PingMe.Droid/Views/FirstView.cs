using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;


namespace PingMe.Droid.Views
{
    [Activity(Label = "Ping Me!")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }

}
