namespace MoneyTaker
{
    partial class BuscarForm
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
            this.BuscarData = new System.Windows.Forms.DataGridView();
            this.BuscarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarDday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarData)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarData
            // 
            this.BuscarData.AllowUserToResizeColumns = false;
            this.BuscarData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.BuscarData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BuscarData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BuscarData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BuscarData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BuscarData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BuscarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscarData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuscarName,
            this.BuscarMoney,
            this.BuscarDate,
            this.BuscarDday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BuscarData.DefaultCellStyle = dataGridViewCellStyle3;
            this.BuscarData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscarData.EnableHeadersVisualStyles = false;
            this.BuscarData.Location = new System.Drawing.Point(0, 0);
            this.BuscarData.Name = "BuscarData";
            this.BuscarData.RowTemplate.Height = 23;
            this.BuscarData.Size = new System.Drawing.Size(703, 237);
            this.BuscarData.TabIndex = 0;
            // 
            // BuscarName
            // 
            this.BuscarName.HeaderText = "빌린 사람";
            this.BuscarName.Name = "BuscarName";
            this.BuscarName.Width = 120;
            // 
            // BuscarMoney
            // 
            this.BuscarMoney.HeaderText = "금액";
            this.BuscarMoney.Name = "BuscarMoney";
            this.BuscarMoney.Width = 120;
            // 
            // BuscarDate
            // 
            this.BuscarDate.HeaderText = "빌린 날짜";
            this.BuscarDate.Name = "BuscarDate";
            this.BuscarDate.Width = 210;
            // 
            // BuscarDday
            // 
            this.BuscarDday.HeaderText = "기한";
            this.BuscarDday.Name = "BuscarDday";
            this.BuscarDday.Width = 210;
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(703, 237);
            this.Controls.Add(this.BuscarData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarForm";
            this.Text = "BuscarForm";
            ((System.ComponentModel.ISupportInitialize)(this.BuscarData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BuscarData;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarDday;
    }
}