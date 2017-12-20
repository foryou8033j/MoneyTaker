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
            this.lbnContents = new System.Windows.Forms.Label();
            this.btnOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbnContents
            // 
            this.lbnContents.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbnContents.Location = new System.Drawing.Point(12, 74);
            this.lbnContents.Name = "lbnContents";
            this.lbnContents.Size = new System.Drawing.Size(261, 61);
            this.lbnContents.TabIndex = 0;
            this.lbnContents.Text = "label1";
            this.lbnContents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Depth = 0;
            this.btnOK.Location = new System.Drawing.Point(69, 141);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = false;
            this.btnOK.Size = new System.Drawing.Size(138, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 183);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbnContents);
            this.Name = "Alert";
            this.Text = "Alert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnContents;
        private MaterialSkin.Controls.MaterialFlatButton btnOK;
    }
}