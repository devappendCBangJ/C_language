
namespace _7_1_Geom
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
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.btnDraw3 = new System.Windows.Forms.Button();
            this.btnDraw100 = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.lblNCir = new System.Windows.Forms.Label();
            this.lblNDia = new System.Windows.Forms.Label();
            this.lblNTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(525, 426);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // btnDraw3
            // 
            this.btnDraw3.Location = new System.Drawing.Point(577, 12);
            this.btnDraw3.Name = "btnDraw3";
            this.btnDraw3.Size = new System.Drawing.Size(197, 102);
            this.btnDraw3.TabIndex = 1;
            this.btnDraw3.Text = "3개 그리기";
            this.btnDraw3.UseVisualStyleBackColor = true;
            this.btnDraw3.Click += new System.EventHandler(this.btnDraw3_Click);
            // 
            // btnDraw100
            // 
            this.btnDraw100.Location = new System.Drawing.Point(577, 120);
            this.btnDraw100.Name = "btnDraw100";
            this.btnDraw100.Size = new System.Drawing.Size(197, 102);
            this.btnDraw100.TabIndex = 2;
            this.btnDraw100.Text = "100개 그리기";
            this.btnDraw100.UseVisualStyleBackColor = true;
            this.btnDraw100.Click += new System.EventHandler(this.btnDraw100_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(577, 336);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(197, 102);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "지우기";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // lblNCir
            // 
            this.lblNCir.AutoSize = true;
            this.lblNCir.Location = new System.Drawing.Point(574, 236);
            this.lblNCir.Name = "lblNCir";
            this.lblNCir.Size = new System.Drawing.Size(45, 15);
            this.lblNCir.TabIndex = 4;
            this.lblNCir.Text = "label1";
            // 
            // lblNDia
            // 
            this.lblNDia.AutoSize = true;
            this.lblNDia.Location = new System.Drawing.Point(574, 272);
            this.lblNDia.Name = "lblNDia";
            this.lblNDia.Size = new System.Drawing.Size(45, 15);
            this.lblNDia.TabIndex = 5;
            this.lblNDia.Text = "label2";
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Location = new System.Drawing.Point(574, 309);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(45, 15);
            this.lblNTotal.TabIndex = 6;
            this.lblNTotal.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNTotal);
            this.Controls.Add(this.lblNDia);
            this.Controls.Add(this.lblNCir);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnDraw100);
            this.Controls.Add(this.btnDraw3);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Button btnDraw3;
        private System.Windows.Forms.Button btnDraw100;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label lblNCir;
        private System.Windows.Forms.Label lblNDia;
        private System.Windows.Forms.Label lblNTotal;
    }
}

