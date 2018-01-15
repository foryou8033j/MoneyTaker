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
    public partial class AddTradeSecondForm : Form
    {
        private FormExchangeManager formManager;
        private AddTradeFirstForm tradeFirstForm;

        public AddTradeSecondForm()
        {
            InitializeComponent();
        }

        public void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        public void SetTradeFirstForm(AddTradeFirstForm tradeFirstForm)
        {
            this.tradeFirstForm = tradeFirstForm;
        }

        private void ShowThisForm()
        {
            
        }

        private async void AddTradeSecondForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tradeFirstForm.GetTradePanel().Controls.Clear();
            tradeFirstForm.GetTradePanel().Controls.Add(tradeFirstForm);
        }

        private async void AddTradeSecondForm_Shown(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }
    }
}
