namespace WindowsFormsApp1
{
    partial class FormMenu
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPayInfo = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lBMenuList = new System.Windows.Forms.ListBox();
            this.lBPickedMenu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(57, 12);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "상품 목록";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(154, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "선택 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(154, 102);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "선택 제거";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnPayInfo
            // 
            this.btnPayInfo.AutoSize = true;
            this.btnPayInfo.Location = new System.Drawing.Point(480, 73);
            this.btnPayInfo.Name = "btnPayInfo";
            this.btnPayInfo.Size = new System.Drawing.Size(85, 12);
            this.btnPayInfo.TabIndex = 7;
            this.btnPayInfo.Text = "결제 전입니다.";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(482, 88);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(233, 190);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(87, 12);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "총 결제 금액: 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(482, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "처음으로";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // lBMenuList
            // 
            this.lBMenuList.FormattingEnabled = true;
            this.lBMenuList.ItemHeight = 12;
            this.lBMenuList.Location = new System.Drawing.Point(17, 39);
            this.lBMenuList.Name = "lBMenuList";
            this.lBMenuList.Size = new System.Drawing.Size(131, 148);
            this.lBMenuList.TabIndex = 11;
            // 
            // lBPickedMenu
            // 
            this.lBPickedMenu.FormattingEnabled = true;
            this.lBPickedMenu.ItemHeight = 12;
            this.lBPickedMenu.Location = new System.Drawing.Point(235, 39);
            this.lBPickedMenu.Name = "lBPickedMenu";
            this.lBPickedMenu.Size = new System.Drawing.Size(137, 148);
            this.lBPickedMenu.TabIndex = 12;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lBPickedMenu);
            this.Controls.Add(this.lBMenuList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnPayInfo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label btnPayInfo;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lBMenuList;
        private System.Windows.Forms.ListBox lBPickedMenu;
    }
}

