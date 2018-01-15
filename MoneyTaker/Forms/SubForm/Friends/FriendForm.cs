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
    public partial class FriendForm : Form
    {
        private FormExchangeManager formManager;

        public FriendForm()
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

        private void FriendForm_Load(object sender, EventArgs e)
        {

            formManager.GetRootFormClass().AccessModel().Load();

            FriendData.Rows.Clear();

            foreach (Friend item in formManager.GetRootFormClass().AccessModel().Friends)
            { 
                string[] row = { item.Group, item.Name, item.Email, item.Credibility.ToString() };
                FriendData.Rows.Add(row);
            }
        }
        
        private void FriendData_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;

            if(e.Button == MouseButtons.Right)
            {
                hitTestInfo = FriendData.HitTest(e.X, e.Y);

                int col = hitTestInfo.ColumnIndex;
                int row = hitTestInfo.RowIndex;

                if (col < 0) col = 0;
                if (row < 0) row = 0;

                this.FriendData.CurrentCell = this.FriendData[col, row];

                ContextMenuStrip menu = new ContextMenuStrip();

                menu.Items.Add("수    정");
                menu.Items.Add("삭    제");

                menu.ItemClicked += new ToolStripItemClickedEventHandler(FriendMenu_ItemClicked);

                menu.Show(FriendData, new Point(e.X, e.Y));
            }
        }

        private void FriendMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Text)
            {
                case"수    정":
                    MessageBox.Show("수정하겠습니다");
                    break;
                case "삭    제":
                    MessageBox.Show("삭제하겠습니다");
                    break;
            }
        }
        
    }
}