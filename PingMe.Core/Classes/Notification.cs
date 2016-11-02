using PingMe.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingMe.Core.Classes {
    /*
     * This is an individual location request. 
     * Contains a reference to the member who sent you the notification.
     */
    public class Notification {

        private GroupMember sender;
        public GroupMember Sender { get { return sender; } set { sender = value; } }

        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }


        public Notification(GroupMember sender, DateTime date) {
            Sender = sender;
            if (date == null)
                Date = DateTime.Now;
            else
                Date = date;
           
        }

        public override string ToString() {
            string timeSince = "";
            TimeSpan ts = DateTime.Now.Subtract(Date);
            if (ts.TotalMinutes < 5) {
                timeSince = "Moments Ago";
            } else if (ts.TotalHours < 1) {
                timeSince = Convert.ToInt32(ts.TotalMinutes).ToString() + " minutes ago";
            } else if (ts.TotalDays < 1) {
                timeSince = Convert.ToInt32(ts.TotalHours).ToString() + " hours ago";
            } else {
                timeSince = Date.ToString();
            }
            return ("Location request from: " + sender.Name + " [" + timeSince + "]");
        }
    }
}
