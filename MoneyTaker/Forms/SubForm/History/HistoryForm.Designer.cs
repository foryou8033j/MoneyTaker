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
            this.HistoryData = new System.Windows.Forms.DataGridView();
            this.HistoryBuscar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryMemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryData
            // 
            this.HistoryData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HistoryData_MouseUp);
            this.HistoryData.AllowUserToResizeColumns = false;
            this.HistoryData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.HistoryData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HistoryData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.HistoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HistoryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HistoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HistoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryBuscar,
            this.HistoryBorrow,
            this.HistoryMoney,
            this.HistoryDate,
            this.HistoryEnd,
            this.HistoryMemo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HistoryData.DefaultCellStyle = dataGridViewCellStyle3;
            this.HistoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryData.EnableHeadersVisualStyles = false;
            this.HistoryData.Location = new System.Drawing.Point(0, 0);
            this.HistoryData.Name = "HistoryData";
            this.HistoryData.ReadOnly = true;
            this.HistoryData.RowTemplate.Height = 23;
            this.HistoryData.Size = new System.Drawing.Size(703, 237);
            this.HistoryData.TabIndex = 0;
            // 
            // HistoryBuscar
            // 
            this.HistoryBuscar.HeaderText = "빌린 사람";
            this.HistoryBuscar.Name = "HistoryBuscar";
            this.HistoryBuscar.ReadOnly = true;
            this.HistoryBuscar.Width = 90;
            // 
            // HistoryBorrow
            // 
            this.HistoryBorrow.HeaderText = "빌려준 사람";
            this.HistoryBorrow.Name = "HistoryBorrow";
            this.HistoryBorrow.ReadOnly = true;
            // 
            // HistoryMoney
            // 
            this.HistoryMoney.HeaderText = "금액";
            this.HistoryMoney.Name = "HistoryMoney";
            this.HistoryMoney.ReadOnly = true;
            this.HistoryMoney.Width = 70;
            // 
            // HistoryDate
            // 
            this.HistoryDate.HeaderText = "빌린/빌려준 날짜";
            this.HistoryDate.Name = "HistoryDate";
            this.HistoryDate.ReadOnly = true;
            this.HistoryDate.Width = 157;
            // 
            // HistoryEnd
            // 
            this.HistoryEnd.HeaderText = "갚은 날짜";
            this.HistoryEnd.Name = "HistoryEnd";
            this.HistoryEnd.ReadOnly = true;
            this.HistoryEnd.Width = 125;
            // 
            // HistoryMemo
            // 
            this.HistoryMemo.HeaderText = "메모";
            this.HistoryMemo.Name = "HistoryMemo";
            this.HistoryMemo.ReadOnly = true;
            this.HistoryMemo.Width = 120;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(703, 237);
            this.Controls.Add(this.HistoryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HistoryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryMemo;
    }
}