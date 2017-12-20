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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbPasswordReType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmEmail = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(167, 108);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "E-mail";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(154, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Password";
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
            this.tbEmail.Location = new System.Drawing.Point(254, 104);
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(164, 23);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.UseSystemPasswordChar = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Depth = 0;
            this.tbPassword.Hint = "Password";
            this.tbPassword.Location = new System.Drawing.Point(254, 147);
            this.tbPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.Size = new System.Drawing.Size(200, 23);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = false;
            // 
            // tbPasswordReType
            // 
            this.tbPasswordReType.Depth = 0;
            this.tbPasswordReType.Hint = "Password";
            this.tbPasswordReType.Location = new System.Drawing.Point(254, 189);
            this.tbPasswordReType.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPasswordReType.Name = "tbPasswordReType";
            this.tbPasswordReType.PasswordChar = '*';
            this.tbPasswordReType.SelectedText = "";
            this.tbPasswordReType.SelectionLength = 0;
            this.tbPasswordReType.SelectionStart = 0;
            this.tbPasswordReType.Size = new System.Drawing.Size(200, 23);
            this.tbPasswordReType.TabIndex = 3;
            this.tbPasswordReType.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(162, 192);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "ReType";
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(506, 102);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(126, 66);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "가입하기";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
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
            this.btnConfirmEmail.Depth = 0;
            this.btnConfirmEmail.Location = new System.Drawing.Point(425, 91);
            this.btnConfirmEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Primary = false;
            this.btnConfirmEmail.Size = new System.Drawing.Size(42, 36);
            this.btnConfirmEmail.TabIndex = 7;
            this.btnConfirmEmail.Text = "인증";
            this.btnConfirmEmail.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.btnConfirmEmail);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.tbPasswordReType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbPasswordReType;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancle;
        private MaterialSkin.Controls.MaterialFlatButton btnConfirmEmail;
    }
}