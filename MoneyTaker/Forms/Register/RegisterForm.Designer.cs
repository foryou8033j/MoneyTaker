namespace MoneyTaker
{
    partial class RegisterForm
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
            this.lbnEmail = new MaterialSkin.Controls.MaterialLabel();
            this.lbnPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPasswordReType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbnPasswordRetype = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmEmail = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbnEmailNotification = new MaterialSkin.Controls.MaterialLabel();
            this.lbnPasswordSecurity = new MaterialSkin.Controls.MaterialLabel();
            this.lbnPasswordNotification = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbnEmail
            // 
            this.lbnEmail.AutoSize = true;
            this.lbnEmail.CausesValidation = false;
            this.lbnEmail.Depth = 0;
            this.lbnEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnEmail.Location = new System.Drawing.Point(148, 108);
            this.lbnEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnEmail.Name = "lbnEmail";
            this.lbnEmail.Size = new System.Drawing.Size(51, 19);
            this.lbnEmail.TabIndex = 0;
            this.lbnEmail.Text = "E-mail";
            // 
            // lbnPassword
            // 
            this.lbnPassword.AutoSize = true;
            this.lbnPassword.CausesValidation = false;
            this.lbnPassword.Depth = 0;
            this.lbnPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnPassword.Location = new System.Drawing.Point(124, 151);
            this.lbnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnPassword.Name = "lbnPassword";
            this.lbnPassword.Size = new System.Drawing.Size(75, 19);
            this.lbnPassword.TabIndex = 0;
            this.lbnPassword.Text = "Password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 9);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(224, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "로그인시에 사용 할 정보를 입력 해 주세요.";
            // 
            // tbEmail
            // 
            this.tbEmail.Depth = 0;
            this.tbEmail.Hint = "E-Mail";
            this.tbEmail.Location = new System.Drawing.Point(224, 104);
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(200, 23);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.UseSystemPasswordChar = false;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Depth = 0;
            this.tbPassword.Enabled = false;
            this.tbPassword.Hint = "Password";
            this.tbPassword.Location = new System.Drawing.Point(224, 147);
            this.tbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(243, 23);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbPasswordReType
            // 
            this.tbPasswordReType.Depth = 0;
            this.tbPasswordReType.Enabled = false;
            this.tbPasswordReType.Hint = "Password";
            this.tbPasswordReType.Location = new System.Drawing.Point(224, 189);
            this.tbPasswordReType.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPasswordReType.Name = "tbPasswordReType";
            this.tbPasswordReType.PasswordChar = '*';
            this.tbPasswordReType.SelectedText = "";
            this.tbPasswordReType.SelectionLength = 0;
            this.tbPasswordReType.SelectionStart = 0;
            this.tbPasswordReType.Size = new System.Drawing.Size(243, 23);
            this.tbPasswordReType.TabIndex = 3;
            this.tbPasswordReType.UseSystemPasswordChar = false;
            this.tbPasswordReType.TextChanged += new System.EventHandler(this.tbPasswordReType_TextChanged);
            // 
            // lbnPasswordRetype
            // 
            this.lbnPasswordRetype.AutoSize = true;
            this.lbnPasswordRetype.CausesValidation = false;
            this.lbnPasswordRetype.Depth = 0;
            this.lbnPasswordRetype.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnPasswordRetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnPasswordRetype.Location = new System.Drawing.Point(78, 193);
            this.lbnPasswordRetype.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnPasswordRetype.Name = "lbnPasswordRetype";
            this.lbnPasswordRetype.Size = new System.Drawing.Size(121, 19);
            this.lbnPasswordRetype.TabIndex = 4;
            this.lbnPasswordRetype.Text = "Check Password";
            // 
            // btnRegister
            // 
            this.btnRegister.CausesValidation = false;
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(506, 102);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(126, 66);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "가입하기";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.CausesValidation = false;
            this.btnCancle.Depth = 0;
            this.btnCancle.Location = new System.Drawing.Point(506, 174);
            this.btnCancle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Primary = true;
            this.btnCancle.Size = new System.Drawing.Size(126, 40);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "돌아가기";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.AutoSize = true;
            this.btnConfirmEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmEmail.CausesValidation = false;
            this.btnConfirmEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmEmail.Depth = 0;
            this.btnConfirmEmail.Location = new System.Drawing.Point(425, 95);
            this.btnConfirmEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Primary = false;
            this.btnConfirmEmail.Size = new System.Drawing.Size(42, 36);
            this.btnConfirmEmail.TabIndex = 7;
            this.btnConfirmEmail.Text = "인증";
            this.btnConfirmEmail.UseVisualStyleBackColor = true;
            this.btnConfirmEmail.Click += new System.EventHandler(this.btnConfirmEmail_Click);
            // 
            // lbnEmailNotification
            // 
            this.lbnEmailNotification.AutoSize = true;
            this.lbnEmailNotification.Depth = 0;
            this.lbnEmailNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbnEmailNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnEmailNotification.Location = new System.Drawing.Point(219, 128);
            this.lbnEmailNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnEmailNotification.Name = "lbnEmailNotification";
            this.lbnEmailNotification.Size = new System.Drawing.Size(0, 13);
            this.lbnEmailNotification.TabIndex = 8;
            // 
            // lbnPasswordSecurity
            // 
            this.lbnPasswordSecurity.AutoSize = true;
            this.lbnPasswordSecurity.Depth = 0;
            this.lbnPasswordSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbnPasswordSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnPasswordSecurity.Location = new System.Drawing.Point(467, 150);
            this.lbnPasswordSecurity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnPasswordSecurity.Name = "lbnPasswordSecurity";
            this.lbnPasswordSecurity.Size = new System.Drawing.Size(0, 20);
            this.lbnPasswordSecurity.TabIndex = 9;
            // 
            // lbnPasswordNotification
            // 
            this.lbnPasswordNotification.AutoSize = true;
            this.lbnPasswordNotification.Depth = 0;
            this.lbnPasswordNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbnPasswordNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnPasswordNotification.Location = new System.Drawing.Point(220, 170);
            this.lbnPasswordNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnPasswordNotification.Name = "lbnPasswordNotification";
            this.lbnPasswordNotification.Size = new System.Drawing.Size(0, 13);
            this.lbnPasswordNotification.TabIndex = 10;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.lbnPasswordNotification);
            this.Controls.Add(this.lbnPasswordSecurity);
            this.Controls.Add(this.lbnEmailNotification);
            this.Controls.Add(this.btnConfirmEmail);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbnPasswordRetype);
            this.Controls.Add(this.tbPasswordReType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbnPassword);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lbnEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbnEmail;
        private MaterialSkin.Controls.MaterialLabel lbnPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPasswordReType;
        private MaterialSkin.Controls.MaterialLabel lbnPasswordRetype;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private MaterialSkin.Controls.MaterialFlatButton btnConfirmEmail;
        private MaterialSkin.Controls.MaterialLabel lbnEmailNotification;
        private MaterialSkin.Controls.MaterialLabel lbnPasswordSecurity;
        private MaterialSkin.Controls.MaterialLabel lbnPasswordNotification;
    }
}