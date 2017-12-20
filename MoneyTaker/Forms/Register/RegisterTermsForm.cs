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

        private void btnAgree_Click(object sender, EventArgs e)
        {
            formManager.ShowRegisterForm();
        }

        private void btnDisAgree_Click(object sender, EventArgs e)
        {
            formManager.ShowLoginIdForm();
        }
    }
}
