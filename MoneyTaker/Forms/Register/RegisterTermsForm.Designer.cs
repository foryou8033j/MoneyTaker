namespace MoneyTaker
{
    partial class RegisterTermsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterTermsForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgree = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDisAgree = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(656, 201);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(138, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "개인정보이용에 관한 동의";
            // 
            // btnAgree
            // 
            this.btnAgree.Depth = 0;
            this.btnAgree.Location = new System.Drawing.Point(390, 249);
            this.btnAgree.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Primary = true;
            this.btnAgree.Size = new System.Drawing.Size(139, 37);
            this.btnAgree.TabIndex = 5;
            this.btnAgree.Text = "동의";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnDisAgree
            // 
            this.btnDisAgree.Depth = 0;
            this.btnDisAgree.Location = new System.Drawing.Point(535, 249);
            this.btnDisAgree.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisAgree.Name = "btnDisAgree";
            this.btnDisAgree.Primary = true;
            this.btnDisAgree.Size = new System.Drawing.Size(139, 37);
            this.btnDisAgree.TabIndex = 6;
            this.btnDisAgree.Text = "동의하지 않음";
            this.btnDisAgree.UseVisualStyleBackColor = true;
            this.btnDisAgree.Click += new System.EventHandler(this.btnDisAgree_Click);
            // 
            // Register_Agree_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.btnDisAgree);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Agree_Form";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgree;
        private MaterialSkin.Controls.MaterialRaisedButton btnDisAgree;
    }
}