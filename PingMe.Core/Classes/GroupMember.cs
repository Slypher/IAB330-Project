﻿

namespace PingMe.Core.Classes {
    public class GroupMember {

        string name;
        int id;

        public override string ToString() {
            return Name;
        }

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
