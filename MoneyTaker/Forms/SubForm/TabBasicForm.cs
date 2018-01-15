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
        private int panelHeight;
        private bool panelHide;

        public TabBasicForm()
        {
            InitializeComponent();
            
            panelHeight = this.panelSetting.Height;
            panelHide = true;
        }

        /// <summary>
        /// Form Manager와 연동합니다.
        /// </summary>
        /// <param name="formManager"></param>
        internal void SetFormManager(FormExchangeManager formManager)
        {
            this.formManager = formManager;
        }

        private async void TabBasicForm_LoadAsync(object sender, EventArgs e)
        {

            // TabBasicForm 초기화시에 하부 Form을 Load하던것을 LoadAsync 시에 Load 하는것으로 변경
            // 수정 사유 : FormExchangeManager 객체와 연결이전(SetFormManager 호출 이전) 에 하부 폼에서
            // Load 할 때 AccessModel() 메소드가 동작하여 NullPointException 발생
            // Modify : 2018-01-13 서정삼
            ShowFriendForm();
            ShowBuscarForm();
            ShowBorrowForm();
            ShowHistoryForm();

            for (Width = 0; Width < 700; Width += 50)
                await Task.Delay(1);
        }

        public void ShowFriendForm()
        {
            FriendForm friendForm = new FriendForm();
            friendForm.TopLevel = false;
            friendForm.SetFormManager(formManager);
            friendForm.Show();

            this.panelFriend.Controls.Add(friendForm);
        }

        public void ShowBuscarForm()
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.TopLevel = false;
            buscarForm.SetFormManager(formManager);
            buscarForm.Show();

            this.panelBuscar.Controls.Add(buscarForm);
        }

        public void ShowBorrowForm()
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.TopLevel = false;
            borrowForm.SetFormManager(formManager);
            borrowForm.Show();

            this.panelBorrow.Controls.Add(borrowForm);
        }

        public void ShowHistoryForm()
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.TopLevel = false;
            historyForm.Show();

            this.panelHistory.Controls.Add(historyForm);
        }

        private void tmSetting_Tick(object sender, EventArgs e)
        {
            if(panelHide)
            {
                this.panelSetting.Height = this.panelSetting.Height + 5;
                if(this.panelSetting.Height == 80)
                {
                    this.tmSetting.Stop();
                    panelHide = false;
                    this.Refresh();
                }
            }
            else
            {
                this.panelSetting.Height = this.panelSetting.Height - 5;
                if(this.panelSetting.Height == panelHeight)
                {
                    this.tmSetting.Stop();
                    panelHide = true;
                    this.Refresh();
                }
            }
        }
        private async void btnAddFriend_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);

            formManager.ShowPlusFriendForm();
        }

        private void btnShowSetting_Click(object sender, EventArgs e)
        {
            if (panelHide)
            {
                this.tmSetting.Start();
                this.btnShowSetting.Text = "▲";
            }
            else
            {
                this.tmSetting.Start();
                this.btnShowSetting.Text = "▼";
            }
        }

        private async void btnSettingFriend_ClickAsync(object sender, EventArgs e)
        {
            await Task.Delay(150);

            formManager.ShowTabSettingForm();
        }

        private async void btnAddTrade_Click(object sender, EventArgs e)
        {
            await Task.Delay(150);
        }
    }
}
