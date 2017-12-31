using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Buscar
    {
        String name;
        int money;
        DateTime startdate, closingDate;
        String memo;

        public Buscar(String name, int money, DateTime startdate, DateTime closingDate)
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
