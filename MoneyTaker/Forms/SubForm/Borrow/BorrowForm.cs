using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoneyTaker
{
    public partial class BorrowForm : Form
    {

        private FormExchangeManager formManager;

        public BorrowForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Manager와 연동합니다.
        /// </summary>
        /// <param name="formManager"></param>
        public void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            //formManager.GetRootFormClass().AccessModel().Load();

            foreach(Borrow item in formManager.GetRootFormClass().AccessModel().BorrowData)
            {

                string[] row = { item.Name, item.Money.ToString(), item.Startdate.ToString(), item.Enddate.ToString(), item.Memo };
                //MessageBox.Show(row.ToString());
                BorrowData.Rows.Add(row);

            }


        }
    }
}
