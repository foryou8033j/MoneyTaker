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
            this.tbPlus = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPlus = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbOnOff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbPlus
            // 
            this.tbPlus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPlus.Depth = 0;
            this.tbPlus.Hint = "이름";
            this.tbPlus.Location = new System.Drawing.Point(251, 132);
            this.tbPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPlus.Name = "tbPlus";
            this.tbPlus.PasswordChar = '\0';
            this.tbPlus.SelectedText = "";
            this.tbPlus.SelectionLength = 0;
            this.tbPlus.SelectionStart = 0;
            this.tbPlus.Size = new System.Drawing.Size(242, 23);
            this.tbPlus.TabIndex = 0;
            this.tbPlus.UseSystemPasswordChar = false;
            // 
            // btnPlus
            // 
            this.btnPlus.Depth = 0;
            this.btnPlus.Location = new System.Drawing.Point(251, 203);
            this.btnPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Primary = true;
            this.btnPlus.Size = new System.Drawing.Size(104, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "확  인";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
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
            // cbOnOff
            // 
            this.cbOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbOnOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOnOff.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbOnOff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbOnOff.FormattingEnabled = true;
            this.cbOnOff.Location = new System.Drawing.Point(138, 132);
            this.cbOnOff.MaxDropDownItems = 2;
            this.cbOnOff.Name = "cbOnOff";
            this.cbOnOff.Size = new System.Drawing.Size(93, 20);
            this.cbOnOff.TabIndex = 4;
            this.cbOnOff.SelectedIndexChanged += new System.EventHandler(this.cbOnOff_SelectedIndexChanged);
            // 
            // PlusFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.cbOnOff);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tbPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlusFriendForm";
            this.Text = "PlusFriendForm";
            this.Load += new System.EventHandler(this.PlusFriendForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbPlus;
        private MaterialSkin.Controls.MaterialRaisedButton btnPlus;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private System.Windows.Forms.ComboBox cbOnOff;
    }
}