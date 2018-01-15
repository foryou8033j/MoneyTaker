namespace MoneyTaker
{ 
    partial class TabSettingForm
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
            this.components = new System.ComponentModel.Container();
            this.tbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbTag = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFunction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnLogout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNameChange = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tmFunction = new System.Windows.Forms.Timer(this.components);
            this.panelFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Depth = 0;
            this.tbName.Enabled = false;
            this.tbName.Hint = "이름";
            this.tbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbName.Location = new System.Drawing.Point(264, 57);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(244, 23);
            this.tbName.TabIndex = 1;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // tbTag
            // 
            this.tbTag.Depth = 0;
            this.tbTag.Enabled = false;
            this.tbTag.Hint = "태그";
            this.tbTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbTag.Location = new System.Drawing.Point(264, 120);
            this.tbTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTag.Name = "tbTag";
            this.tbTag.PasswordChar = '\0';
            this.tbTag.SelectedText = "";
            this.tbTag.SelectionLength = 0;
            this.tbTag.SelectionStart = 0;
            this.tbTag.Size = new System.Drawing.Size(244, 23);
            this.tbTag.TabIndex = 2;
            this.tbTag.UseSystemPasswordChar = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Depth = 0;
            this.tbEmail.Enabled = false;
            this.tbEmail.Hint = "이메일";
            this.tbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbEmail.Location = new System.Drawing.Point(264, 189);
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(244, 23);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.UseSystemPasswordChar = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(186, 58);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 19);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "이      름";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(186, 121);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "태      그";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(186, 190);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "이  메  일";
            // 
            // btnFunction
            // 
            this.btnFunction.Depth = 0;
            this.btnFunction.Location = new System.Drawing.Point(70, 226);
            this.btnFunction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Primary = true;
            this.btnFunction.Size = new System.Drawing.Size(75, 23);
            this.btnFunction.TabIndex = 7;
            this.btnFunction.Text = "▶";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.btnLogout);
            this.panelFunction.Controls.Add(this.btnReset);
            this.panelFunction.Controls.Add(this.btnNameChange);
            this.panelFunction.Location = new System.Drawing.Point(138, 226);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(10, 23);
            this.panelFunction.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Depth = 0;
            this.btnLogout.Location = new System.Drawing.Point(314, 0);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Primary = true;
            this.btnLogout.Size = new System.Drawing.Size(112, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "로  그  아  웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(162, 0);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(112, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "초   기   화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnNameChange
            // 
            this.btnNameChange.Depth = 0;
            this.btnNameChange.Location = new System.Drawing.Point(9, 0);
            this.btnNameChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Primary = true;
            this.btnNameChange.Size = new System.Drawing.Size(112, 23);
            this.btnNameChange.TabIndex = 0;
            this.btnNameChange.Text = "이  름  변  경";
            this.btnNameChange.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Depth = 0;
            this.btnClose.Location = new System.Drawing.Point(300, 265);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Primary = true;
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫      기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_ClickAsync);
            // 
            // tmFunction
            // 
            this.tmFunction.Interval = 1;
            this.tmFunction.Tick += new System.EventHandler(this.tmFunction_Tick);
            // 
            // TabSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelFunction);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabSettingForm";
            this.Text = "TabSettingForm";
            this.Load += new System.EventHandler(this.TabSettingForm_LoadAsync);
            this.panelFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion
    private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
    private MaterialSkin.Controls.MaterialSingleLineTextField tbTag;
    private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
    private MaterialSkin.Controls.MaterialLabel lbName;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialRaisedButton btnFunction;
    private System.Windows.Forms.Panel panelFunction;
    private MaterialSkin.Controls.MaterialRaisedButton btnClose;
    private MaterialSkin.Controls.MaterialRaisedButton btnLogout;
    private MaterialSkin.Controls.MaterialRaisedButton btnReset;
    private MaterialSkin.Controls.MaterialRaisedButton btnNameChange;
    private System.Windows.Forms.Timer tmFunction;
    }
}