using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace MoneyTaker
{
    public class Model
    {
        List<Friend> friends = new List<Friend>();
        List<Borrow> borrowData = new List<Borrow>();
        List<Buscar> buscarData = new List<Buscar>();

        public Model()
        {
           //Save();
           Load();
        }

        public Model(List<Friend> friends, List<Borrow> borrowData, List<Buscar> buscarData)
        {
            this.friends = friends;
            this.borrowData = borrowData;
            this.buscarData = buscarData;

        }

        public void Load()
        {

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("D:\\data.xml");
                XmlNodeList root1 = xml.SelectNodes("/Models/Borrow/Item");
                XmlNodeList root2 = xml.SelectNodes("/Models/Buscar/Item");
                XmlNodeList root3 = xml.SelectNodes("/Models/Friend/Item");

                foreach (XmlNode item in root1)
                {
                    borrowData.Add(new Borrow(item.Attributes["name"].Value,
                        Int32.Parse(item.Attributes["money"].Value),
                        Convert.ToDateTime(item.Attributes["startdate"].Value),
                        Convert.ToDateTime(item.Attributes["enddate"].Value),
                        item.Attributes["memo"].Value));
                }
                foreach (XmlNode item in root2) 
                {
                    buscarData.Add(new Buscar(item.Attributes["name"].Value,
                        Int32.Parse(item.Attributes["money"].Value),
                        Convert.ToDateTime(item.Attributes["startdate"].Value),
                        Convert.ToDateTime(item.Attributes["enddate"].Value),
                        item.Attributes["memo"].Value));
                }
                foreach (XmlNode item in root3)
                {
                    friends.Add(new Friend(item.Attributes["name"].Value,
                        item.Attributes["email"].Value,
                        item.Attributes["group"].Value,
                        Int32.Parse(item.Attributes["credibility"].Value),
                        item.Attributes["uguid"].Value,
                        item.Attributes["gguid"].Value,
                        Int32.Parse(item.Attributes["tag"].Value)));
                }
            }catch (Exception e)
            {
                
            }
            
            
        }

        public void Save()
        {
            buscarData.Add(new Buscar("서정삼", 5000, DateTime.Now, DateTime.Now, "육개장"));
            buscarData.Add(new Buscar("홍지원", 50000, DateTime.Now, DateTime.Now, "다이아몬드"));
            buscarData.Add(new Buscar("김정은", 500000, DateTime.Now, DateTime.Now, "미사일"));
            borrowData.Add(new Borrow("서정삼", 5000, DateTime.Now, DateTime.Now, "육개장"));
            borrowData.Add(new Borrow("홍지원", 50000, DateTime.Now, DateTime.Now, "다이아몬드"));
            borrowData.Add(new Borrow("김정은", 500000, DateTime.Now, DateTime.Now, "미사일"));
            friends.Add(new Friend("홍지원", "wldnjs8236@naver.com", "친구", 10," "," ",0));
            friends.Add(new Friend("서정삼", "xxxxxx@naver.com", "친구", 10, " ", " ", 0));

            XmlDocument xml = new XmlDocument();
            XmlNode root = xml.CreateElement("Models");
            xml.AppendChild(root);
            XmlNode buscarRoot = xml.CreateElement("Buscar");
            foreach (Buscar item in BuscarData)
            {
                XmlNode buscarItem = xml.CreateElement("Item");

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                buscarItem.Attributes.Append(name);

                XmlAttribute price = xml.CreateAttribute("money");
                price.Value = item.Money.ToString();
                buscarItem.Attributes.Append(price);

                XmlAttribute startdate = xml.CreateAttribute("startdate");
                startdate.Value = item.Startdate.ToString();
                buscarItem.Attributes.Append(startdate);

                XmlAttribute enddate = xml.CreateAttribute("enddate");
                enddate.Value = item.Enddate.ToString();
                buscarItem.Attributes.Append(enddate);

                XmlAttribute memo = xml.CreateAttribute("memo");
                memo.Value = item.Memo;
                buscarItem.Attributes.Append(memo);

                buscarRoot.AppendChild(buscarItem);
            }
            root.AppendChild(buscarRoot);

            XmlNode borrowRoot = xml.CreateElement("Borrow");
            foreach (Borrow item in BorrowData)
            {
                XmlNode borrowItem = xml.CreateElement("Item");

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                borrowItem.Attributes.Append(name);

                XmlAttribute price = xml.CreateAttribute("money");
                price.Value = item.Money.ToString();
                borrowItem.Attributes.Append(price);

                XmlAttribute startdate = xml.CreateAttribute("startdate");
                startdate.Value = item.Startdate.ToString();
                borrowItem.Attributes.Append(startdate);

                XmlAttribute enddate = xml.CreateAttribute("enddate");
                enddate.Value = item.Enddate.ToString();
                borrowItem.Attributes.Append(enddate);

                XmlAttribute memo = xml.CreateAttribute("memo");
                memo.Value = item.Memo;
                borrowItem.Attributes.Append(memo);

                borrowRoot.AppendChild(borrowItem);
            }
            root.AppendChild(borrowRoot);


            XmlNode friendsRoot = xml.CreateElement("Friend");
            foreach (Friend item in Friends)
            {
                XmlNode friendsItem = xml.CreateElement("Item");

                XmlAttribute group = xml.CreateAttribute("group");
                group.Value = item.Group;
                friendsItem.Attributes.Append(group);

                XmlAttribute name = xml.CreateAttribute("name");
                name.Value = item.Name;
                friendsItem.Attributes.Append(name);

                XmlAttribute email = xml.CreateAttribute("email");
                email.Value = item.Email;
                friendsItem.Attributes.Append(email);

                XmlAttribute credibility = xml.CreateAttribute("credibility");
                credibility.Value = item.Credibility.ToString();
                friendsItem.Attributes.Append(credibility);

                XmlAttribute uguid = xml.CreateAttribute("uguid");
                uguid.Value = item.Uguid;
                friendsItem.Attributes.Append(uguid);

                XmlAttribute gguid = xml.CreateAttribute("gguid");
                gguid.Value = item.Gguid;
                friendsItem.Attributes.Append(gguid);

                XmlAttribute tag = xml.CreateAttribute("tag");
                tag.Value = item.Tag.ToString();
                friendsItem.Attributes.Append(tag);

                friendsRoot.AppendChild(friendsItem);
            }
            root.AppendChild(friendsRoot);

            xml.Save("D:\\data.xml");

        }

        internal List<Friend> Friends { get => friends; set => friends = value; }
        internal List<Borrow> BorrowData { get => borrowData; set => borrowData = value; }
        internal List<Buscar> BuscarData { get => buscarData; set => buscarData = value; }
    }
}
