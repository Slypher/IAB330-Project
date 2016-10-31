using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Views;


namespace PingMe.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
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
            


        }
    }

    class MembersTabFragment : Fragment {

        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState) {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.MembersTab, container, false);


            

            return view;
        }
    }

    class RequestTabFragment : Fragment {
        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState) {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.RequestTab, container, false);



            return view;

        }
    }
}
