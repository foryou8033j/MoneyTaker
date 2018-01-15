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
    public partial class AddTradeFirstForm : Form
    {
        private FormExchangeManager formManager;
        private Panel tradePanel;

        private AddTradeSecondForm tradeSecondForm;

        public AddTradeFirstForm()
        {
            InitializeComponent();
        }

        public void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        public void SetTradePanel(Panel panel)
        {
            this.tradePanel = panel;
        }

        public Panel GetTradePanel()
        {
            return tradePanel;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);

            if (tradePanel != null)
            {
                tradePanel.Controls.Clear();
                tradeSecondForm.Show();
                tradePanel.Controls.Add(tradeSecondForm);
            }
        }

        private async void AddTradeFirstForm_Load(object sender, EventArgs e)
        {
            tradeSecondForm = new AddTradeSecondForm();
            tradeSecondForm.SetFormManager(formManager);
            tradeSecondForm.SetTradeFirstForm(this);
            tradeSecondForm.TopLevel = false;


        }

        private async void AddTradeFirstForm_Shown(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }
    }
}
