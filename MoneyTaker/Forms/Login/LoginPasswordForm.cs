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
        private RootForm rootForm;

        public LoginPasswordForm()
        {
            InitializeComponent();
        }

        public void setRootForm(RootForm rootForm)
        {
            this.rootForm = rootForm;
        }
        
        public RootForm getRootForm()
        {
            return rootForm;
        }
    }
}
