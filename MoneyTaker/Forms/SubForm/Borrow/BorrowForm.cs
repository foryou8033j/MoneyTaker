﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoneyTaker
{
    public partial class BorrowForm : Form
    {

        private FormExchangeManager formManager;

        public BorrowForm()
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

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            formManager.GetRootFormClass().AccessModel().Load();

            BorrowData.Rows.Clear();

            foreach(Borrow item in formManager.GetRootFormClass().AccessModel().BorrowData)
            {
                string[] row = { item.Name, item.Money.ToString(), item.Startdate.ToString(), item.Enddate.ToString(), item.Memo };
                BorrowData.Rows.Add(row);
            }
        }

        private void BorrowData_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;

            if (e.Button == MouseButtons.Right)
            {
                hitTestInfo = BorrowData.HitTest(e.X, e.Y);

                int col = hitTestInfo.ColumnIndex;
                int row = hitTestInfo.RowIndex;

                if (col < 0) col = 0;
                if (row < 0) row = 0;

                this.BorrowData.CurrentCell = this.BorrowData[col, row];

                ContextMenuStrip menu = new ContextMenuStrip();

                menu.Items.Add("수    정");
                menu.Items.Add("삭    제");

                menu.ItemClicked += new ToolStripItemClickedEventHandler(BorrowMenu_ItemClicked);

                menu.Show(BorrowData, new Point(e.X, e.Y));
            }
        }

        private void BorrowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "수    정":
                    MessageBox.Show("수정하겠습니다");
                    break;
                case "삭    제":
                    MessageBox.Show("삭제하겠습니다");
                    break;
            }
        }
    }
}
