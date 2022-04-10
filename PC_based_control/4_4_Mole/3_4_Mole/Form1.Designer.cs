namespace _3_4_Mole
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
            this.picCard00 = new System.Windows.Forms.PictureBox();
            this.picCard01 = new System.Windows.Forms.PictureBox();
            this.picCard02 = new System.Windows.Forms.PictureBox();
            this.picCard03 = new System.Windows.Forms.PictureBox();
            this.picCard04 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.timOpen = new System.Windows.Forms.Timer(this.components);
            this.timClose = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCard00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard04)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard00
            // 
            this.picCard00.Image = global::_3_4_Mole.Properties.Resources.open;
            this.picCard00.Location = new System.Drawing.Point(137, 194);
            this.picCard00.Name = "picCard00";
            this.picCard00.Size = new System.Drawing.Size(71, 96);
            this.picCard00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard00.TabIndex = 0;
            this.picCard00.TabStop = false;
            this.picCard00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCard_MouseDown);
            // 
            // picCard01
            // 
            this.picCard01.Image = global::_3_4_Mole.Properties.Resources.closed;
            this.picCard01.Location = new System.Drawing.Point(248, 194);
            this.picCard01.Name = "picCard01";
            this.picCard01.Size = new System.Drawing.Size(71, 96);
            this.picCard01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard01.TabIndex = 1;
            this.picCard01.TabStop = false;
            this.picCard01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCard_MouseDown);
            // 
            // picCard02
            // 
            this.picCard02.Image = global::_3_4_Mole.Properties.Resources.closed;
            this.picCard02.Location = new System.Drawing.Point(359, 194);
            this.picCard02.Name = "picCard02";
            this.picCard02.Size = new System.Drawing.Size(71, 96);
            this.picCard02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard02.TabIndex = 2;
            this.picCard02.TabStop = false;
            this.picCard02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCard_MouseDown);
            // 
            // picCard03
            // 
            this.picCard03.Image = global::_3_4_Mole.Properties.Resources.closed;
            this.picCard03.Location = new System.Drawing.Point(470, 194);
            this.picCard03.Name = "picCard03";
            this.picCard03.Size = new System.Drawing.Size(71, 96);
            this.picCard03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard03.TabIndex = 3;
            this.picCard03.TabStop = false;
            this.picCard03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCard_MouseDown);
            // 
            // picCard04
            // 
            this.picCard04.Image = global::_3_4_Mole.Properties.Resources.closed;
            this.picCard04.Location = new System.Drawing.Point(581, 194);
            this.picCard04.Name = "picCard04";
            this.picCard04.Size = new System.Drawing.Size(71, 96);
            this.picCard04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard04.TabIndex = 4;
            this.picCard04.TabStop = false;
            this.picCard04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCard_MouseDown);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(134, 74);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(74, 78);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // timOpen
            // 
            this.timOpen.Enabled = true;
            this.timOpen.Interval = 500;
            this.timOpen.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timClose
            // 
            this.timClose.Interval = 500;
            this.timClose.Tick += new System.EventHandler(this.timClose_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picCard04);
            this.Controls.Add(this.picCard03);
            this.Controls.Add(this.picCard02);
            this.Controls.Add(this.picCard01);
            this.Controls.Add(this.picCard00);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCard00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard04)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard00;
        private System.Windows.Forms.PictureBox picCard01;
        private System.Windows.Forms.PictureBox picCard02;
        private System.Windows.Forms.PictureBox picCard03;
        private System.Windows.Forms.PictureBox picCard04;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timOpen;
        private System.Windows.Forms.Timer timClose;
    }
}

