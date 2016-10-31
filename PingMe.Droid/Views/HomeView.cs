using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;


namespace PingMe.Droid.Views
{
<<<<<<< HEAD:PingMe.Droid/Views/FirstView.cs
    [Activity(Label = "Ping Me!")]
    public class FirstView : MvxActivity
=======
    [Activity(Label = "View for FirstViewModel")]
    public class HomeView : MvxActivity
>>>>>>> cc98a7132dd45707721d679d99985545fe144e29:PingMe.Droid/Views/HomeView.cs
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
<<<<<<< HEAD:PingMe.Droid/Views/FirstView.cs
            SetContentView(Resource.Layout.FirstView);
=======
            SetContentView(Resource.Layout.HomeView);
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

            // Setup list for each group:
            


>>>>>>> cc98a7132dd45707721d679d99985545fe144e29:PingMe.Droid/Views/HomeView.cs
        }
    }

}
