
namespace _3_3_BitControl
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtIdx = new System.Windows.Forms.TextBox();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.BtnFromBit = new System.Windows.Forms.Button();
            this.btnToBit = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.GrBoxBits = new System.Windows.Forms.GroupBox();
            this.GrBoxBits.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(48, 29);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(115, 21);
            this.txtNum.TabIndex = 0;
            // 
            // txtIdx
            // 
            this.txtIdx.Location = new System.Drawing.Point(48, 147);
            this.txtIdx.Name = "txtIdx";
            this.txtIdx.Size = new System.Drawing.Size(115, 21);
            this.txtIdx.TabIndex = 1;
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.Location = new System.Drawing.Point(48, 340);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(115, 59);
            this.btnShiftUp.TabIndex = 2;
            this.btnShiftUp.Text = "ShiftUp";
            this.btnShiftUp.UseVisualStyleBackColor = true;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Location = new System.Drawing.Point(198, 340);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(115, 59);
            this.btnShiftDown.TabIndex = 3;
            this.btnShiftDown.Text = "ShiftDown";
            this.btnShiftDown.UseVisualStyleBackColor = true;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(213, 202);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(100, 49);
            this.btnOff.TabIndex = 4;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(213, 147);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(100, 49);
            this.btnOn.TabIndex = 5;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // BtnFromBit
            // 
            this.BtnFromBit.Location = new System.Drawing.Point(213, 82);
            this.BtnFromBit.Name = "BtnFromBit";
            this.BtnFromBit.Size = new System.Drawing.Size(100, 48);
            this.BtnFromBit.TabIndex = 6;
            this.BtnFromBit.Text = "<<";
            this.BtnFromBit.UseVisualStyleBackColor = true;
            this.BtnFromBit.Click += new System.EventHandler(this.BtnFromBit_Click);
            // 
            // btnToBit
            // 
            this.btnToBit.Location = new System.Drawing.Point(213, 29);
            this.btnToBit.Name = "btnToBit";
            this.btnToBit.Size = new System.Drawing.Size(100, 47);
            this.btnToBit.TabIndex = 7;
            this.btnToBit.Text = ">>";
            this.btnToBit.UseVisualStyleBackColor = true;
            this.btnToBit.Click += new System.EventHandler(this.btnToBit_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(213, 257);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(100, 49);
            this.btnToggle.TabIndex = 8;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(22, 30);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(30, 16);
            this.chk7.TabIndex = 9;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(22, 62);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(30, 16);
            this.chk6.TabIndex = 10;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(22, 95);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(30, 16);
            this.chk5.TabIndex = 11;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(22, 128);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(30, 16);
            this.chk4.TabIndex = 12;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(22, 167);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(30, 16);
            this.chk3.TabIndex = 13;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            this.chk3.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(22, 205);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(30, 16);
            this.chk2.TabIndex = 14;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(22, 238);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(30, 16);
            this.chk1.TabIndex = 15;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(22, 270);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(30, 16);
            this.chk0.TabIndex = 16;
            this.chk0.Text = "0";
            this.chk0.UseVisualStyleBackColor = true;
            this.chk0.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // GrBoxBits
            // 
            this.GrBoxBits.Controls.Add(this.chk7);
            this.GrBoxBits.Controls.Add(this.chk0);
            this.GrBoxBits.Controls.Add(this.chk6);
            this.GrBoxBits.Controls.Add(this.chk1);
            this.GrBoxBits.Controls.Add(this.chk5);
            this.GrBoxBits.Controls.Add(this.chk2);
            this.GrBoxBits.Controls.Add(this.chk4);
            this.GrBoxBits.Controls.Add(this.chk3);
            this.GrBoxBits.Location = new System.Drawing.Point(420, 52);
            this.GrBoxBits.Name = "GrBoxBits";
            this.GrBoxBits.Size = new System.Drawing.Size(81, 308);
            this.GrBoxBits.TabIndex = 17;
            this.GrBoxBits.TabStop = false;
            this.GrBoxBits.Text = "Bits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrBoxBits);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnToBit);
            this.Controls.Add(this.BtnFromBit);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.btnShiftUp);
            this.Controls.Add(this.txtIdx);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrBoxBits.ResumeLayout(false);
            this.GrBoxBits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtIdx;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button BtnFromBit;
        private System.Windows.Forms.Button btnToBit;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.GroupBox GrBoxBits;
    }
}

