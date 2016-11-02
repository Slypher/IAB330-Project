using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using PingMe.Core.ViewModels;

namespace PingMe.Droid.Views {
    [Activity(Label = "Requests and Notifications")]
    public class NotificationsView : MvxAppCompatActivity<NotificationsViewModel> {
        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NotificationsView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            
            SetSupportActionBar(toolbar);

        }
    }
}