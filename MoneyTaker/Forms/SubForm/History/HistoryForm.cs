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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void HistoryData_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;

            if (e.Button == MouseButtons.Right)
            {
                hitTestInfo = HistoryData.HitTest(e.X, e.Y);

                int col = hitTestInfo.ColumnIndex;
                int row = hitTestInfo.RowIndex;

                if (col < 0) col = 0;
                if (row < 0) row = 0;

                this.HistoryData.CurrentCell = this.HistoryData[col, row];

                ContextMenuStrip menu = new ContextMenuStrip();

                menu.Items.Add("수    정");
                menu.Items.Add("삭    제");

                menu.ItemClicked += new ToolStripItemClickedEventHandler(HistoryMenu_ItemClicked);

                menu.Show(HistoryData, new Point(e.X, e.Y));
            }
        }

        private void HistoryMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
