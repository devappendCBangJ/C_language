namespace TalkOnly
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
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.lblRcv = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkButton0 = new System.Windows.Forms.CheckBox();
            this.chkButton3 = new System.Windows.Forms.CheckBox();
            this.chkButton1 = new System.Windows.Forms.CheckBox();
            this.chkButton2 = new System.Windows.Forms.CheckBox();
            this.txtPotentio = new System.Windows.Forms.TextBox();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Location = new System.Drawing.Point(234, 44);
            this.chkStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(89, 19);
            this.chkStart.TabIndex = 15;
            this.chkStart.Text = "수신개시";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.CheckedChanged += new System.EventHandler(this.chkStart_CheckedChanged);
            // 
            // lblRcv
            // 
            this.lblRcv.AutoSize = true;
            this.lblRcv.Location = new System.Drawing.Point(57, 419);
            this.lblRcv.Name = "lblRcv";
            this.lblRcv.Size = new System.Drawing.Size(73, 15);
            this.lblRcv.TabIndex = 14;
            this.lblRcv.Text = "수신 : ***";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkButton0);
            this.groupBox1.Controls.Add(this.chkButton3);
            this.groupBox1.Controls.Add(this.chkButton1);
            this.groupBox1.Controls.Add(this.chkButton2);
            this.groupBox1.Location = new System.Drawing.Point(59, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(191, 234);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "버튼상태";
            // 
            // chkButton0
            // 
            this.chkButton0.AutoSize = true;
            this.chkButton0.Location = new System.Drawing.Point(41, 44);
            this.chkButton0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton0.Name = "chkButton0";
            this.chkButton0.Size = new System.Drawing.Size(85, 19);
            this.chkButton0.TabIndex = 2;
            this.chkButton0.Text = "Button 1";
            this.chkButton0.UseVisualStyleBackColor = true;
            // 
            // chkButton3
            // 
            this.chkButton3.AutoSize = true;
            this.chkButton3.Location = new System.Drawing.Point(41, 179);
            this.chkButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton3.Name = "chkButton3";
            this.chkButton3.Size = new System.Drawing.Size(85, 19);
            this.chkButton3.TabIndex = 5;
            this.chkButton3.Text = "Button 4";
            this.chkButton3.UseVisualStyleBackColor = true;
            // 
            // chkButton1
            // 
            this.chkButton1.AutoSize = true;
            this.chkButton1.Location = new System.Drawing.Point(41, 89);
            this.chkButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton1.Name = "chkButton1";
            this.chkButton1.Size = new System.Drawing.Size(85, 19);
            this.chkButton1.TabIndex = 3;
            this.chkButton1.Text = "Button 2";
            this.chkButton1.UseVisualStyleBackColor = true;
            // 
            // chkButton2
            // 
            this.chkButton2.AutoSize = true;
            this.chkButton2.Location = new System.Drawing.Point(41, 134);
            this.chkButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton2.Name = "chkButton2";
            this.chkButton2.Size = new System.Drawing.Size(85, 19);
            this.chkButton2.TabIndex = 4;
            this.chkButton2.Text = "Button 3";
            this.chkButton2.UseVisualStyleBackColor = true;
            // 
            // txtPotentio
            // 
            this.txtPotentio.Location = new System.Drawing.Point(107, 362);
            this.txtPotentio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPotentio.Name = "txtPotentio";
            this.txtPotentio.Size = new System.Drawing.Size(91, 25);
            this.txtPotentio.TabIndex = 11;
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(107, 41);
            this.txtPortNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(91, 25);
            this.txtPortNum.TabIndex = 12;
            this.txtPortNum.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "가변저항값";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "포트번호";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 464);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.lblRcv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPotentio);
            this.Controls.Add(this.txtPortNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStart;
        private System.Windows.Forms.Label lblRcv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkButton0;
        private System.Windows.Forms.CheckBox chkButton3;
        private System.Windows.Forms.CheckBox chkButton1;
        private System.Windows.Forms.CheckBox chkButton2;
        private System.Windows.Forms.TextBox txtPotentio;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

