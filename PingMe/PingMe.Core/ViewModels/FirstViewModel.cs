
using Android.Runtime;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace PingMe.Core.ViewModels {
    public class FirstViewModel : MvxViewModel {

        // Binds to the value of the searchbar on MembersTab
        private string search = "";
        public string Search {
            get { return search; }
            set {
                if (value != null && value != search) {
                    search = value;
                    RaisePropertyChanged(() => Search);
                   
                }
            }
        }

        // Array containing list of groups
        ObservableCollection<Group> groups = new ObservableCollection<Group>();
        public ObservableCollection<Group> Groups {
            get {
                return groups;
            }
            set {
                if (groups != value) {
                    groups = value;
                    RaisePropertyChanged(() => this.groups);
                }
            }
        }

        // The group thats selected at the moment (Used to determine what members will be shown in the list
        Group selectedGroup = null;
        public Group SelectedGroup {
            get { return selectedGroup; }
            set {
                if (selectedGroup != value) {
                    selectedGroup = value;
                    RaisePropertyChanged(() => this.selectedGroup);
                }
            }
        }

        ObservableCollection<string> requests = new ObservableCollection<string>();
        public ObservableCollection<string> Requests {
            get { return requests; }
            set {
                SetProperty(ref requests, value);
            }
        }

        public FirstViewModel() {

            // Create example groups:
            groups.Add(new Group("Group 1"));
            groups.Add(new Group("Group 2"));
            groups.Add(new Group("Another Group"));

            groups[0].AddGenericPeople();
            groups[1].Members.Add(new GroupMember("Harold", 7));
            groups[1].Members.Add(new GroupMember("Jeremiah", 555));
            groups[2].AddGenericPeople();
            groups[2].Members.Add(new GroupMember("Bobby", 12));
        }

    }
}
