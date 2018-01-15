using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker
{
    class User
    {
        private String name;
        private String uguid;
        private String group;
        private int credit;

        public User(String name, String email, String group, int credit)
        {
            this.name = name;
            this.uguid = email;
            this.group = group;
            this.credit = credit;
        }
        internal String Name
        {
            get { return name; }
            set { name = value; }
        }

        internal String Uguid
        {
            get { return uguid; }
            set { uguid = value; }
        }

        internal String Group
        {
            get { return group; }
            set { group = value; }
        }

        internal int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
    }
}