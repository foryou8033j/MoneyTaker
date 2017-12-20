using MaterialSkin.Controls;
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
    public partial class RootForm : MaterialForm
    {
        public RootForm()
        {
            InitializeComponent();
        }

        /**************************
         * getRootPanel : RootForm의 배경 Panel을 반환합니다.
         * return Panel
         **************************/
        public Panel GetRootPanel()
        {
            return panelRoot;
        }

        private void RootForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.setRootForm(this);
            loginForm.TopLevel = false;

            panelRoot.Controls.Add(loginForm);
            loginForm.Show();
        }

        
    }
}
