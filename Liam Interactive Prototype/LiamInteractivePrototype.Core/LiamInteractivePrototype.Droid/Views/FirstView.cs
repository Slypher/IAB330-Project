using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Java.Lang;
using MvvmCross.Droid.Views;
using Android.Content;
using System.Collections.Generic;

namespace LiamInteractivePrototype.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle) {
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

    class MembersTabFragment : Fragment {

        public ListView membersListView;

        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState) {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.MembersTab, container, false);


            // Members list
            string[] membersList = { "Anna Marie", "Billy Batson", "Bruce Wayne", "Kathy Kayne", "Oswald Cobblepot",
                                        "Oliver Queen", "Phillip Urich", "Reed Richards",
                                        "Samantha Parrington", "Selina Kyle",
                                        "Slade Wilson", "Steven Rogers", "Tim Drake"};
            // Array Adapter
            ArrayAdapter<string> membersListAdapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1, membersList); ;
            
            // List view
            membersListView = (ListView)view.FindViewById(Resource.Id.memberListview);
            membersListView.Adapter = membersListAdapter;


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
