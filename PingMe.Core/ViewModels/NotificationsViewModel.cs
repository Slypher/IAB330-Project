using MvvmCross.Core.ViewModels;
using PingMe.Core.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingMe.Core.ViewModels {
    public class NotificationsViewModel : MvxViewModel {

        public NotificationsViewModel() {
            // Pull notification data
            Notifications = DataModel.Notifications;
        }


        private ObservableCollection<Notification> notifications = new ObservableCollection<Notification>();

        public ObservableCollection<Notification> Notifications {
            get {
                return notifications;
            }
            set {
                SetProperty(ref notifications, value);
            }
        }
    }
}
