namespace MoneyTaker
{
    partial class AddTradeForm
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
            this.tabTradeSelecter = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControlTrade = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageBorrow = new System.Windows.Forms.TabPage();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelTrade = new System.Windows.Forms.Panel();
            this.tabControlTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTradeSelecter
            // 
            this.tabTradeSelecter.BaseTabControl = this.tabControlTrade;
            this.tabTradeSelecter.Depth = 0;
            this.tabTradeSelecter.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabTradeSelecter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabTradeSelecter.Location = new System.Drawing.Point(1, 0);
            this.tabTradeSelecter.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabTradeSelecter.Name = "tabTradeSelecter";
            this.tabTradeSelecter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabTradeSelecter.Size = new System.Drawing.Size(580, 23);
            this.tabTradeSelecter.TabIndex = 0;
            // 
            // tabControlTrade
            // 
            this.tabControlTrade.Controls.Add(this.tabPageBorrow);
            this.tabControlTrade.Controls.Add(this.tabPageBuscar);
            this.tabControlTrade.Depth = 0;
            this.tabControlTrade.Location = new System.Drawing.Point(1, 26);
            this.tabControlTrade.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlTrade.Name = "tabControlTrade";
            this.tabControlTrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlTrade.SelectedIndex = 0;
            this.tabControlTrade.Size = new System.Drawing.Size(698, 22);
            this.tabControlTrade.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlTrade.TabIndex = 1;
            // 
            // tabPageBorrow
            // 
            this.tabPageBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPageBorrow.Location = new System.Drawing.Point(4, 22);
            this.tabPageBorrow.Name = "tabPageBorrow";
            this.tabPageBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBorrow.Size = new System.Drawing.Size(690, 0);
            this.tabPageBorrow.TabIndex = 0;
            this.tabPageBorrow.Text = "빌리기";
            // 
            // tabPageBuscar
            // 
            this.tabPageBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscar.Size = new System.Drawing.Size(690, 254);
            this.tabPageBuscar.TabIndex = 1;
            this.tabPageBuscar.Text = "빌려주기";
            // 
            // btnCancle
            // 
            this.btnCancle.Depth = 0;
            this.btnCancle.Location = new System.Drawing.Point(587, 0);
            this.btnCancle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Primary = true;
            this.btnCancle.Size = new System.Drawing.Size(112, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // panelTrade
            // 
            this.panelTrade.Location = new System.Drawing.Point(1, 26);
            this.panelTrade.Name = "panelTrade";
            this.panelTrade.Size = new System.Drawing.Size(698, 285);
            this.panelTrade.TabIndex = 3;
            // 
            // AddTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.panelTrade);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.tabControlTrade);
            this.Controls.Add(this.tabTradeSelecter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTradeForm";
            this.Text = "AddTradeForm";
            this.Load += new System.EventHandler(this.AddTradeForm_Load);
            this.tabControlTrade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tabTradeSelecter;
        private System.Windows.Forms.TabPage tabPageBorrow;
        private System.Windows.Forms.TabPage tabPageBuscar;
        private MaterialSkin.Controls.MaterialTabControl tabControlTrade;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private System.Windows.Forms.Panel panelTrade;
    }
}