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
    public partial class AddTradeForm : Form
    {
        private FormExchangeManager formManager;

        public AddTradeForm()
        {
            InitializeComponent();
        }

        internal void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private async void btnCancle_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);

            formManager.ShowTabBasicForm();
        }

        private async void AddTradeForm_Load(object sender, EventArgs e)
        {

            // Tab Form Add
            AddTradeFirstForm tradeFirstForm = new AddTradeFirstForm();
            tradeFirstForm.TopLevel = false;
            tradeFirstForm.SetFormManager(formManager);
            tradeFirstForm.SetTradePanel(panelTrade);
            tradeFirstForm.Show();

            panelTrade.Controls.Add(tradeFirstForm);

            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);

        }
    }
}
