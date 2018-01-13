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

            this.cbMode.Items.AddRange(data);
            this.cbMode.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formManager.ShowTabBasicForm();
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbMode.SelectedIndex == 0)
            {
                this.tbName.Hint = "이름";
            }
            else
            {
                this.tbName.Hint = "이름 / 태그 / 이메일";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            formManager.GetRootFormClass().AccessModel().Friends.Add(new Friend(tbName.Text));

            formManager.GetRootFormClass().AccessModel().Save();
            formManager.ShowTabBasicForm();
        }
    }
}
