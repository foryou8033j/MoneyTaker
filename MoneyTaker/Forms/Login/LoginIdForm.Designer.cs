namespace MoneyTaker
{
    partial class LoginIdForm
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
            this.tbEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnJoin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFindEmail = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Depth = 0;
            this.tbEmail.Hint = "E-Mail";
            this.tbEmail.Location = new System.Drawing.Point(182, 122);
            this.tbEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.Size = new System.Drawing.Size(242, 23);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.UseSystemPasswordChar = false;
            // 
            // btnJoin
            // 
            this.btnJoin.AutoSize = true;
            this.btnJoin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnJoin.Depth = 0;
            this.btnJoin.Location = new System.Drawing.Point(449, 114);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnJoin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Primary = false;
            this.btnJoin.Size = new System.Drawing.Size(72, 36);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "회원가입";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnFindEmail
            // 
            this.btnFindEmail.AutoSize = true;
            this.btnFindEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindEmail.Depth = 0;
            this.btnFindEmail.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFindEmail.Location = new System.Drawing.Point(251, 232);
            this.btnFindEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFindEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFindEmail.Name = "btnFindEmail";
            this.btnFindEmail.Primary = false;
            this.btnFindEmail.Size = new System.Drawing.Size(185, 36);
            this.btnFindEmail.TabIndex = 2;
            this.btnFindEmail.Text = "이메일을 잊어버렸습니다!";
            this.btnFindEmail.UseVisualStyleBackColor = true;
            // 
            // LoginIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.btnFindEmail);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.tbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginIdForm";
            this.Text = "LoginIdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbEmail;
        private MaterialSkin.Controls.MaterialFlatButton btnJoin;
        private MaterialSkin.Controls.MaterialFlatButton btnFindEmail;
    }
}