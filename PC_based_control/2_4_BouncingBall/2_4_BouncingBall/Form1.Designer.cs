
namespace _2_4_BouncingBall
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
            this.radSlow = new System.Windows.Forms.RadioButton();
            this.radFast = new System.Windows.Forms.RadioButton();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBall = new System.Windows.Forms.PictureBox();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // radSlow
            // 
            this.radSlow.AutoSize = true;
            this.radSlow.Checked = true;
            this.radSlow.Location = new System.Drawing.Point(45, 46);
            this.radSlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSlow.Name = "radSlow";
            this.radSlow.Size = new System.Drawing.Size(50, 16);
            this.radSlow.TabIndex = 1;
            this.radSlow.TabStop = true;
            this.radSlow.Text = "slow";
            this.radSlow.UseVisualStyleBackColor = true;
            this.radSlow.CheckedChanged += new System.EventHandler(this.radSlow_CheckedChanged);
            // 
            // radFast
            // 
            this.radFast.AutoSize = true;
            this.radFast.Location = new System.Drawing.Point(45, 80);
            this.radFast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFast.Name = "radFast";
            this.radFast.Size = new System.Drawing.Size(43, 16);
            this.radFast.TabIndex = 2;
            this.radFast.TabStop = true;
            this.radFast.Text = "fast";
            this.radFast.UseVisualStyleBackColor = true;
            this.radFast.CheckedChanged += new System.EventHandler(this.radFast_CheckedChanged);
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.radFast);
            this.grBox.Controls.Add(this.radSlow);
            this.grBox.Location = new System.Drawing.Point(535, 108);
            this.grBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBox.Size = new System.Drawing.Size(132, 138);
            this.grBox.TabIndex = 3;
            this.grBox.TabStop = false;
            this.grBox.Text = "Speed";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Blue;
            this.picBall.Location = new System.Drawing.Point(30, 25);
            this.picBall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(26, 24);
            this.picBall.TabIndex = 4;
            this.picBall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.grBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radSlow;
        private System.Windows.Forms.RadioButton radFast;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBall;
    }
}

