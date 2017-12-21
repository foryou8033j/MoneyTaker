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
    public partial class LoginPasswordForm : Form
    {
        private FormExchangeManager formManager;

        private String encryptedPassword = "";

        public LoginPasswordForm()
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

        private void CheckPassword(String input, String received)
        {
            //TextBox 입력된 암호 암호화 후 매칭 확인
            if (new EncryptTool().Encrypt(input).Equals(received))
            {
                tbPassword.Text = received;
                tbPassword.Enabled = false;
                MessageBox.Show("성공!");
            }
        }

        private async void LoginPasswordForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);

            if (new RegistryManager().IsAutoLogin())
                chbAutoLogin.Checked = true;

            //DB로부터 암호화된 패스워드 수신
            DataSet dataSet = ((RootForm)formManager.GetRootForm()).AccessDBManager().Select("User", "Email = '" + USERConfig.EMAIL + "'");
            DataRow datarow = dataSet.Tables[0].Rows[0];
            encryptedPassword = datarow["Password"].ToString();

            tbPassword.Focus();
        }

        private void btnOtherUser_Click(object sender, EventArgs e)
        {
            RegistryManager regMananger = new RegistryManager();
            regMananger.SetAutoLogin(false);
            regMananger.SetEmail("");

            formManager.ShowLoginIdForm();
        }

        private void chbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            RegistryManager regMananger = new RegistryManager();
            if (chbAutoLogin.CheckState == CheckState.Checked)
            {
                regMananger.SetAutoLogin(chbAutoLogin.Checked);
                regMananger.SetEmail(USERConfig.EMAIL);
            }
            else
            {
                regMananger.SetAutoLogin(chbAutoLogin.Checked);
                regMananger.SetEmail("");
            }
            

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbPassword.Text.Length > 6)
            {
                CheckPassword(tbPassword.Text, encryptedPassword);
            }
        }
    }
}
