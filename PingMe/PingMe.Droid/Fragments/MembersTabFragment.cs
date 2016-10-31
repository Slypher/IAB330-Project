using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Binding.Droid.BindingContext;
using PingMe.Core.ViewModels;

namespace PingMe.Droid.Fragments {

    [MvxFragment(typeof(FirstViewModel), Resource.Id.contentFrame, true)]
    [Android.Runtime.Register("pingme.droid.fragments.MembersTabFragment")]
    public  class MembersTabFragment : MvxFragment<MembersTabViewModel> {

        public override View OnCreateView(LayoutInflater inflater,
            ViewGroup container, Bundle savedInstanceState) {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.MembersTab, null);

            return view;
        }
    }
}