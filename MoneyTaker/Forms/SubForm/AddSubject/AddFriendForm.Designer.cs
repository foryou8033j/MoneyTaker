﻿namespace MoneyTaker
{
    partial class AddFriendForm
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
            this.tbGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbGroup = new MaterialSkin.Controls.MaterialLabel();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Depth = 0;
            this.tbName.Hint = "이름/태그/이메일";
            this.tbName.Location = new System.Drawing.Point(251, 137);
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
            // tbGroup
            // 
            this.tbGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGroup.Depth = 0;
            this.tbGroup.Hint = "그룹";
            this.tbGroup.Location = new System.Drawing.Point(251, 82);
            this.tbGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.PasswordChar = '\0';
            this.tbGroup.SelectedText = "";
            this.tbGroup.SelectionLength = 0;
            this.tbGroup.SelectionStart = 0;
            this.tbGroup.Size = new System.Drawing.Size(242, 23);
            this.tbGroup.TabIndex = 4;
            this.tbGroup.UseSystemPasswordChar = false;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Depth = 0;
            this.lbGroup.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbGroup.Location = new System.Drawing.Point(194, 82);
            this.lbGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(39, 19);
            this.lbGroup.TabIndex = 5;
            this.lbGroup.Text = "그룹";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(107, 137);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(126, 19);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "이름/태그/이메일";
            // 
            // AddFriendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 310);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFriendForm";
            this.Text = "PlusFriendForm";
            this.Load += new System.EventHandler(this.PlusFriendForm_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbGroup;
        private MaterialSkin.Controls.MaterialLabel lbGroup;
        private MaterialSkin.Controls.MaterialLabel lbName;
    }
}