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
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        public Panel getRootPanel()
        {
            return panel_Root;
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.setRootForm(this);
            loginForm.TopLevel = false;

            panel_Root.Controls.Add(loginForm);
            loginForm.Show();

        }

        
    }
}
