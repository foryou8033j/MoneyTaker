namespace MoneyTaker
{
    partial class Alert
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
            this.btnOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbnContents = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Depth = 0;
            this.btnOK.Location = new System.Drawing.Point(73, 141);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = false;
            this.btnOK.Size = new System.Drawing.Size(146, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbnContents
            // 
            this.lbnContents.Depth = 0;
            this.lbnContents.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbnContents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnContents.Location = new System.Drawing.Point(13, 74);
            this.lbnContents.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnContents.Name = "lbnContents";
            this.lbnContents.Size = new System.Drawing.Size(260, 61);
            this.lbnContents.TabIndex = 2;
            this.lbnContents.Text = "materialLabel1";
            this.lbnContents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 183);
            this.Controls.Add(this.lbnContents);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alert";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnOK;
        private MaterialSkin.Controls.MaterialLabel lbnContents;
    }
}