using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker.Model
{
    class Model
    {
        List<Friend> friends = new List<Friend>();
        List<Borrow> borrowData = new List<Borrow>();
        List<Buscar> buscarData = new List<Buscar>();

        public Model(List<Friend> friends, List<Borrow> borrowData, List<Buscar> buscarData)
        {
            this.friends = friends;
            this.borrowData = borrowData;
            this.buscarData = buscarData;
        }

        internal List<Friend> Friends { get => friends; set => friends = value; }
        internal List<Borrow> BorrowData { get => borrowData; set => borrowData = value; }
        internal List<Buscar> BuscarData { get => buscarData; set => buscarData = value; }
    }
}
