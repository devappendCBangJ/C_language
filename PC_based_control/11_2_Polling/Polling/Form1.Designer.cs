namespace Polling
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkButton3 = new System.Windows.Forms.CheckBox();
            this.chkButton2 = new System.Windows.Forms.CheckBox();
            this.chkButton1 = new System.Windows.Forms.CheckBox();
            this.chkButton0 = new System.Windows.Forms.CheckBox();
            this.chkComm = new System.Windows.Forms.CheckBox();
            this.picComm = new System.Windows.Forms.PictureBox();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLED3 = new System.Windows.Forms.Label();
            this.lblLED2 = new System.Windows.Forms.Label();
            this.lblLED1 = new System.Windows.Forms.Label();
            this.lblLED0 = new System.Windows.Forms.Label();
            this.hscLED3 = new System.Windows.Forms.HScrollBar();
            this.hscLED2 = new System.Windows.Forms.HScrollBar();
            this.hscLED1 = new System.Windows.Forms.HScrollBar();
            this.hscLED0 = new System.Windows.Forms.HScrollBar();
            this.chkDO3 = new System.Windows.Forms.CheckBox();
            this.chkDO2 = new System.Windows.Forms.CheckBox();
            this.chkDO1 = new System.Windows.Forms.CheckBox();
            this.chkDO0 = new System.Windows.Forms.CheckBox();
            this.radAnalog = new System.Windows.Forms.RadioButton();
            this.radDigital = new System.Windows.Forms.RadioButton();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timLampOff = new System.Windows.Forms.Timer(this.components);
            this.timCommMon = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtAD);
            this.groupBox3.Location = new System.Drawing.Point(437, 324);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(190, 149);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "가변저항 모니터링";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(46, 61);
            this.txtAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(99, 25);
            this.txtAD.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chkButton3);
            this.groupBox2.Controls.Add(this.chkButton2);
            this.groupBox2.Controls.Add(this.chkButton1);
            this.groupBox2.Controls.Add(this.chkButton0);
            this.groupBox2.Location = new System.Drawing.Point(437, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(190, 170);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button 모니터링";
            // 
            // chkButton3
            // 
            this.chkButton3.AutoSize = true;
            this.chkButton3.Location = new System.Drawing.Point(38, 122);
            this.chkButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton3.Name = "chkButton3";
            this.chkButton3.Size = new System.Drawing.Size(85, 19);
            this.chkButton3.TabIndex = 3;
            this.chkButton3.Text = "Button 4";
            this.chkButton3.UseVisualStyleBackColor = true;
            // 
            // chkButton2
            // 
            this.chkButton2.AutoSize = true;
            this.chkButton2.Location = new System.Drawing.Point(38, 95);
            this.chkButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton2.Name = "chkButton2";
            this.chkButton2.Size = new System.Drawing.Size(85, 19);
            this.chkButton2.TabIndex = 2;
            this.chkButton2.Text = "Button 3";
            this.chkButton2.UseVisualStyleBackColor = true;
            // 
            // chkButton1
            // 
            this.chkButton1.AutoSize = true;
            this.chkButton1.Location = new System.Drawing.Point(38, 68);
            this.chkButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton1.Name = "chkButton1";
            this.chkButton1.Size = new System.Drawing.Size(85, 19);
            this.chkButton1.TabIndex = 1;
            this.chkButton1.Text = "Button 2";
            this.chkButton1.UseVisualStyleBackColor = true;
            // 
            // chkButton0
            // 
            this.chkButton0.AutoSize = true;
            this.chkButton0.Location = new System.Drawing.Point(38, 40);
            this.chkButton0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkButton0.Name = "chkButton0";
            this.chkButton0.Size = new System.Drawing.Size(85, 19);
            this.chkButton0.TabIndex = 0;
            this.chkButton0.Text = "Button 1";
            this.chkButton0.UseVisualStyleBackColor = true;
            // 
            // chkComm
            // 
            this.chkComm.AutoSize = true;
            this.chkComm.Location = new System.Drawing.Point(503, 99);
            this.chkComm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkComm.Name = "chkComm";
            this.chkComm.Size = new System.Drawing.Size(89, 19);
            this.chkComm.TabIndex = 20;
            this.chkComm.Text = "통신실행";
            this.chkComm.UseVisualStyleBackColor = true;
            this.chkComm.CheckedChanged += new System.EventHandler(this.chkComm_CheckedChanged);
            // 
            // picComm
            // 
            this.picComm.Image = global::Polling.Properties.Resources.LampOff;
            this.picComm.Location = new System.Drawing.Point(615, 72);
            this.picComm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picComm.Name = "picComm";
            this.picComm.Size = new System.Drawing.Size(10, 10);
            this.picComm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picComm.TabIndex = 19;
            this.picComm.TabStop = false;
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(502, 65);
            this.txtPortNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(99, 25);
            this.txtPortNum.TabIndex = 18;
            this.txtPortNum.Text = "6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "포트번호";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblLED3);
            this.groupBox1.Controls.Add(this.lblLED2);
            this.groupBox1.Controls.Add(this.lblLED1);
            this.groupBox1.Controls.Add(this.lblLED0);
            this.groupBox1.Controls.Add(this.hscLED3);
            this.groupBox1.Controls.Add(this.hscLED2);
            this.groupBox1.Controls.Add(this.hscLED1);
            this.groupBox1.Controls.Add(this.hscLED0);
            this.groupBox1.Controls.Add(this.chkDO3);
            this.groupBox1.Controls.Add(this.chkDO2);
            this.groupBox1.Controls.Add(this.chkDO1);
            this.groupBox1.Controls.Add(this.chkDO0);
            this.groupBox1.Controls.Add(this.radAnalog);
            this.groupBox1.Controls.Add(this.radDigital);
            this.groupBox1.Location = new System.Drawing.Point(41, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(374, 424);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED 제어";
            // 
            // lblLED3
            // 
            this.lblLED3.AutoSize = true;
            this.lblLED3.Location = new System.Drawing.Point(305, 384);
            this.lblLED3.Name = "lblLED3";
            this.lblLED3.Size = new System.Drawing.Size(15, 15);
            this.lblLED3.TabIndex = 13;
            this.lblLED3.Text = "0";
            // 
            // lblLED2
            // 
            this.lblLED2.AutoSize = true;
            this.lblLED2.Location = new System.Drawing.Point(305, 339);
            this.lblLED2.Name = "lblLED2";
            this.lblLED2.Size = new System.Drawing.Size(15, 15);
            this.lblLED2.TabIndex = 12;
            this.lblLED2.Text = "0";
            // 
            // lblLED1
            // 
            this.lblLED1.AutoSize = true;
            this.lblLED1.Location = new System.Drawing.Point(305, 296);
            this.lblLED1.Name = "lblLED1";
            this.lblLED1.Size = new System.Drawing.Size(15, 15);
            this.lblLED1.TabIndex = 11;
            this.lblLED1.Text = "0";
            // 
            // lblLED0
            // 
            this.lblLED0.AutoSize = true;
            this.lblLED0.Location = new System.Drawing.Point(305, 252);
            this.lblLED0.Name = "lblLED0";
            this.lblLED0.Size = new System.Drawing.Size(15, 15);
            this.lblLED0.TabIndex = 10;
            this.lblLED0.Text = "0";
            // 
            // hscLED3
            // 
            this.hscLED3.Location = new System.Drawing.Point(43, 376);
            this.hscLED3.Maximum = 255;
            this.hscLED3.Name = "hscLED3";
            this.hscLED3.Size = new System.Drawing.Size(248, 21);
            this.hscLED3.TabIndex = 9;
            this.hscLED3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscLED_Scroll);
            // 
            // hscLED2
            // 
            this.hscLED2.Location = new System.Drawing.Point(43, 331);
            this.hscLED2.Maximum = 255;
            this.hscLED2.Name = "hscLED2";
            this.hscLED2.Size = new System.Drawing.Size(248, 21);
            this.hscLED2.TabIndex = 8;
            this.hscLED2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscLED_Scroll);
            // 
            // hscLED1
            // 
            this.hscLED1.Location = new System.Drawing.Point(43, 289);
            this.hscLED1.Maximum = 255;
            this.hscLED1.Name = "hscLED1";
            this.hscLED1.Size = new System.Drawing.Size(248, 21);
            this.hscLED1.TabIndex = 7;
            this.hscLED1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscLED_Scroll);
            // 
            // hscLED0
            // 
            this.hscLED0.Location = new System.Drawing.Point(43, 245);
            this.hscLED0.Maximum = 255;
            this.hscLED0.Name = "hscLED0";
            this.hscLED0.Size = new System.Drawing.Size(248, 21);
            this.hscLED0.TabIndex = 6;
            this.hscLED0.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscLED_Scroll);
            // 
            // chkDO3
            // 
            this.chkDO3.AutoSize = true;
            this.chkDO3.Location = new System.Drawing.Point(43, 152);
            this.chkDO3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDO3.Name = "chkDO3";
            this.chkDO3.Size = new System.Drawing.Size(69, 19);
            this.chkDO3.TabIndex = 5;
            this.chkDO3.Text = "LED 4";
            this.chkDO3.UseVisualStyleBackColor = true;
            this.chkDO3.CheckedChanged += new System.EventHandler(this.chkDO_CheckedChanged);
            // 
            // chkDO2
            // 
            this.chkDO2.AutoSize = true;
            this.chkDO2.Location = new System.Drawing.Point(43, 125);
            this.chkDO2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDO2.Name = "chkDO2";
            this.chkDO2.Size = new System.Drawing.Size(69, 19);
            this.chkDO2.TabIndex = 4;
            this.chkDO2.Text = "LED 3";
            this.chkDO2.UseVisualStyleBackColor = true;
            this.chkDO2.CheckedChanged += new System.EventHandler(this.chkDO_CheckedChanged);
            // 
            // chkDO1
            // 
            this.chkDO1.AutoSize = true;
            this.chkDO1.Location = new System.Drawing.Point(43, 98);
            this.chkDO1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDO1.Name = "chkDO1";
            this.chkDO1.Size = new System.Drawing.Size(69, 19);
            this.chkDO1.TabIndex = 3;
            this.chkDO1.Text = "LED 2";
            this.chkDO1.UseVisualStyleBackColor = true;
            this.chkDO1.CheckedChanged += new System.EventHandler(this.chkDO_CheckedChanged);
            // 
            // chkDO0
            // 
            this.chkDO0.AutoSize = true;
            this.chkDO0.Location = new System.Drawing.Point(43, 70);
            this.chkDO0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDO0.Name = "chkDO0";
            this.chkDO0.Size = new System.Drawing.Size(69, 19);
            this.chkDO0.TabIndex = 2;
            this.chkDO0.Text = "LED 1";
            this.chkDO0.UseVisualStyleBackColor = true;
            this.chkDO0.CheckedChanged += new System.EventHandler(this.chkDO_CheckedChanged);
            // 
            // radAnalog
            // 
            this.radAnalog.AutoSize = true;
            this.radAnalog.Location = new System.Drawing.Point(24, 206);
            this.radAnalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radAnalog.Name = "radAnalog";
            this.radAnalog.Size = new System.Drawing.Size(108, 19);
            this.radAnalog.TabIndex = 1;
            this.radAnalog.TabStop = true;
            this.radAnalog.Text = "Analog 제어";
            this.radAnalog.UseVisualStyleBackColor = true;
            this.radAnalog.CheckedChanged += new System.EventHandler(this.radAnalog_CheckedChanged);
            // 
            // radDigital
            // 
            this.radDigital.AutoSize = true;
            this.radDigital.Location = new System.Drawing.Point(24, 42);
            this.radDigital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radDigital.Name = "radDigital";
            this.radDigital.Size = new System.Drawing.Size(102, 19);
            this.radDigital.TabIndex = 0;
            this.radDigital.TabStop = true;
            this.radDigital.Text = "Digital 제어";
            this.radDigital.UseVisualStyleBackColor = true;
            this.radDigital.CheckedChanged += new System.EventHandler(this.radDigital_CheckedChanged);
            // 
            // timLampOff
            // 
            this.timLampOff.Enabled = true;
            this.timLampOff.Interval = 150;
            this.timLampOff.Tick += new System.EventHandler(this.timLampOff_Tick);
            // 
            // timCommMon
            // 
            this.timCommMon.Enabled = true;
            this.timCommMon.Interval = 200;
            this.timCommMon.Tick += new System.EventHandler(this.timCommMon_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkComm);
            this.Controls.Add(this.picComm);
            this.Controls.Add(this.txtPortNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkButton3;
        private System.Windows.Forms.CheckBox chkButton2;
        private System.Windows.Forms.CheckBox chkButton1;
        private System.Windows.Forms.CheckBox chkButton0;
        private System.Windows.Forms.CheckBox chkComm;
        private System.Windows.Forms.PictureBox picComm;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLED3;
        private System.Windows.Forms.Label lblLED2;
        private System.Windows.Forms.Label lblLED1;
        private System.Windows.Forms.Label lblLED0;
        private System.Windows.Forms.HScrollBar hscLED3;
        private System.Windows.Forms.HScrollBar hscLED2;
        private System.Windows.Forms.HScrollBar hscLED1;
        private System.Windows.Forms.HScrollBar hscLED0;
        private System.Windows.Forms.CheckBox chkDO3;
        private System.Windows.Forms.CheckBox chkDO2;
        private System.Windows.Forms.CheckBox chkDO1;
        private System.Windows.Forms.CheckBox chkDO0;
        private System.Windows.Forms.RadioButton radAnalog;
        private System.Windows.Forms.RadioButton radDigital;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timLampOff;
        private System.Windows.Forms.Timer timCommMon;
    }
}

