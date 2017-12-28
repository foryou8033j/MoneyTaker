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
            ShowFriendForm();
            ShowBuscarForm();
            ShowBorrowForm();
            ShowHistoryForm();
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

        public void ShowFriendForm()
        {
            FriendForm friendForm = new FriendForm();
            friendForm.TopLevel = false;
            friendForm.Show();

            this.panelFriend.Controls.Add(friendForm);
        }

        public void ShowBuscarForm()
        {
            BuscarForm buscarForm = new BuscarForm();
            buscarForm.TopLevel = false;
            buscarForm.Show();

            this.panelBuscar.Controls.Add(buscarForm);
        }

        public void ShowBorrowForm()
        {
            BorrowForm borrowForm = new BorrowForm();
            borrowForm.TopLevel = false;
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
    }
}
