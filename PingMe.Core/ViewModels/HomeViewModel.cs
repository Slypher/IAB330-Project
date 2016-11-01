
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace PingMe.Core.ViewModels {
    public class HomeViewModel : MvxViewModel {

        public HomeViewModel() {

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
            currentGroupMembers = Groups[0].Members;

            filteredGroupMembers = currentGroupMembers;

            Debug.WriteLine("Test");
            Debug.WriteLine("Length of filtered list" + currentGroupMembers.Count().ToString());
        }
        
        public void FilterMembers() {
            if (string.IsNullOrEmpty(Search)) {
                // Set the filtered list to equal its unfiltered form
                FilteredGroupMembers = currentGroupMembers;
            } else {
                // Filter the list
                FilteredGroupMembers = new ObservableCollection<GroupMember>(
                    currentGroupMembers.Where(
                    o => o.Name.ToLower().Contains(Search.ToLower())).ToList());
                RaisePropertyChanged(() => FilteredGroupMembers);
            }
        }

        // Binds to the value of the searchbar
        private string search;
        public string Search {
            get { return search; }
            set {
                search = value;
                
                RaisePropertyChanged(() => Search);

                FilterMembers();
                
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
                // When selected group changes, change the list:
                CurrentGroupMembers = value.Members;

                RaisePropertyChanged(() => SelectedGroup);

                FilterMembers();
            }
        }


        /*
         * The list of members to display in the listview
         * The filtered form is after the search has been done
         */

        private ObservableCollection<GroupMember> currentGroupMembers = new ObservableCollection<GroupMember>();
        public ObservableCollection<GroupMember> CurrentGroupMembers {
            get { return currentGroupMembers; }
            set {
                currentGroupMembers = value;
                RaisePropertyChanged(() => CurrentGroupMembers);
            }
        }


        private ObservableCollection<GroupMember> filteredGroupMembers = new ObservableCollection<GroupMember>();
        public ObservableCollection<GroupMember> FilteredGroupMembers {
            get { return filteredGroupMembers; }
            set {
                filteredGroupMembers = value;
                RaisePropertyChanged(() => FilteredGroupMembers);
            }
        }



        

    }
}