namespace MoneyTaker
{
    partial class LoginPasswordForm
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
            this.tbPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnOtherUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFindPassword = new MaterialSkin.Controls.MaterialFlatButton();
            this.chbAutoLogin = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Depth = 0;
            this.tbPassword.Hint = "Password";
            this.tbPassword.Location = new System.Drawing.Point(229, 132);
            this.tbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(242, 23);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnOtherUser
            // 
            this.btnOtherUser.AutoSize = true;
            this.btnOtherUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOtherUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherUser.Depth = 0;
            this.btnOtherUser.Location = new System.Drawing.Point(478, 122);
            this.btnOtherUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOtherUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOtherUser.Name = "btnOtherUser";
            this.btnOtherUser.Primary = false;
            this.btnOtherUser.Size = new System.Drawing.Size(91, 36);
            this.btnOtherUser.TabIndex = 1;
            this.btnOtherUser.TabStop = false;
            this.btnOtherUser.Text = "다른 사용자";
            this.btnOtherUser.UseVisualStyleBackColor = true;
            this.btnOtherUser.Click += new System.EventHandler(this.btnOtherUser_Click);
            // 
            // btnFindPassword
            // 
            this.btnFindPassword.AutoSize = true;
            this.btnFindPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindPassword.Depth = 0;
            this.btnFindPassword.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindPassword.Location = new System.Drawing.Point(258, 259);
            this.btnFindPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindPassword.Name = "btnFindPassword";
            this.btnFindPassword.Primary = false;
            this.btnFindPassword.Size = new System.Drawing.Size(200, 36);
            this.btnFindPassword.TabIndex = 2;
            this.btnFindPassword.TabStop = false;
            this.btnFindPassword.Text = "비밀번호를 잊어버렸습니다!";
            this.btnFindPassword.UseVisualStyleBackColor = true;
            // 
            // chbAutoLogin
            // 
            this.chbAutoLogin.AutoSize = true;
            this.chbAutoLogin.Depth = 0;
            this.chbAutoLogin.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbAutoLogin.Location = new System.Drawing.Point(308, 195);
            this.chbAutoLogin.Margin = new System.Windows.Forms.Padding(0);
            this.chbAutoLogin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbAutoLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbAutoLogin.Name = "chbAutoLogin";
            this.chbAutoLogin.Ripple = true;
            this.chbAutoLogin.Size = new System.Drawing.Size(105, 30);
            this.chbAutoLogin.TabIndex = 3;
            this.chbAutoLogin.TabStop = false;
            this.chbAutoLogin.Text = "자동로그인";
            this.chbAutoLogin.UseVisualStyleBackColor = true;
            this.chbAutoLogin.CheckedChanged += new System.EventHandler(this.chbAutoLogin_CheckedChanged);
            // 
            // LoginPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.chbAutoLogin);
            this.Controls.Add(this.btnFindPassword);
            this.Controls.Add(this.btnOtherUser);
            this.Controls.Add(this.tbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPasswordForm";
            this.Text = "LoginIdForm";
            this.Load += new System.EventHandler(this.LoginPasswordForm_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassword;
        private MaterialSkin.Controls.MaterialFlatButton btnOtherUser;
        private MaterialSkin.Controls.MaterialFlatButton btnFindPassword;
        private MaterialSkin.Controls.MaterialCheckBox chbAutoLogin;
    }
}