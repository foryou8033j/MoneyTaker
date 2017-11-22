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
    public partial class RegisterForm : Form
    {
        private LoginForm loginForm = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        public void setLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.getRootForm().Controls.Clear();
            loginForm.getRootForm().Controls.Add(loginForm);
        }
    }
}
