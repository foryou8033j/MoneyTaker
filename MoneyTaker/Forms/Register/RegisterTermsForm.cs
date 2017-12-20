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
    public partial class RegisterTermsForm : Form
    {
        FormExchangeManager formManager;

        public RegisterTermsForm()
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

        private async void btnAgree_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);
            formManager.ShowRegisterForm();
        }

        private async void btnDisAgree_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);
            formManager.ShowLoginIdForm();
        }

        private async void RegisterTermsForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 40)
                await Task.Delay(1);
        }
    }
}
