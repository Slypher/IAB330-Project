using PingMe.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingMe.Core.Classes {
    public class DataModel {

        private static ObservableCollection<Group> groups = new ObservableCollection<Group>();

        public static ObservableCollection<Group> Groups {
            get {
                return groups;
            }
            set {
                groups = value;
            }
        }

        private static ObservableCollection<Notification> notifications = new ObservableCollection<Notification>();
        public static ObservableCollection<Notification> Notifications {
            get { return notifications; }
            set { notifications = value; }
        }

        public static void Init() {
            // Add dummy group data
            groups = new ObservableCollection<Group>();
            groups.Add(new Group("Group 1"));
            groups.Add(new Group("Group 2"));
            groups.Add(new Group("Another Group"));
            groups[0].AddGenericPeople();
            groups[1].Members.Add(new GroupMember("Harold", 7));
            groups[1].Members.Add(new GroupMember("Jeremiah", 555));
            groups[2].AddGenericPeople();
            groups[2].Members.Add(new GroupMember("Bobby", 12));
            // Add dummy notification data
            // First notification, right now
            Notifications.Add(new Notification(groups[1].Members[0], DateTime.Now));
            // Second, from 14 minutes ago
            Notifications.Add(new Notification(groups[0].Members[1], DateTime.Now.Subtract(TimeSpan.FromMinutes(14))));
            Notifications.Add(new Notification(groups[1].Members[1], DateTime.Now.Subtract(TimeSpan.FromHours(7))));
        }
        
    }
}
