using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class RegisterForm : Form
    {

        private FormExchangeManager formManager;
        private bool sendEmail = false;
        private bool confirm = false;
        private String code = "";

        private static String email = "";

        private bool passPassword = false;

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

            if (confirm)
                tbEmail.Text = email;

            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }

        /// <summary>
        /// 인증 버튼을 눌렀을때 진행되는 동작을 수행하는 버튼 클릭 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            lbnEmailNotification.ForeColor = Color.OrangeRed;

            if (!sendEmail && (tbEmail.Text.Length < 5 || !ClarifyManager.IsEmail(tbEmail.Text)))
            {
                //TODO : Material Design Alert 박스 오류있음. 수정 필요
                //formManager.ShowAlert(name, this, "오류", "올바른 이메일 주소를 입력 해 주세요.");
                //new Alert(formManager.GetRootForm(), this, "오류", "올바른 이메일 주소를 입력 해 주세요.").Show();

                lbnEmailNotification.Text = "올바른 이메일 주소를 입력 해 주세요.";
                shakeControlAsync(tbEmail);
            }
            else if (!sendEmail)
            {

                if (formManager.GetRootFormClass().AccessDBManager().ExistUserEmail(tbEmail.Text)){
                    shakeControlAsync(tbEmail);
                    lbnEmailNotification.Text = "존재하는 이메일 입니다.";
                    return;
                }

                new Thread(new ThreadStart(delegate ()
                {
                    Cursor = Cursors.WaitCursor;
                    email = tbEmail.Text;
                    tbEmail.Enabled = false;
                    btnConfirmEmail.Enabled = false;
                    lbnEmailNotification.Text = "인증 이메일 전송 중 입니다.";

                    Random random = new Random();
                    for (int i = 0; i < 5; i++)
                        code += random.Next(0, 9).ToString();

                    if (MailManager.SendCode(tbEmail.Text, code))
                    {
                        Cursor = Cursors.Default;
                        lbnEmailNotification.Text = "발송 성공! 메일함을 확인 해 주세요.";
                        lbnEmail.Text = "인증코드";
                        tbEmail.Text = "";
                        tbEmail.Enabled = true;
                        tbEmail.Hint = "인증코드를 입력 해 주세요.";
                        btnConfirmEmail.Enabled = true;
                        btnConfirmEmail.Text = "재전송";
                        sendEmail = true;
                    }
                    else
                    {
                        tbEmail.Enabled = true;
                        btnConfirmEmail.Enabled = true;
                        lbnEmailNotification.Text = "인증 이메일 전송에 실패하였습니다.";
                        sendEmail = false;
                    }
                })).Start();
            }
            else
            {
                lbnEmailNotification.Text = "";
                lbnEmail.Text = "E-Mail";
                tbEmail.Hint = "E-Mail";
                tbEmail.Text = email;
                btnConfirmEmail.Text = "인증";
                sendEmail = false;
                confirm = false;
            }

            await Task.Delay(150);
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);

            if(confirm && tbPassword.Text.Equals(tbPasswordReType.Text))
            {
                if(formManager.GetRootFormClass().AccessDBManager().InsertRegisterData(tbEmail.Text, tbPassword.Text))
                {
                    formManager.ShowLoginIdForm();
                }
            }
            else
            {
                shakeControlAsync(btnRegister);
            }
        }

        // 특정 컨트롤 흔든다
        private async void shakeControlAsync(Control control)
        {
            Point prefLocation = control.Location;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) control.Location = new Point(control.Location.X - 7, control.Location.Y);
                else control.Location = new Point(control.Location.X + 7, control.Location.Y);
                await Task.Delay(30);
            }

            control.Location = prefLocation;
        }

        /// <summary>
        /// 이메일 텍스트 박스 입력 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (sendEmail && !confirm)
            {
                if (tbEmail.Text.Equals(code))
                {
                    confirm = true;
                    lbnEmailNotification.Text = "인증되었습니다.";
                    tbPassword.Enabled = true;
                    tbPasswordReType.Enabled = true;
                    tbEmail.Enabled = false;
                    tbEmail.Text = email;
                    lbnEmail.Text = "E-Mail";
                    tbEmail.Hint = "E-Mail";
                    btnConfirmEmail.Visible = false;
                }
            }
        }

        /// <summary>
        /// 패스워드 입력 박스의 검사를 수행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbnEmailNotification.Text = "";

            //패스워드 입력 보안 검사 - 보안 강함
            if (Regex.IsMatch(tbPassword.Text, @"[~`!@#$%^&*()_\-+={}[\]|\\;:'""<>,.?/]"))
            {
                lbnPasswordSecurity.ForeColor = Color.Green;
                tbPassword.ForeColor = Color.Green;
                lbnPasswordSecurity.Text = "강력";
                lbnPasswordNotification.Text = "";
                lbnPasswordNotification.Text = "완벽합니다!";
                tbPasswordReType.Enabled = true;
                tbPasswordReType.Text = "";
                passPassword = true;
            }
            //패스워드 입력 보안 검사 - 보안 중간(패스워드 통과)
            else if (Regex.IsMatch(tbPassword.Text, @"[0-9]") && tbPassword.Text.Length > 6)
            {
                lbnPasswordSecurity.ForeColor = Color.BlueViolet;
                tbPassword.ForeColor = Color.BlueViolet;
                lbnPasswordSecurity.Text = "보통";
                lbnPasswordNotification.Text = "특수문자가 있으면 더욱 좋습니다.";
                tbPasswordReType.Enabled = true;
                tbPasswordReType.Text = "";
                passPassword = true;
            }
            //패스워드 보안 미흡
            else if (Regex.IsMatch(tbPassword.Text, @"[a-zA-Z]"))
            {
                lbnPasswordSecurity.ForeColor = Color.YellowGreen;
                tbPassword.ForeColor = Color.YellowGreen;
                lbnPasswordSecurity.Text = "미흡";
                lbnPasswordNotification.ForeColor = Color.OrangeRed;
                lbnPasswordNotification.Text = "6자 이상의 영문자/숫자가 포함되어야합니다.";
                tbPasswordReType.Enabled = false;
                passPassword = false;
            }
            else //예외경우 처리
            {
                lbnPasswordSecurity.Text = "";
                lbnPasswordNotification.Text = "";
                tbPasswordReType.Text = "";
                tbPasswordReType.Enabled = false;
                passPassword = false;
            }

            //패스워드 다 입력 해 놓고 지웠을경우
            if (!passPassword)
            {
                lbnPassword.ForeColor = Color.White;
                lbnPasswordRetype.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// 패스워드 재입력 텍스트박스의 입력 검사를 수행한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPasswordReType_TextChanged(object sender, EventArgs e)
        {
            if (passPassword)
            {
                if (tbPasswordReType.Text.Equals(tbPassword.Text))
                {
                    lbnPassword.ForeColor = Color.GreenYellow;
                    lbnPasswordRetype.ForeColor = Color.GreenYellow;
                }
                else
                {
                    lbnPasswordNotification.Text = "";
                    lbnPassword.ForeColor = Color.White;
                    lbnPasswordRetype.ForeColor = Color.OrangeRed;
                }
            }
            else
            {
                lbnPassword.ForeColor = Color.White;
                lbnPasswordRetype.ForeColor = Color.White;
            }

        }
    }
}
