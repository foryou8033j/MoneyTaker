namespace MoneyTaker
{
    partial class PlusFriendForm
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
            this.tbName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Depth = 0;
            this.tbName.Hint = "이름";
            this.tbName.Location = new System.Drawing.Point(251, 132);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(242, 23);
            this.tbName.TabIndex = 0;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // btnOk
            // 
            this.btnOk.Depth = 0;
            this.btnOk.Location = new System.Drawing.Point(251, 203);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(104, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "확  인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.Location = new System.Drawing.Point(389, 203);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(104, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취  소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMode
            // 
            this.cbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Location = new System.Drawing.Point(138, 132);
            this.cbMode.MaxDropDownItems = 2;
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(93, 20);
            this.cbMode.TabIndex = 4;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // PlusFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlusFriendForm";
            this.Text = "PlusFriendForm";
            this.Load += new System.EventHandler(this.PlusFriendForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.ComboBox cbMode;
    }
}