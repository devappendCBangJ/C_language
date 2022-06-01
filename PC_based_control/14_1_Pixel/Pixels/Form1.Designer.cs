namespace Pixels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picBin = new System.Windows.Forms.PictureBox();
            this.btnGray = new System.Windows.Forms.Button();
            this.lblScroll = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnMirrorUD = new System.Windows.Forms.Button();
            this.btnMirrorLR = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.picTrg = new System.Windows.Forms.PictureBox();
            this.picOrg = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(12, 296);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(88, 56);
            this.btnReadFile.TabIndex = 87;
            this.btnReadFile.Text = "파일읽기";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(890, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 56);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "파일저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picBin
            // 
            this.picBin.BackColor = System.Drawing.Color.White;
            this.picBin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBin.Location = new System.Drawing.Point(672, 12);
            this.picBin.Name = "picBin";
            this.picBin.Size = new System.Drawing.Size(306, 306);
            this.picBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBin.TabIndex = 83;
            this.picBin.TabStop = false;
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(559, 393);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(88, 56);
            this.btnGray.TabIndex = 82;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Location = new System.Drawing.Point(774, 362);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(11, 12);
            this.lblScroll.TabIndex = 81;
            this.lblScroll.Text = "0";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(772, 332);
            this.hScrollBar1.Maximum = 255;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(190, 20);
            this.hScrollBar1.TabIndex = 80;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(672, 332);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(88, 56);
            this.btnBin.TabIndex = 79;
            this.btnBin.Text = "이진화";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnMirrorUD
            // 
            this.btnMirrorUD.Location = new System.Drawing.Point(450, 393);
            this.btnMirrorUD.Name = "btnMirrorUD";
            this.btnMirrorUD.Size = new System.Drawing.Size(88, 56);
            this.btnMirrorUD.TabIndex = 76;
            this.btnMirrorUD.Text = "상하대칭";
            this.btnMirrorUD.UseVisualStyleBackColor = true;
            this.btnMirrorUD.Click += new System.EventHandler(this.btnMirrorUD_Click);
            // 
            // btnMirrorLR
            // 
            this.btnMirrorLR.Location = new System.Drawing.Point(341, 393);
            this.btnMirrorLR.Name = "btnMirrorLR";
            this.btnMirrorLR.Size = new System.Drawing.Size(88, 56);
            this.btnMirrorLR.TabIndex = 75;
            this.btnMirrorLR.Text = "좌우대칭";
            this.btnMirrorLR.UseVisualStyleBackColor = true;
            this.btnMirrorLR.Click += new System.EventHandler(this.btnMirrorLR_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(559, 331);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(88, 56);
            this.btnReverse.TabIndex = 74;
            this.btnReverse.Text = "역상";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 56);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(450, 331);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(88, 56);
            this.btnCopy.TabIndex = 72;
            this.btnCopy.Text = "복사";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(208, 358);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(48, 12);
            this.lblBlue.TabIndex = 71;
            this.lblBlue.Text = "Blue : *";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(199, 332);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(57, 12);
            this.lblGreen.TabIndex = 70;
            this.lblGreen.Text = "Green : *";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(211, 306);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(45, 12);
            this.lblRed.TabIndex = 69;
            this.lblRed.Text = "Red : *";
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picColor.Location = new System.Drawing.Point(17, 385);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(301, 126);
            this.picColor.TabIndex = 68;
            this.picColor.TabStop = false;
            // 
            // picTrg
            // 
            this.picTrg.BackColor = System.Drawing.Color.White;
            this.picTrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTrg.Location = new System.Drawing.Point(341, 12);
            this.picTrg.Name = "picTrg";
            this.picTrg.Size = new System.Drawing.Size(306, 306);
            this.picTrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTrg.TabIndex = 67;
            this.picTrg.TabStop = false;
            // 
            // picOrg
            // 
            this.picOrg.BackColor = System.Drawing.Color.White;
            this.picOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrg.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picOrg.Image = ((System.Drawing.Image)(resources.GetObject("picOrg.Image")));
            this.picOrg.Location = new System.Drawing.Point(12, 12);
            this.picOrg.Name = "picOrg";
            this.picOrg.Size = new System.Drawing.Size(306, 273);
            this.picOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOrg.TabIndex = 66;
            this.picOrg.TabStop = false;
            this.picOrg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOrg_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 528);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picBin);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnMirrorUD);
            this.Controls.Add(this.btnMirrorLR);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.picTrg);
            this.Controls.Add(this.picOrg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picBin;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnMirrorUD;
        private System.Windows.Forms.Button btnMirrorLR;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.PictureBox picTrg;
        private System.Windows.Forms.PictureBox picOrg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

