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
using MvvmCross.Droid.FullFragging.Fragments;
using MvvmCross.Platform.IoC;

namespace PingMe.Droid {

    public interface IFragmentTypeLookup {
        bool TryGetFragmentType(Type viewModelType, out Type fragmentType);
    }

    public class FragLookup : IFragmentTypeLookup {
        private readonly IDictionary<string, Type> _fragmentLookup = new Dictionary<string, Type>();
        public FragLookup() {
            _fragmentLookup =
                (from type in GetType().Assembly.ExceptionSafeGetTypes()
                 where !type.IsAbstract
                    && !type.IsInterface
                    && typeof(MvxFragment).IsAssignableFrom(type)
                    && type.Name.EndsWith("View")
                 select type).ToDictionary(GetStrippedName);
        }

        public bool TryGetFragmentType(Type viewModelType, out Type fragmentType) {
            var strippedName = GetStrippedName(viewModelType);
            if (!_fragmentLookup.ContainsKey(strippedName)) {
                fragmentType = null;

                return false;
            }
            fragmentType = _fragmentLookup[strippedName];

            return true;
        }
        private string GetStrippedName(Type type) {
            return type.Name
                       .TrimEnd("View".ToCharArray())
                       .TrimEnd("ViewModel".ToCharArray());
        }
    }
}