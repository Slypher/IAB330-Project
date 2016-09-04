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
            ArrayAdapter<string> membersListAdapter = 
                new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1, membersList);
            
            // List view
            membersListView = (ListView)view.FindViewById(Resource.Id.memberListview);
            membersListView.Adapter = membersListAdapter;

            // Search edittext
            EditText searchBox = (EditText)view.FindViewById(Resource.Id.etMemberSearch);
            searchBox.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) => {
                // When text is changed in the search box, update the filter
                string searchText = searchBox.Text.ToString();
                membersListAdapter.Filter.InvokeFilter(searchText);
            };

            return view;
        }
    }

    class RequestTabFragment : Fragment {
        public ListView requestsListView;
        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState) {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.RequestTab, container, false);

            //n Pending requests
            string[] requestsList = { "Slade Wilson [10 Minutes ago]", "Time Drake [1 Day ago]" };

            // Array adapter
            ArrayAdapter<string> requestsListAdapter =
                new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItem1, requestsList);

            // List view
            requestsListView = (ListView)view.FindViewById(Resource.Id.requestsListView);
            requestsListView.Adapter = requestsListAdapter;


            return view;
        }
    }
}
