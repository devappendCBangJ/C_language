namespace DllMain
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
            this.btnInCPP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNPrime = new System.Windows.Forms.Label();
            this.txtNMax = new System.Windows.Forms.TextBox();
            this.btnInCSharp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInCPP
            // 
            this.btnInCPP.Location = new System.Drawing.Point(250, 123);
            this.btnInCPP.Name = "btnInCPP";
            this.btnInCPP.Size = new System.Drawing.Size(116, 58);
            this.btnInCPP.TabIndex = 15;
            this.btnInCPP.Text = "in C++";
            this.btnInCPP.UseVisualStyleBackColor = true;
            this.btnInCPP.Click += new System.EventHandler(this.btnInCPP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time(sec) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "N Prime : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "N Max : ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(115, 123);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(11, 12);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "0";
            // 
            // lblNPrime
            // 
            this.lblNPrime.AutoSize = true;
            this.lblNPrime.Location = new System.Drawing.Point(115, 83);
            this.lblNPrime.Name = "lblNPrime";
            this.lblNPrime.Size = new System.Drawing.Size(11, 12);
            this.lblNPrime.TabIndex = 10;
            this.lblNPrime.Text = "0";
            // 
            // txtNMax
            // 
            this.txtNMax.Location = new System.Drawing.Point(115, 34);
            this.txtNMax.Name = "txtNMax";
            this.txtNMax.Size = new System.Drawing.Size(81, 21);
            this.txtNMax.TabIndex = 9;
            this.txtNMax.Text = "300000";
            // 
            // btnInCSharp
            // 
            this.btnInCSharp.Location = new System.Drawing.Point(250, 34);
            this.btnInCSharp.Name = "btnInCSharp";
            this.btnInCSharp.Size = new System.Drawing.Size(116, 58);
            this.btnInCSharp.TabIndex = 8;
            this.btnInCSharp.Text = "in C#";
            this.btnInCSharp.UseVisualStyleBackColor = true;
            this.btnInCSharp.Click += new System.EventHandler(this.btnInCSharp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 211);
            this.Controls.Add(this.btnInCPP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNPrime);
            this.Controls.Add(this.txtNMax);
            this.Controls.Add(this.btnInCSharp);
            this.Name = "Form1";
            this.Text = "N Prime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInCPP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNPrime;
        private System.Windows.Forms.TextBox txtNMax;
        private System.Windows.Forms.Button btnInCSharp;
    }
}

