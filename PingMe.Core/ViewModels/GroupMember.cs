

namespace PingMe.Core.ViewModels {
    public class GroupMember {

        string name;
        int id;

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public GroupMember(string name, int id) {
            Name = name;
            Id = id;
        }
    }
}
