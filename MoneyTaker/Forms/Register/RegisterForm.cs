using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class RegisterForm : Form
    {

        private FormExchangeManager formManager;

        public RegisterForm()
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

        private async void btnCancle_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
            formManager.ShowLoginIdForm();
        }

        private async void RegisterForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }

        private async void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
        }
    }
}
