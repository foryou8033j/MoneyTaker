namespace MoneyTaker
{
    partial class MyInforForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserMail = new System.Windows.Forms.Label();
            this.lbUserTag = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnNameChange = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReset = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLogout = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbName.Location = new System.Drawing.Point(44, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(151, 32);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "이           름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(44, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "태           그";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(44, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "이    메    일";
            // 
            // lbUserMail
            // 
            this.lbUserMail.AutoSize = true;
            this.lbUserMail.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbUserMail.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUserMail.Location = new System.Drawing.Point(221, 182);
            this.lbUserMail.Name = "lbUserMail";
            this.lbUserMail.Size = new System.Drawing.Size(140, 25);
            this.lbUserMail.TabIndex = 3;
            this.lbUserMail.Text = "이메일 넣는 곳";
            // 
            // lbUserTag
            // 
            this.lbUserTag.AutoSize = true;
            this.lbUserTag.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbUserTag.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUserTag.Location = new System.Drawing.Point(221, 104);
            this.lbUserTag.Name = "lbUserTag";
            this.lbUserTag.Size = new System.Drawing.Size(121, 25);
            this.lbUserTag.TabIndex = 4;
            this.lbUserTag.Text = "태그 넣는 곳";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUserName.Location = new System.Drawing.Point(221, 26);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(121, 25);
            this.lbUserName.TabIndex = 5;
            this.lbUserName.Text = "이름 넣는 곳";
            // 
            // btnNameChange
            // 
            this.btnNameChange.AutoSize = true;
            this.btnNameChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNameChange.Depth = 0;
            this.btnNameChange.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNameChange.Location = new System.Drawing.Point(486, 19);
            this.btnNameChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNameChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Primary = false;
            this.btnNameChange.Size = new System.Drawing.Size(93, 36);
            this.btnNameChange.TabIndex = 6;
            this.btnNameChange.Text = "이  름  변  경";
            this.btnNameChange.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReset.Depth = 0;
            this.btnReset.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(486, 93);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = false;
            this.btnReset.Size = new System.Drawing.Size(85, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "초    기    화";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.Depth = 0;
            this.btnLogout.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogout.Location = new System.Drawing.Point(486, 171);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Primary = false;
            this.btnLogout.Size = new System.Drawing.Size(93, 36);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "로  그  아  웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MyInforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(686, 228);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNameChange);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbUserTag);
            this.Controls.Add(this.lbUserMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyInforForm";
            this.Text = "MyInforForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserMail;
        private System.Windows.Forms.Label lbUserTag;
        private System.Windows.Forms.Label lbUserName;
        private MaterialSkin.Controls.MaterialFlatButton btnNameChange;
        private MaterialSkin.Controls.MaterialFlatButton btnReset;
        private MaterialSkin.Controls.MaterialFlatButton btnLogout;
    }
}