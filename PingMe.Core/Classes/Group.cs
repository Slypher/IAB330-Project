using System.Collections;
using System;
using System.Collections.ObjectModel;

namespace PingMe.Core.Classes {
    /*
     * This represents each group in the members page
     */
    public class Group {

        public ObservableCollection<GroupMember> Members {
            get; set;
        }

        private string groupName;
        public string GroupName {
            get { return groupName; }
            set { groupName = value; }
        }

        public override string ToString() {
            return GroupName;
        }

        public string Caption {
            get { return groupName; }
        }
        public string SubCaption {
            get {
                int numMem = this.Members.Count;
                if (numMem == 0) return "No Members";
                else return numMem.ToString() + " Members";
            }
        }


        public Group(string name) {
            GroupName = name;
            Members = new ObservableCollection<GroupMember>();
        }

        // Test method
        public void AddGenericPeople() {
            Members.Add(new GroupMember("Dom", 1));
            Members.Add(new GroupMember("Tony", 2));
            Members.Add(new GroupMember("George", 3));
            Members.Add(new GroupMember("Gio", 4));
        }
    }
}
