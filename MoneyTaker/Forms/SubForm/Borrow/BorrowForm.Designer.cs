namespace MoneyTaker
{
    partial class BorrowForm
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
            this.BorrowData = new System.Windows.Forms.DataGridView();
            this.BorrowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowData)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowData
            // 
            this.BorrowData.AllowUserToResizeColumns = false;
            this.BorrowData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.BorrowData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BorrowData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BorrowData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BorrowData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BorrowData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BorrowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BorrowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowName,
            this.BorrowMoney,
            this.BorrowDate,
            this.BorrowDday,
            this.BorrowMemo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BorrowData.DefaultCellStyle = dataGridViewCellStyle3;
            this.BorrowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowData.EnableHeadersVisualStyles = false;
            this.BorrowData.Location = new System.Drawing.Point(0, 0);
            this.BorrowData.Name = "BorrowData";
            this.BorrowData.ReadOnly = true;
            this.BorrowData.RowTemplate.Height = 23;
            this.BorrowData.Size = new System.Drawing.Size(703, 237);
            this.BorrowData.TabIndex = 0;
            // 
            // BorrowName
            // 
            this.BorrowName.HeaderText = "빌려준 사람";
            this.BorrowName.Name = "BorrowName";
            this.BorrowName.ReadOnly = true;
            // 
            // BorrowMoney
            // 
            this.BorrowMoney.HeaderText = "금액";
            this.BorrowMoney.Name = "BorrowMoney";
            this.BorrowMoney.ReadOnly = true;
            this.BorrowMoney.Width = 120;
            // 
            // BorrowDate
            // 
            this.BorrowDate.HeaderText = "빌려준 날짜";
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.ReadOnly = true;
            this.BorrowDate.Width = 150;
            // 
            // BorrowDday
            // 
            this.BorrowDday.HeaderText = "기한";
            this.BorrowDday.Name = "BorrowDday";
            this.BorrowDday.ReadOnly = true;
            this.BorrowDday.Width = 150;
            // 
            // BorrowMemo
            // 
            this.BorrowMemo.HeaderText = "메모";
            this.BorrowMemo.Name = "BorrowMemo";
            this.BorrowMemo.ReadOnly = true;
            this.BorrowMemo.Width = 142;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(703, 237);
            this.Controls.Add(this.BorrowData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            ((System.ComponentModel.ISupportInitialize)(this.BorrowData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BorrowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowDday;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowMemo;
    }
}