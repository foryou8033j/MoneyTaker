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
    public partial class BuscarForm : Form
    {
        private FormExchangeManager formManager;

        public BuscarForm()
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

        private void BuscarForm_Load(object sender, EventArgs e)
        {

            formManager.GetRootFormClass().AccessModel().Load();

            BuscarData.Rows.Clear();

            foreach (Buscar item in formManager.GetRootFormClass().AccessModel().BuscarData)
            {
                string[] row = { item.Name, item.Money.ToString(), item.Startdate.ToString(), item.Enddate.ToString(), item.Memo };
                BuscarData.Rows.Add(row);

            }
        }
    }
}
