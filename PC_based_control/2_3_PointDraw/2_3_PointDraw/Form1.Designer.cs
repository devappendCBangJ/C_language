
namespace _2_3_PointDraw
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
            this.PicDraw = new System.Windows.Forms.PictureBox();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // PicDraw
            // 
            this.PicDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PicDraw.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PicDraw.Location = new System.Drawing.Point(12, 12);
            this.PicDraw.Name = "PicDraw";
            this.PicDraw.Size = new System.Drawing.Size(665, 426);
            this.PicDraw.TabIndex = 0;
            this.PicDraw.TabStop = false;
            this.PicDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicDraw_MouseDown);
            this.PicDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicDraw_MouseMove);
            // 
            // picRed
            // 
            this.picRed.BackColor = System.Drawing.Color.Red;
            this.picRed.Location = new System.Drawing.Point(708, 12);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(57, 50);
            this.picRed.TabIndex = 1;
            this.picRed.TabStop = false;
            this.picRed.Click += new System.EventHandler(this.picRed_Click);
            // 
            // picBlue
            // 
            this.picBlue.BackColor = System.Drawing.Color.Blue;
            this.picBlue.Location = new System.Drawing.Point(708, 193);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(57, 50);
            this.picBlue.TabIndex = 2;
            this.picBlue.TabStop = false;
            this.picBlue.Click += new System.EventHandler(this.picBlue_Click);
            // 
            // picGreen
            // 
            this.picGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picGreen.Location = new System.Drawing.Point(708, 388);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(57, 50);
            this.picGreen.TabIndex = 3;
            this.picGreen.TabStop = false;
            this.picGreen.Click += new System.EventHandler(this.picGreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.PicDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicDraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicDraw;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picGreen;
    }
}

