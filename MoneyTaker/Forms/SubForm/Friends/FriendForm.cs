using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class FriendForm : Form
    {
        private FormExchangeManager formManager;

        public FriendForm()
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

        private void FriendForm_Load(object sender, EventArgs e)
        {
            foreach (Friend item in formManager.GetRootFormClass().AccessModel().Friends)
            {

                string[] row = { item.Group, item.Name, item.Email, item.Credibility.ToString() };
                FriendData.Rows.Add(row);

            }
        }
    }
}