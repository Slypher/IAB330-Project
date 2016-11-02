using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using PingMe.Core.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PingMe.Core.ViewModels {
    public class NotificationsViewModel : MvxViewModel {

        public NotificationsViewModel() {
            // Pull notification data 
            Notifications = DataModel.Notifications;
        }


        /*
         * When selecting item from list
         */
        private MvxCommand<Notification> itemSelectedCommand;

        public System.Windows.Input.ICommand ItemSelectedCommand {
            get {
                itemSelectedCommand = itemSelectedCommand ?? new MvxCommand<Notification>(DoSelectItem);
                return itemSelectedCommand;
            }
        }

        private void DoSelectItem(Notification item) {
            int id = DataModel.Notifications.IndexOf(item);
            ShowViewModel<SendLocationViewModel>(new { id = id });
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
