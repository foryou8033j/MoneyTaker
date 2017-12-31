using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTaker.Model
{
    class Model
    {
        private List<User> friends = new List<User>();
        private List<IOU> iouData = new List<IOU>();

        public Model(List<User> friends, List<IOU> iouData)
        {
            this.friends = friends;
            this.iouData = iouData;
        }

        internal List<User> Friends
        {
            get{return friends;}
            set{friends = value;}
        }

        internal List<IOU> IouData
        {
            get { return iouData; }
            set { iouData = value; }
        }
    }
}
