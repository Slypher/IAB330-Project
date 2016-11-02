using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using PingMe.Core.ViewModels;

namespace PingMe.Droid.Views {
    [Activity(Label = "Ping Me!")]
    public class HomeView : MvxAppCompatActivity<HomeViewModel> {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(toolbar);
        }
        public override bool OnCreateOptionsMenu(IMenu menu) {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item) {
            switch (item.ItemId) {
                case Resource.Id.action_notifications:
                    ViewModel.NotificationsCommand.Execute(null);
                    return true;
                default:
                    return true;
            }
        }


    }

}
