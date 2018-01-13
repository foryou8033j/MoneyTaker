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
    public partial class PlusFriendForm : Form
    {
        private FormExchangeManager formManager;

        public PlusFriendForm()
        {
            InitializeComponent();
        }

        internal void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private async void PlusFriendForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);

            string[] data = { "오프라인", "온라인" };

            this.cbOnOff.Items.AddRange(data);
            this.cbOnOff.SelectedIndex = 0;
        }

        private void cbOnOff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbOnOff.SelectedIndex == 0)
            {
                this.tbPlus.Hint = "이름";
            }
            else
            {
                this.tbPlus.Hint = "이름 / 태그 / 이메일";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formManager.ShowTabBasicForm();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            formManager.ShowTabBasicForm();
        }
    }
}
