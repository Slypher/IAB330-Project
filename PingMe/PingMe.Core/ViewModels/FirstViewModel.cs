using Java.Util;
using MvvmCross.Core.ViewModels;

namespace PingMe.Core.ViewModels {
    public class FirstViewModel : MvxViewModel {

        // Array containing list of groups
        ArrayList groups = new ArrayList();

        public ArrayList Groups {
            get {
                return groups;
            }
        }
    }
}
