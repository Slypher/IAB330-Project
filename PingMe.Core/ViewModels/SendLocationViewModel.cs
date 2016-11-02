using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using PingMe.Core.Classes;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace PingMe.Core.ViewModels {
    public class SendLocationViewModel : MvxViewModel {

        public SendLocationViewModel() {


        }

        /*
         * Contains the user that was requesting location as well as the time that user requested
         */ 
        private Notification requestData;
        public Notification RequestData {
            get { return requestData; }
            set { requestData = value; }
        }

        /*
         * Text to display at the top (with user name)
         */
        private string titleText;
        public string TitleText {
            get { return titleText; }
            set { titleText = value; RaisePropertyChanged(() => TitleText); }
        }

        public void Init(int id) {
            RequestData = DataModel.Notifications[id];
            // Set the title text
            TitleText = "Send " + RequestData.Sender.Name + " your location.";
        }


    }
}