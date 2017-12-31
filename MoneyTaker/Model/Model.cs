using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker.Model
{
    class Model
    {
        List<Friend> Friends = new List<Friend>();
        List<Borrow> BorrowData = new List<Borrow>();
        List<Buscar> BuscarData = new List<Buscar>();

        public Model(List<Friend> Friends, List<Borrow> BorrowData, List<Buscar> BuscarData)
        {
            this.Friends = Friends;
            this.BorrowData = BorrowData;
            this.BuscarData = BuscarData;
        }
        public List<Friend> getFriends()
        {
            return Friends;
        }

        public List<Borrow> getBorrowData()
        {
            return BorrowData;
        }

        public List<Buscar> getBuscarData()
        {
            return BuscarData;
        }

    }
}
