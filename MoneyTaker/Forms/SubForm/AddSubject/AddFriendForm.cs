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
    public partial class AddFriendForm : Form
    {
        private FormExchangeManager formManager;

        public AddFriendForm()
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formManager.ShowTabBasicForm();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            formManager.GetRootFormClass().AccessModel().Friends.Add(new Friend(tbName.Text));

            formManager.GetRootFormClass().AccessModel().Save();
            formManager.ShowTabBasicForm();
        }
    }
}
