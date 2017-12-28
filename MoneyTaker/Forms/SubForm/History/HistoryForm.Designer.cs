namespace MoneyTaker
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnBuscarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBorrowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBuscarName,
            this.ColumnBorrowName,
            this.ColumnMoney,
            this.ColumnDate,
            this.ColumnDay,
            this.ColumnDday});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(662, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnBuscarName
            // 
            this.ColumnBuscarName.HeaderText = "빌린 사람";
            this.ColumnBuscarName.Name = "ColumnBuscarName";
            this.ColumnBuscarName.ReadOnly = true;
            this.ColumnBuscarName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnBorrowName
            // 
            this.ColumnBorrowName.HeaderText = "빌려준 사람";
            this.ColumnBorrowName.Name = "ColumnBorrowName";
            this.ColumnBorrowName.ReadOnly = true;
            // 
            // ColumnMoney
            // 
            this.ColumnMoney.HeaderText = "금액";
            this.ColumnMoney.Name = "ColumnMoney";
            this.ColumnMoney.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "빌린/빌려준 날짜";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 135;
            // 
            // ColumnDay
            // 
            this.ColumnDay.HeaderText = "갚은 날짜";
            this.ColumnDay.Name = "ColumnDay";
            this.ColumnDay.ReadOnly = true;
            this.ColumnDay.Width = 140;
            // 
            // ColumnDday
            // 
            this.ColumnDday.HeaderText = "걸린 기한";
            this.ColumnDday.Name = "ColumnDday";
            this.ColumnDday.ReadOnly = true;
            this.ColumnDday.Width = 85;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(662, 237);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuscarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBorrowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDday;
    }
}