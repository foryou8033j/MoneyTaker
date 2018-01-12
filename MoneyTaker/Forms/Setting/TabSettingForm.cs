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
    public partial class TabSettingForm : Form
    {
        private FormExchangeManager formManager;

        public TabSettingForm()
        {
            InitializeComponent();
            ShowInformationForm();
        }

        internal void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private async void TabSettingForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }

        private async void btnSettingSetting_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);

            formManager.ShowTabBasicForm();
        }

        public void ShowInformationForm()
        {
            MyInforForm myInforForm = new MyInforForm();
            myInforForm.TopLevel = false;
            myInforForm.Show();

            this.panelMyinfo.Controls.Add(myInforForm);
        }
    }
}
