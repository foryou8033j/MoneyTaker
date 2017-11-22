namespace MoneyTaker
{
    partial class RootForm
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
            this.panel_Root = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Root
            // 
            this.panel_Root.Location = new System.Drawing.Point(12, 12);
            this.panel_Root.Name = "panel_Root";
            this.panel_Root.Size = new System.Drawing.Size(702, 372);
            this.panel_Root.TabIndex = 0;
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 396);
            this.Controls.Add(this.panel_Root);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.Load += new System.EventHandler(this.RootForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Root;
    }
}