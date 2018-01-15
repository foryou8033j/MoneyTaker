namespace MoneyTaker
{
    partial class AddTradeFirstForm
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
            this.btnSelectFriend = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbnName = new MaterialSkin.Controls.MaterialLabel();
            this.lbnFriendList = new MaterialSkin.Controls.MaterialLabel();
            this.lbnPrice = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chbDutchPay = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbnDutchPayHint = new MaterialSkin.Controls.MaterialLabel();
            this.btnNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Depth = 0;
            this.tbName.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbName.Hint = "이름 입력";
            this.tbName.Location = new System.Drawing.Point(195, 56);
            this.tbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.Size = new System.Drawing.Size(286, 23);
            this.tbName.TabIndex = 1;
            this.tbName.UseSystemPasswordChar = false;
            // 
            // btnSelectFriend
            // 
            this.btnSelectFriend.AutoSize = true;
            this.btnSelectFriend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFriend.Depth = 0;
            this.btnSelectFriend.Location = new System.Drawing.Point(502, 39);
            this.btnSelectFriend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelectFriend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelectFriend.Name = "btnSelectFriend";
            this.btnSelectFriend.Primary = false;
            this.btnSelectFriend.Size = new System.Drawing.Size(76, 36);
            this.btnSelectFriend.TabIndex = 2;
            this.btnSelectFriend.Text = "친구 선택";
            this.btnSelectFriend.UseVisualStyleBackColor = true;
            // 
            // lbnName
            // 
            this.lbnName.AutoSize = true;
            this.lbnName.Depth = 0;
            this.lbnName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnName.Location = new System.Drawing.Point(158, 56);
            this.lbnName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnName.Name = "lbnName";
            this.lbnName.Size = new System.Drawing.Size(31, 19);
            this.lbnName.TabIndex = 3;
            this.lbnName.Text = "이름";
            // 
            // lbnFriendList
            // 
            this.lbnFriendList.Depth = 0;
            this.lbnFriendList.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnFriendList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnFriendList.Location = new System.Drawing.Point(191, 78);
            this.lbnFriendList.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnFriendList.Name = "lbnFriendList";
            this.lbnFriendList.Size = new System.Drawing.Size(331, 23);
            this.lbnFriendList.TabIndex = 4;
            this.lbnFriendList.Text = "이름을 입력하고 Enter 를 입력하면 여러명을 등록할 수 있어요";
            // 
            // lbnPrice
            // 
            this.lbnPrice.AutoSize = true;
            this.lbnPrice.Depth = 0;
            this.lbnPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnPrice.Location = new System.Drawing.Point(158, 125);
            this.lbnPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnPrice.Name = "lbnPrice";
            this.lbnPrice.Size = new System.Drawing.Size(31, 19);
            this.lbnPrice.TabIndex = 5;
            this.lbnPrice.Text = "금액";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("배달의민족 주아", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.materialSingleLineTextField1.Hint = "금액 입력";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(195, 125);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(286, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // chbDutchPay
            // 
            this.chbDutchPay.AutoSize = true;
            this.chbDutchPay.Depth = 0;
            this.chbDutchPay.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbDutchPay.Location = new System.Drawing.Point(488, 120);
            this.chbDutchPay.Margin = new System.Windows.Forms.Padding(0);
            this.chbDutchPay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbDutchPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbDutchPay.Name = "chbDutchPay";
            this.chbDutchPay.Ripple = true;
            this.chbDutchPay.Size = new System.Drawing.Size(90, 30);
            this.chbDutchPay.TabIndex = 7;
            this.chbDutchPay.Text = "더치페이";
            this.chbDutchPay.UseVisualStyleBackColor = true;
            // 
            // lbnDutchPayHint
            // 
            this.lbnDutchPayHint.Depth = 0;
            this.lbnDutchPayHint.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbnDutchPayHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbnDutchPayHint.Location = new System.Drawing.Point(191, 149);
            this.lbnDutchPayHint.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbnDutchPayHint.Name = "lbnDutchPayHint";
            this.lbnDutchPayHint.Size = new System.Drawing.Size(331, 23);
            this.lbnDutchPayHint.TabIndex = 8;
            this.lbnDutchPayHint.Text = "더치페이는 총액을 입력 해 주세요";
            // 
            // btnNext
            // 
            this.btnNext.Depth = 0;
            this.btnNext.Location = new System.Drawing.Point(494, 210);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = true;
            this.btnNext.Size = new System.Drawing.Size(184, 32);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // AddTradeFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(690, 254);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbnDutchPayHint);
            this.Controls.Add(this.chbDutchPay);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.lbnPrice);
            this.Controls.Add(this.lbnFriendList);
            this.Controls.Add(this.lbnName);
            this.Controls.Add(this.btnSelectFriend);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTradeFirstForm";
            this.Text = "AddBorrowTradeForm";
            this.Load += new System.EventHandler(this.AddTradeFirstForm_Load);
            this.Shown += new System.EventHandler(this.AddTradeFirstForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField tbName;
        private MaterialSkin.Controls.MaterialFlatButton btnSelectFriend;
        private MaterialSkin.Controls.MaterialLabel lbnName;
        private MaterialSkin.Controls.MaterialLabel lbnFriendList;
        private MaterialSkin.Controls.MaterialLabel lbnPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialCheckBox chbDutchPay;
        private MaterialSkin.Controls.MaterialLabel lbnDutchPayHint;
        private MaterialSkin.Controls.MaterialRaisedButton btnNext;
    }
}