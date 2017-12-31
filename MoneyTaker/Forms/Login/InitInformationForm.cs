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
    public partial class InitInformationForm : Form
    {

        private FormExchangeManager formManager;

        public InitInformationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Manager와 연동합니다.
        /// </summary>
        /// <param name="formManager"></param>
        internal void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private void SaveName()
        {
            if (!tbName.Text.Equals(""))
            {
                formManager.GetRootFormClass().AccessDBManager().UpdateUserName(USERConfig.EMAIL, tbName.Text);
                formManager.ShowTabBasicForm();
                formManager.ShowFindIdForm();
            }
            else
            {
                shakeControlAsync(tbName);
            }
        }

        private async void InitInformationForm_LoadAsync(object sender, EventArgs e)
        {
            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);

            SaveName();

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

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveName();
            }
        }
    }
}
