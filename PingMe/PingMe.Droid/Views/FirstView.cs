using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.Droid.BindingContext;
using PingMe.Droid.Fragments;

namespace PingMe.Droid.Views
{
    [Activity(Label = "Ping Me!")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            // Members tab
            var tab = this.ActionBar.NewTab();
            tab.SetText("Members");
            MembersTabFragment mTab = new MembersTabFragment();
            tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, mTab);
            };
            tab.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Remove(mTab);
            };
            this.ActionBar.AddTab(tab);

            // Request tab

            var tab2 = this.ActionBar.NewTab();
            tab2.SetText("Requests");
            RequestTabFragment rTab = new RequestTabFragment();
            tab2.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Add(Resource.Id.fragmentContainer, rTab);
            };
            tab2.TabUnselected += delegate (object sender, ActionBar.TabEventArgs e) {
                e.FragmentTransaction.Remove(rTab);
            };
            this.ActionBar.AddTab(tab2);
        }
    }

    

    
}
