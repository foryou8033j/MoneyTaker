using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Friend
    {
        String name;
        String email;
        String group;
        int credibility;

        public Friend(String name, String email,String group, int credibility)
        {
            this.name = name;
            this.email = email;
            this.group = group;
            this.credibility = credibility;
        }
        public String getName()
        {
            return name;
        }

        public String getEmail()
        {
            return email;
        }

        public String getGroup()
        {
            return group;
        }

        public int getCredibility()
        {
            return credibility;
        }
    }

