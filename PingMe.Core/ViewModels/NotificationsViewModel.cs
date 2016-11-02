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
            Locations = DataModel.Locations;

            // Setup command
            LocationSelectedCommand = new MvxCommand(() => {
                ShowViewModel<ReceiveLocationViewModel>();
            });
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

        /*
         * When selecting item from locations
         */
         public System.Windows.Input.ICommand LocationSelectedCommand { get; private set; }

        private void DoSelectItem(Notification item) {
            int id = DataModel.Notifications.IndexOf(item);
            ShowViewModel<SendLocationViewModel>(new { id = id });
        }

        // For requests
        private ObservableCollection<Notification> notifications = new ObservableCollection<Notification>();
        public ObservableCollection<Notification> Notifications {
            get {
                return notifications;
            }
            set {
                SetProperty(ref notifications, value);
            }
        }

        // For recieved locations
        private ObservableCollection<Notification> locations = new ObservableCollection<Notification>();
        public ObservableCollection<Notification> Locations {
            get {
                return locations;
            }
            set {
                SetProperty(ref locations, value);
            }
        }

    }
}
