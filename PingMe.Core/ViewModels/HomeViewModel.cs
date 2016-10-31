
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace PingMe.Core.ViewModels {
    public class HomeViewModel : MvxViewModel {

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
        private ObservableCollection<Group> groups = new ObservableCollection<Group>();

        public ObservableCollection<Group> Groups {
            get {
                return groups;
            }
            set {
                SetProperty(ref groups, value);
            }
        }

        // Which group is selected in the spinner
        private Group selectedGroup;
        public Group SelectedGroup {
            get {
                return selectedGroup;
            }
            set {
                selectedGroup = value;
                RaisePropertyChanged(() => SelectedGroup);
                // When selected group changes, change the list:
                CurrentGroupMembers = value.Members;
            }
        }

<<<<<<< HEAD:PingMe.Core/ViewModels/FirstViewModel.cs
        private ObservableCollection<GroupMember> currentGroupMembers = new ObservableCollection<GroupMember>();
        public ObservableCollection<GroupMember> CurrentGroupMembers {
            get {
                return currentGroupMembers;
            }
            set {
                SetProperty(ref currentGroupMembers, value);
            }
        }


        public FirstViewModel() {
=======
        public HomeViewModel() {
>>>>>>> cc98a7132dd45707721d679d99985545fe144e29:PingMe.Core/ViewModels/HomeViewModel.cs

            // Create example groups:
            groups.Add(new Group("Group 1"));
            groups.Add(new Group("Group 2"));
            groups.Add(new Group("Another Group"));

            groups[0].AddGenericPeople();
            groups[1].Members.Add(new GroupMember("Harold", 7));
            groups[1].Members.Add(new GroupMember("Jeremiah", 555));
            groups[2].AddGenericPeople();
            groups[2].Members.Add(new GroupMember("Bobby", 12));

            // Make Group 1 the selected group to start with
            CurrentGroupMembers = Groups[0].Members; 
        }

    }
}
