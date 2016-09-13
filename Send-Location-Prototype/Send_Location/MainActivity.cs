using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace Send_Location
{
    [Activity(Label = "Send Location", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button default_btn = FindViewById<Button>(Resource.Id.default_btn);
            LinearLayout background = FindViewById<LinearLayout>(Resource.Id.background);
            background.SetBackgroundColor(Color.White);


        }
    }
}

