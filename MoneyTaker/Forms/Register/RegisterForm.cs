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
            if (tbEmail.Text.Length < 5 || !tbEmail.Text.Contains("@"))
            {
                //TODO : Material Design Alert 박스 오류있음. 수정 필요
                //new Alert(formManager.GetRootForm(), "오류", "올바른 이메일 주소를 입력 해 주세요.").Show();

                MessageBox.Show(formManager.GetRootForm(), "올바른 이메일 주소를 입력 해 주세요.", "오류", MessageBoxButtons.OK,MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            }
            else
            {
                new Thread(new ThreadStart(delegate ()
                {
                    MailManager.SendCode(tbEmail.Text, 17445);
                })).Start();
            }

            await Task.Delay(150);
            
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
        }
    }
}
