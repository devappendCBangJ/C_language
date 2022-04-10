
namespace _3_2_TotalSec
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
            this.txtTotalSec = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblTotalSec = new System.Windows.Forms.Label();
            this.btnTotalSec = new System.Windows.Forms.Button();
            this.btnHMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalSec
            // 
            this.txtTotalSec.Location = new System.Drawing.Point(106, 188);
            this.txtTotalSec.Name = "txtTotalSec";
            this.txtTotalSec.Size = new System.Drawing.Size(100, 21);
            this.txtTotalSec.TabIndex = 0;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(672, 114);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(672, 171);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 21);
            this.txtMin.TabIndex = 2;
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(672, 234);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(100, 21);
            this.txtSec.TabIndex = 3;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(625, 117);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(31, 12);
            this.lblHour.TabIndex = 4;
            this.lblHour.Text = "Hour";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(613, 174);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(43, 12);
            this.lblMin.TabIndex = 5;
            this.lblMin.Text = "Minute";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(608, 237);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(48, 12);
            this.lblSec.TabIndex = 6;
            this.lblSec.Text = "Second";
            // 
            // lblTotalSec
            // 
            this.lblTotalSec.AutoSize = true;
            this.lblTotalSec.Location = new System.Drawing.Point(45, 191);
            this.lblTotalSec.Name = "lblTotalSec";
            this.lblTotalSec.Size = new System.Drawing.Size(55, 12);
            this.lblTotalSec.TabIndex = 7;
            this.lblTotalSec.Text = "TotalSec";
            // 
            // btnTotalSec
            // 
            this.btnTotalSec.Location = new System.Drawing.Point(365, 79);
            this.btnTotalSec.Name = "btnTotalSec";
            this.btnTotalSec.Size = new System.Drawing.Size(99, 88);
            this.btnTotalSec.TabIndex = 8;
            this.btnTotalSec.Text = "<<";
            this.btnTotalSec.UseVisualStyleBackColor = true;
            this.btnTotalSec.Click += new System.EventHandler(this.btnTotalSec_Click);
            // 
            // btnHMS
            // 
            this.btnHMS.Location = new System.Drawing.Point(365, 199);
            this.btnHMS.Name = "btnHMS";
            this.btnHMS.Size = new System.Drawing.Size(99, 88);
            this.btnHMS.TabIndex = 9;
            this.btnHMS.Text = ">>";
            this.btnHMS.UseVisualStyleBackColor = true;
            this.btnHMS.Click += new System.EventHandler(this.btnHMS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHMS);
            this.Controls.Add(this.btnTotalSec);
            this.Controls.Add(this.lblTotalSec);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtTotalSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalSec;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblTotalSec;
        private System.Windows.Forms.Button btnTotalSec;
        private System.Windows.Forms.Button btnHMS;
    }
}

