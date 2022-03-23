namespace StringHandling
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnPadRight = new System.Windows.Forms.Button();
            this.btnPadLeft = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.txtOUT = new System.Windows.Forms.TextBox();
            this.txtIN2 = new System.Windows.Forms.TextBox();
            this.txtIN1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(212, 221);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 12);
            this.lblTime.TabIndex = 67;
            this.lblTime.Text = "lblTime";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(523, 145);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(97, 57);
            this.btnReplace.TabIndex = 66;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(420, 145);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(97, 57);
            this.btnSplit.TabIndex = 65;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnPadRight
            // 
            this.btnPadRight.Location = new System.Drawing.Point(317, 145);
            this.btnPadRight.Name = "btnPadRight";
            this.btnPadRight.Size = new System.Drawing.Size(97, 57);
            this.btnPadRight.TabIndex = 64;
            this.btnPadRight.Text = "PadRight";
            this.btnPadRight.UseVisualStyleBackColor = true;
            this.btnPadRight.Click += new System.EventHandler(this.btnPadRight_Click);
            // 
            // btnPadLeft
            // 
            this.btnPadLeft.Location = new System.Drawing.Point(214, 145);
            this.btnPadLeft.Name = "btnPadLeft";
            this.btnPadLeft.Size = new System.Drawing.Size(97, 57);
            this.btnPadLeft.TabIndex = 63;
            this.btnPadLeft.Text = "PadLeft";
            this.btnPadLeft.UseVisualStyleBackColor = true;
            this.btnPadLeft.Click += new System.EventHandler(this.btnPadLeft_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(523, 82);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 57);
            this.btnFind.TabIndex = 62;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(420, 82);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(97, 57);
            this.btnCompare.TabIndex = 61;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(317, 82);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(97, 57);
            this.btnLower.TabIndex = 60;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(214, 82);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(97, 57);
            this.btnUpper.TabIndex = 59;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(523, 19);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(97, 57);
            this.btnMid.TabIndex = 58;
            this.btnMid.Text = "Mid 2,3";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(420, 19);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(97, 57);
            this.btnRight.TabIndex = 57;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(317, 19);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(97, 57);
            this.btnLeft.TabIndex = 56;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(214, 19);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(97, 57);
            this.btnLength.TabIndex = 55;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // txtOUT
            // 
            this.txtOUT.Location = new System.Drawing.Point(12, 212);
            this.txtOUT.Name = "txtOUT";
            this.txtOUT.Size = new System.Drawing.Size(166, 21);
            this.txtOUT.TabIndex = 54;
            // 
            // txtIN2
            // 
            this.txtIN2.Location = new System.Drawing.Point(12, 76);
            this.txtIN2.Name = "txtIN2";
            this.txtIN2.Size = new System.Drawing.Size(166, 21);
            this.txtIN2.TabIndex = 53;
            // 
            // txtIN1
            // 
            this.txtIN1.Location = new System.Drawing.Point(12, 29);
            this.txtIN1.Name = "txtIN1";
            this.txtIN1.Size = new System.Drawing.Size(166, 21);
            this.txtIN1.TabIndex = 52;
            this.txtIN1.Text = "ABCdef";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 248);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnPadRight);
            this.Controls.Add(this.btnPadLeft);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.txtOUT);
            this.Controls.Add(this.txtIN2);
            this.Controls.Add(this.txtIN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnPadRight;
        private System.Windows.Forms.Button btnPadLeft;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.TextBox txtOUT;
        private System.Windows.Forms.TextBox txtIN2;
        private System.Windows.Forms.TextBox txtIN1;
        private System.Windows.Forms.Timer timer1;
    }
}

