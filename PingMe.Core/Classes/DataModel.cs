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

        private static ObservableCollection<Notification> locations = new ObservableCollection<Notification>();
        public static ObservableCollection<Notification> Locations {
            get {
                return locations;
            }
            set {
                locations = value;
            }
        }

        public static void Init() {
            // Add dummy group data
            groups = new ObservableCollection<Group>();
            groups.Add(new Group("Telstra Accounting"));
            groups.Add(new Group("Telstra IT"));
            groups.Add(new Group("Telstra Management"));
            groups.Add(new Group("Telstra Sales"));
            groups[0].AddGenericPeople();
            groups[3].AddGenericPeople();
            groups[0].Members.Add(new GroupMember("Harold Harolding", 6));
            groups[0].Members.Add(new GroupMember("Stephanie Edgly", 7));
            groups[0].Members.Add(new GroupMember("Amy Rice", 8));
            groups[0].Members.Add(new GroupMember("Harry Peterson", 9));
            groups[1].Members.Add(new GroupMember("Jeremiah Power", 10));
            groups[1].Members.Add(new GroupMember("Maurice Moss", 11));
            groups[1].Members.Add(new GroupMember("Roy Trenneman", 12));
            groups[2].Members.Add(new GroupMember("Bob Scofeld", 13));
            groups[2].Members.Add(new GroupMember("Melissa Melvin", 14));
            groups[3].Members.Add(new GroupMember("Gary Brine", 15));
            // Add dummy notification data
            // First notification, right now
            Notifications.Add(new Notification(groups[0].Members[1], DateTime.Now, Notification.TYPE_REQUEST));
            // Second, from 14 minutes ago
            Notifications.Add(new Notification(groups[0].Members[3], DateTime.Now.Subtract(TimeSpan.FromMinutes(14)), Notification.TYPE_REQUEST));
            Notifications.Add(new Notification(groups[1].Members[0], DateTime.Now.Subtract(TimeSpan.FromHours(7)), Notification.TYPE_REQUEST));
            Notifications.Add(new Notification(groups[0].Members[6], DateTime.Now.Subtract(TimeSpan.FromHours(8)), Notification.TYPE_REQUEST));
            Locations.Add(new Notification(groups[0].Members[1], DateTime.Now, Notification.TYPE_LOCATION));
        }



    }
}
