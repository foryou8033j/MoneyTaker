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
    public partial class LoginIdForm : Form
    {
        private FormExchangeManager formManager;

        public LoginIdForm()
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

        private async void btnJoin_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);
            formManager.ShowRegisterTermsForm();
        }

        private async void LoginIdForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);

            if (new RegistryManager().IsAutoLogin())
            {
                //레지스트리로부터 이메일 값만 가져오고 인증여부는 TextBox Changed에 맡긴다.
                tbEmail.Text = new RegistryManager().GetEmail();
            }
        }

        private async void btnFindEmail_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if(tbEmail.Text.Length > 8)
            {
                if (((RootForm)formManager.GetRootForm()).AccessDBManager().ExistUserEmail(tbEmail.Text))
                {
                    USERConfig.EMAIL = tbEmail.Text;
                    formManager.ShowLoginPassForm();
                }
                    
            }
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
