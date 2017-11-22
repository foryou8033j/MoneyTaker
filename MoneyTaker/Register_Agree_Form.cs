using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoneyTaker
{
    public partial class Register_Agree_Form : Form
    {
        private LoginForm loginForm = null;

        public Register_Agree_Form()
        {
            InitializeComponent();
        }

        public void setLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisAgree_Click(object sender, EventArgs e)
        {

            loginForm.getRootForm().getRootPanel().Controls.Clear();
            loginForm.getRootForm().getRootPanel().Controls.Add(loginForm);


        }
    }
}
