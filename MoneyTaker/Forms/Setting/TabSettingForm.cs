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
        private int panelWidth;
        private bool flagBtn = true;
        FormExchangeManager formManager;

        public TabSettingForm()
        {
            InitializeComponent();
            panelWidth = this.panelFunction.Width;
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

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if(flagBtn)
            {
                this.tmFunction.Start();
                this.btnFunction.Text = "◀";
            }
            else
            {
                this.tmFunction.Start();
                this.btnFunction.Text = "▶";
            }
            
        }

        private void tmFunction_Tick(object sender, EventArgs e)
        {
            if(flagBtn)
            {
                this.panelFunction.Width = this.panelFunction.Width + 5;
                if(this.panelFunction.Width == 430)
                {
                    this.tmFunction.Stop();
                    flagBtn = false;
                    this.Refresh();
                }
            }
            else
            {
                this.panelFunction.Width = this.panelFunction.Width - 5;
                if(this.panelFunction.Width == panelWidth)
                {
                    this.tmFunction.Stop();
                    flagBtn = true;
                    this.Refresh();
                }
            }
        }

        private async void btnClose_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);
            formManager.ShowTabBasicForm();
        }
    }
}
