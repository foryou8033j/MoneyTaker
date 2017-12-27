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
    public partial class TabBasicForm : Form
    {
        private FormExchangeManager formManager;

        public TabBasicForm()
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

        private async void TabBasicForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }
    }
}
