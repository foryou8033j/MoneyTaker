using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Borrow
    {
        String name;
        int money;
        DateTime startdate;
        DateTime closingDate;
        String memo;

        public Borrow(String name, int money, DateTime startdate, DateTime closingDate)
        {
            this.name = name;
            this.money = money;
            this.startdate = startdate;
            this.closingDate = closingDate;
        }

        public String getName()
        {
            return name;
        }

        public int getMoney()
        {
            return money;
        }

        public DateTime getStrirdate()
        {
            return startdate;
        }

        public DateTime getClosingDate()
        {
            return closingDate;
        }

    }

