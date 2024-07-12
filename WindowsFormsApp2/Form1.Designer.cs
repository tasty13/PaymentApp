namespace WindowsFormsApp2
{
    partial class Payment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lBOrderStatus = new System.Windows.Forms.ListBox();
            this.btnMenu01 = new System.Windows.Forms.Button();
            this.btnMenu02 = new System.Windows.Forms.Button();
            this.btnMenu03 = new System.Windows.Forms.Button();
            this.btnMenu04 = new System.Windows.Forms.Button();
            this.btnMenu05 = new System.Windows.Forms.Button();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblPayTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemoveMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("문체부 쓰기 흘림체", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(48, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "주문현황";
            // 
            // lBOrderStatus
            // 
            this.lBOrderStatus.FormattingEnabled = true;
            this.lBOrderStatus.ItemHeight = 12;
            this.lBOrderStatus.Location = new System.Drawing.Point(52, 74);
            this.lBOrderStatus.Name = "lBOrderStatus";
            this.lBOrderStatus.Size = new System.Drawing.Size(120, 88);
            this.lBOrderStatus.TabIndex = 1;
            // 
            // btnMenu01
            // 
            this.btnMenu01.Location = new System.Drawing.Point(178, 74);
            this.btnMenu01.Name = "btnMenu01";
            this.btnMenu01.Size = new System.Drawing.Size(75, 23);
            this.btnMenu01.TabIndex = 3;
            this.btnMenu01.Tag = "1";
            this.btnMenu01.Text = "김밥";
            this.btnMenu01.UseVisualStyleBackColor = true;
            this.btnMenu01.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu02
            // 
            this.btnMenu02.Location = new System.Drawing.Point(178, 103);
            this.btnMenu02.Name = "btnMenu02";
            this.btnMenu02.Size = new System.Drawing.Size(75, 23);
            this.btnMenu02.TabIndex = 4;
            this.btnMenu02.Tag = "2";
            this.btnMenu02.Text = "라면";
            this.btnMenu02.UseVisualStyleBackColor = true;
            this.btnMenu02.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu03
            // 
            this.btnMenu03.Location = new System.Drawing.Point(178, 132);
            this.btnMenu03.Name = "btnMenu03";
            this.btnMenu03.Size = new System.Drawing.Size(75, 23);
            this.btnMenu03.TabIndex = 5;
            this.btnMenu03.Tag = "3";
            this.btnMenu03.Text = "떡볶이";
            this.btnMenu03.UseVisualStyleBackColor = true;
            this.btnMenu03.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu04
            // 
            this.btnMenu04.Location = new System.Drawing.Point(178, 161);
            this.btnMenu04.Name = "btnMenu04";
            this.btnMenu04.Size = new System.Drawing.Size(75, 23);
            this.btnMenu04.TabIndex = 6;
            this.btnMenu04.Tag = "4";
            this.btnMenu04.Text = "순대";
            this.btnMenu04.UseVisualStyleBackColor = true;
            this.btnMenu04.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMenu05
            // 
            this.btnMenu05.Location = new System.Drawing.Point(178, 190);
            this.btnMenu05.Name = "btnMenu05";
            this.btnMenu05.Size = new System.Drawing.Size(75, 23);
            this.btnMenu05.TabIndex = 7;
            this.btnMenu05.Tag = "5";
            this.btnMenu05.Text = "공기밥";
            this.btnMenu05.UseVisualStyleBackColor = true;
            this.btnMenu05.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Location = new System.Drawing.Point(601, 103);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(85, 12);
            this.lblPaymentInfo.TabIndex = 8;
            this.lblPaymentInfo.Text = "결제 전입니다.";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(603, 74);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(83, 23);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "결제하기";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // lblPayTotal
            // 
            this.lblPayTotal.AutoSize = true;
            this.lblPayTotal.Location = new System.Drawing.Point(52, 169);
            this.lblPayTotal.Name = "lblPayTotal";
            this.lblPayTotal.Size = new System.Drawing.Size(87, 12);
            this.lblPayTotal.TabIndex = 10;
            this.lblPayTotal.Text = "총 결제 금액: 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(178, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.Location = new System.Drawing.Point(178, 262);
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveMenu.TabIndex = 12;
            this.btnRemoveMenu.Text = "선택 제거";
            this.btnRemoveMenu.UseVisualStyleBackColor = true;
            this.btnRemoveMenu.Click += new System.EventHandler(this.BtnRemoveMenu_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveMenu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPayTotal);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblPaymentInfo);
            this.Controls.Add(this.btnMenu05);
            this.Controls.Add(this.btnMenu04);
            this.Controls.Add(this.btnMenu03);
            this.Controls.Add(this.btnMenu02);
            this.Controls.Add(this.btnMenu01);
            this.Controls.Add(this.lBOrderStatus);
            this.Controls.Add(this.lblTitle);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lBOrderStatus;
        private System.Windows.Forms.Button btnMenu01;
        private System.Windows.Forms.Button btnMenu02;
        private System.Windows.Forms.Button btnMenu03;
        private System.Windows.Forms.Button btnMenu04;
        private System.Windows.Forms.Button btnMenu05;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPayTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemoveMenu;
    }
}

