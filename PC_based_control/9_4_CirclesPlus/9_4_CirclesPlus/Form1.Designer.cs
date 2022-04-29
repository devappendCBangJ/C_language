
namespace _9_4_CirclesPlus
{
    partial class frmMain
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
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.lblNCir = new System.Windows.Forms.Label();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radDel = new System.Windows.Forms.RadioButton();
            this.chkMove = new System.Windows.Forms.CheckBox();
            this.chcDelIncluded = new System.Windows.Forms.CheckBox();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.Location = new System.Drawing.Point(13, 13);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(500, 500);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            this.picDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDraw_MouseUp);
            // 
            // lblNCir
            // 
            this.lblNCir.AutoSize = true;
            this.lblNCir.Location = new System.Drawing.Point(543, 14);
            this.lblNCir.Name = "lblNCir";
            this.lblNCir.Size = new System.Drawing.Size(87, 15);
            this.lblNCir.TabIndex = 1;
            this.lblNCir.Text = "원의 개수 : ";
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Location = new System.Drawing.Point(546, 47);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(73, 19);
            this.radAdd.TabIndex = 2;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "더하기";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radDel
            // 
            this.radDel.AutoSize = true;
            this.radDel.Location = new System.Drawing.Point(547, 83);
            this.radDel.Name = "radDel";
            this.radDel.Size = new System.Drawing.Size(58, 19);
            this.radDel.TabIndex = 3;
            this.radDel.TabStop = true;
            this.radDel.Text = "빼기";
            this.radDel.UseVisualStyleBackColor = true;
            // 
            // chkMove
            // 
            this.chkMove.AutoSize = true;
            this.chkMove.Location = new System.Drawing.Point(547, 144);
            this.chkMove.Name = "chkMove";
            this.chkMove.Size = new System.Drawing.Size(59, 19);
            this.chkMove.TabIndex = 4;
            this.chkMove.Text = "이동";
            this.chkMove.UseVisualStyleBackColor = true;
            // 
            // chcDelIncluded
            // 
            this.chcDelIncluded.AutoSize = true;
            this.chcDelIncluded.Location = new System.Drawing.Point(546, 180);
            this.chcDelIncluded.Name = "chcDelIncluded";
            this.chcDelIncluded.Size = new System.Drawing.Size(159, 19);
            this.chcDelIncluded.TabIndex = 5;
            this.chcDelIncluded.Text = "포함되는 원 지우기";
            this.chcDelIncluded.UseVisualStyleBackColor = true;
            // 
            // btnAdd100
            // 
            this.btnAdd100.Location = new System.Drawing.Point(546, 246);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(137, 85);
            this.btnAdd100.TabIndex = 6;
            this.btnAdd100.Text = "100개 넣기";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(546, 428);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(137, 85);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "끝내기";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Location = new System.Drawing.Point(547, 337);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(137, 85);
            this.btnDelAll.TabIndex = 8;
            this.btnDelAll.Text = "모두 삭제";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 525);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.chcDelIncluded);
            this.Controls.Add(this.chkMove);
            this.Controls.Add(this.radDel);
            this.Controls.Add(this.radAdd);
            this.Controls.Add(this.lblNCir);
            this.Controls.Add(this.picDraw);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Label lblNCir;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radDel;
        private System.Windows.Forms.CheckBox chkMove;
        private System.Windows.Forms.CheckBox chcDelIncluded;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Timer timer1;
    }
}

