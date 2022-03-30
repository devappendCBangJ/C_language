
namespace _5_5_MonteCarlo_Tri
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
            this.picArea = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRatioReal = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblRatioMonte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // picArea
            // 
            this.picArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(450, 450);
            this.picArea.TabIndex = 0;
            this.picArea.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(474, 356);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 106);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRatioReal
            // 
            this.lblRatioReal.AutoSize = true;
            this.lblRatioReal.Location = new System.Drawing.Point(472, 243);
            this.lblRatioReal.Name = "lblRatioReal";
            this.lblRatioReal.Size = new System.Drawing.Size(38, 12);
            this.lblRatioReal.TabIndex = 2;
            this.lblRatioReal.Text = "label1";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(472, 268);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(38, 12);
            this.lblIn.TabIndex = 3;
            this.lblIn.Text = "label2";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(472, 293);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(38, 12);
            this.lblOut.TabIndex = 4;
            this.lblOut.Text = "label3";
            // 
            // lblRatioMonte
            // 
            this.lblRatioMonte.AutoSize = true;
            this.lblRatioMonte.Location = new System.Drawing.Point(472, 319);
            this.lblRatioMonte.Name = "lblRatioMonte";
            this.lblRatioMonte.Size = new System.Drawing.Size(38, 12);
            this.lblRatioMonte.TabIndex = 5;
            this.lblRatioMonte.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 477);
            this.Controls.Add(this.lblRatioMonte);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblRatioReal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRatioReal;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblRatioMonte;
    }
}

