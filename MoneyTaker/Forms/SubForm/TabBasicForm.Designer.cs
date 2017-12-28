namespace MoneyTaker
{
    partial class TabBasicForm
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
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.tabBorrow = new System.Windows.Forms.TabPage();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.tabTradeHistory = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnSetting = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelFriend = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.panelBorrow = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.tabBorrow.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            this.tabTradeHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabFriends);
            this.tabControl.Controls.Add(this.tabBorrow);
            this.tabControl.Controls.Add(this.tabBuscar);
            this.tabControl.Controls.Add(this.tabTradeHistory);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(12, 29);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(676, 269);
            this.tabControl.TabIndex = 0;
            // 
            // tabFriends
            // 
            this.tabFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabFriends.Controls.Add(this.panelFriend);
            this.tabFriends.Location = new System.Drawing.Point(4, 22);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriends.Size = new System.Drawing.Size(668, 243);
            this.tabFriends.TabIndex = 0;
            this.tabFriends.Text = "친구목록";
            // 
            // tabBorrow
            // 
            this.tabBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabBorrow.Controls.Add(this.panelBuscar);
            this.tabBorrow.Location = new System.Drawing.Point(4, 22);
            this.tabBorrow.Name = "tabBorrow";
            this.tabBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrow.Size = new System.Drawing.Size(668, 243);
            this.tabBorrow.TabIndex = 1;
            this.tabBorrow.Text = "빌린 돈";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabBuscar.Controls.Add(this.panelBorrow);
            this.tabBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(668, 243);
            this.tabBuscar.TabIndex = 2;
            this.tabBuscar.Text = "빌려준 돈";
            // 
            // tabTradeHistory
            // 
            this.tabTradeHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabTradeHistory.Controls.Add(this.panelHistory);
            this.tabTradeHistory.Location = new System.Drawing.Point(4, 22);
            this.tabTradeHistory.Name = "tabTradeHistory";
            this.tabTradeHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabTradeHistory.Size = new System.Drawing.Size(668, 243);
            this.tabTradeHistory.TabIndex = 3;
            this.tabTradeHistory.Text = "거래기록";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(583, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // btnSetting
            // 
            this.btnSetting.Depth = 0;
            this.btnSetting.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(588, 0);
            this.btnSetting.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Primary = true;
            this.btnSetting.Size = new System.Drawing.Size(112, 23);
            this.btnSetting.TabIndex = 0;
            this.btnSetting.Text = "설정";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // panelFriend
            // 
            this.panelFriend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFriend.Location = new System.Drawing.Point(3, 3);
            this.panelFriend.Name = "panelFriend";
            this.panelFriend.Size = new System.Drawing.Size(662, 237);
            this.panelFriend.TabIndex = 0;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuscar.Location = new System.Drawing.Point(3, 3);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(662, 237);
            this.panelBuscar.TabIndex = 0;
            // 
            // panelBorrow
            // 
            this.panelBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorrow.Location = new System.Drawing.Point(3, 3);
            this.panelBorrow.Name = "panelBorrow";
            this.panelBorrow.Size = new System.Drawing.Size(662, 237);
            this.panelBorrow.TabIndex = 0;
            // 
            // panelHistory
            // 
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistory.Location = new System.Drawing.Point(3, 3);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(662, 237);
            this.panelHistory.TabIndex = 0;
            // 
            // TabBasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabBasicForm";
            this.Text = "TabBasicForm";
            this.Load += new System.EventHandler(this.TabBasicForm_LoadAsync);
            this.tabControl.ResumeLayout(false);
            this.tabFriends.ResumeLayout(false);
            this.tabBorrow.ResumeLayout(false);
            this.tabBuscar.ResumeLayout(false);
            this.tabTradeHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.TabPage tabBorrow;
        private System.Windows.Forms.TabPage tabBuscar;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabTradeHistory;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetting;
        private System.Windows.Forms.Panel panelFriend;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Panel panelBorrow;
        private System.Windows.Forms.Panel panelHistory;
    }
}