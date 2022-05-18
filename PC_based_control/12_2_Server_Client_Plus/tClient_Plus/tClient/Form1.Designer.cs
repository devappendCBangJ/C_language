namespace tClient
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
            this.lblCommNG = new System.Windows.Forms.Label();
            this.lblCommOK = new System.Windows.Forms.Label();
            this.lblConnComm = new System.Windows.Forms.Label();
            this.btnReadBits = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDI0 = new System.Windows.Forms.CheckBox();
            this.chkDI1 = new System.Windows.Forms.CheckBox();
            this.chkDI2 = new System.Windows.Forms.CheckBox();
            this.chkDI3 = new System.Windows.Forms.CheckBox();
            this.chkDI4 = new System.Windows.Forms.CheckBox();
            this.chkDI5 = new System.Windows.Forms.CheckBox();
            this.chkDI6 = new System.Windows.Forms.CheckBox();
            this.chkDI7 = new System.Windows.Forms.CheckBox();
            this.btnServerMe = new System.Windows.Forms.Button();
            this.btnServerLoopBack = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblConnChat = new System.Windows.Forms.Label();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lblO = new System.Windows.Forms.Label();
            this.lblComInfo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.lblConnCopy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timConnStatus = new System.Windows.Forms.Timer(this.components);
            this.timGetRcvMsg = new System.Windows.Forms.Timer(this.components);
            this.timAskBits = new System.Windows.Forms.Timer(this.components);
            this.lblConnCopy2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCommNG
            // 
            this.lblCommNG.AutoSize = true;
            this.lblCommNG.Location = new System.Drawing.Point(510, 574);
            this.lblCommNG.Name = "lblCommNG";
            this.lblCommNG.Size = new System.Drawing.Size(11, 12);
            this.lblCommNG.TabIndex = 106;
            this.lblCommNG.Text = "0";
            // 
            // lblCommOK
            // 
            this.lblCommOK.AutoSize = true;
            this.lblCommOK.Location = new System.Drawing.Point(510, 558);
            this.lblCommOK.Name = "lblCommOK";
            this.lblCommOK.Size = new System.Drawing.Size(11, 12);
            this.lblCommOK.TabIndex = 105;
            this.lblCommOK.Text = "0";
            // 
            // lblConnComm
            // 
            this.lblConnComm.AutoSize = true;
            this.lblConnComm.Location = new System.Drawing.Point(429, 146);
            this.lblConnComm.Name = "lblConnComm";
            this.lblConnComm.Size = new System.Drawing.Size(86, 12);
            this.lblConnComm.TabIndex = 104;
            this.lblConnComm.Text = "lblConnComm";
            // 
            // btnReadBits
            // 
            this.btnReadBits.Location = new System.Drawing.Point(434, 556);
            this.btnReadBits.Name = "btnReadBits";
            this.btnReadBits.Size = new System.Drawing.Size(69, 30);
            this.btnReadBits.TabIndex = 103;
            this.btnReadBits.Text = "Read Bits";
            this.btnReadBits.UseVisualStyleBackColor = true;
            this.btnReadBits.Click += new System.EventHandler(this.btnReadBits_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chkDI0);
            this.groupBox2.Controls.Add(this.chkDI1);
            this.groupBox2.Controls.Add(this.chkDI2);
            this.groupBox2.Controls.Add(this.chkDI3);
            this.groupBox2.Controls.Add(this.chkDI4);
            this.groupBox2.Controls.Add(this.chkDI5);
            this.groupBox2.Controls.Add(this.chkDI6);
            this.groupBox2.Controls.Add(this.chkDI7);
            this.groupBox2.Location = new System.Drawing.Point(433, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 216);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입력접점";
            // 
            // chkDI0
            // 
            this.chkDI0.AutoSize = true;
            this.chkDI0.Location = new System.Drawing.Point(15, 189);
            this.chkDI0.Name = "chkDI0";
            this.chkDI0.Size = new System.Drawing.Size(82, 16);
            this.chkDI0.TabIndex = 7;
            this.chkDI0.Text = "입력접점 1";
            this.chkDI0.UseVisualStyleBackColor = true;
            // 
            // chkDI1
            // 
            this.chkDI1.AutoSize = true;
            this.chkDI1.Location = new System.Drawing.Point(15, 165);
            this.chkDI1.Name = "chkDI1";
            this.chkDI1.Size = new System.Drawing.Size(82, 16);
            this.chkDI1.TabIndex = 6;
            this.chkDI1.Text = "입력접점 2";
            this.chkDI1.UseVisualStyleBackColor = true;
            // 
            // chkDI2
            // 
            this.chkDI2.AutoSize = true;
            this.chkDI2.Location = new System.Drawing.Point(15, 141);
            this.chkDI2.Name = "chkDI2";
            this.chkDI2.Size = new System.Drawing.Size(82, 16);
            this.chkDI2.TabIndex = 5;
            this.chkDI2.Text = "입력접점 3";
            this.chkDI2.UseVisualStyleBackColor = true;
            // 
            // chkDI3
            // 
            this.chkDI3.AutoSize = true;
            this.chkDI3.Location = new System.Drawing.Point(15, 117);
            this.chkDI3.Name = "chkDI3";
            this.chkDI3.Size = new System.Drawing.Size(82, 16);
            this.chkDI3.TabIndex = 4;
            this.chkDI3.Text = "입력접점 4";
            this.chkDI3.UseVisualStyleBackColor = true;
            // 
            // chkDI4
            // 
            this.chkDI4.AutoSize = true;
            this.chkDI4.Location = new System.Drawing.Point(15, 93);
            this.chkDI4.Name = "chkDI4";
            this.chkDI4.Size = new System.Drawing.Size(82, 16);
            this.chkDI4.TabIndex = 3;
            this.chkDI4.Text = "입력접점 5";
            this.chkDI4.UseVisualStyleBackColor = true;
            // 
            // chkDI5
            // 
            this.chkDI5.AutoSize = true;
            this.chkDI5.Location = new System.Drawing.Point(15, 69);
            this.chkDI5.Name = "chkDI5";
            this.chkDI5.Size = new System.Drawing.Size(82, 16);
            this.chkDI5.TabIndex = 2;
            this.chkDI5.Text = "입력접점 6";
            this.chkDI5.UseVisualStyleBackColor = true;
            // 
            // chkDI6
            // 
            this.chkDI6.AutoSize = true;
            this.chkDI6.Location = new System.Drawing.Point(15, 45);
            this.chkDI6.Name = "chkDI6";
            this.chkDI6.Size = new System.Drawing.Size(82, 16);
            this.chkDI6.TabIndex = 1;
            this.chkDI6.Text = "입력접점 7";
            this.chkDI6.UseVisualStyleBackColor = true;
            // 
            // chkDI7
            // 
            this.chkDI7.AutoSize = true;
            this.chkDI7.Location = new System.Drawing.Point(15, 21);
            this.chkDI7.Name = "chkDI7";
            this.chkDI7.Size = new System.Drawing.Size(82, 16);
            this.chkDI7.TabIndex = 0;
            this.chkDI7.Text = "입력접점 8";
            this.chkDI7.UseVisualStyleBackColor = true;
            // 
            // btnServerMe
            // 
            this.btnServerMe.Location = new System.Drawing.Point(509, 43);
            this.btnServerMe.Name = "btnServerMe";
            this.btnServerMe.Size = new System.Drawing.Size(42, 22);
            this.btnServerMe.TabIndex = 101;
            this.btnServerMe.Text = "Me";
            this.btnServerMe.UseVisualStyleBackColor = true;
            this.btnServerMe.Click += new System.EventHandler(this.btnServerMe_Click);
            // 
            // btnServerLoopBack
            // 
            this.btnServerLoopBack.Location = new System.Drawing.Point(431, 43);
            this.btnServerLoopBack.Name = "btnServerLoopBack";
            this.btnServerLoopBack.Size = new System.Drawing.Size(72, 22);
            this.btnServerLoopBack.TabIndex = 100;
            this.btnServerLoopBack.Text = "LoopBack";
            this.btnServerLoopBack.UseVisualStyleBackColor = true;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(431, 18);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(120, 21);
            this.txtServerIP.TabIndex = 99;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // lblConnChat
            // 
            this.lblConnChat.AutoSize = true;
            this.lblConnChat.Location = new System.Drawing.Point(429, 114);
            this.lblConnChat.Name = "lblConnChat";
            this.lblConnChat.Size = new System.Drawing.Size(74, 12);
            this.lblConnChat.TabIndex = 98;
            this.lblConnChat.Text = "lblConnChat";
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Silver;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Controls.Add(this.lblO);
            this.pnlDraw.Location = new System.Drawing.Point(12, 292);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(411, 253);
            this.pnlDraw.TabIndex = 97;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(115, 37);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(14, 12);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "O";
            // 
            // lblComInfo
            // 
            this.lblComInfo.AutoSize = true;
            this.lblComInfo.Location = new System.Drawing.Point(431, 72);
            this.lblComInfo.Name = "lblComInfo";
            this.lblComInfo.Size = new System.Drawing.Size(65, 12);
            this.lblComInfo.TabIndex = 96;
            this.lblComInfo.Text = "lblComInfo";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(431, 287);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 41);
            this.btnSend.TabIndex = 95;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 265);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(411, 21);
            this.txtSend.TabIndex = 94;
            // 
            // txtDialog
            // 
            this.txtDialog.Location = new System.Drawing.Point(12, 12);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(411, 247);
            this.txtDialog.TabIndex = 93;
            // 
            // lblConnCopy
            // 
            this.lblConnCopy.AutoSize = true;
            this.lblConnCopy.Location = new System.Drawing.Point(429, 130);
            this.lblConnCopy.Name = "lblConnCopy";
            this.lblConnCopy.Size = new System.Drawing.Size(78, 12);
            this.lblConnCopy.TabIndex = 92;
            this.lblConnCopy.Text = "lblConnCopy";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 41);
            this.btnClose.TabIndex = 91;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(431, 197);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 41);
            this.btnConnect.TabIndex = 90;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timConnStatus
            // 
            this.timConnStatus.Enabled = true;
            this.timConnStatus.Tick += new System.EventHandler(this.timConnStatus_Tick);
            // 
            // timGetRcvMsg
            // 
            this.timGetRcvMsg.Enabled = true;
            this.timGetRcvMsg.Tick += new System.EventHandler(this.timGetRcvMsg_Tick);
            // 
            // timAskBits
            // 
            this.timAskBits.Enabled = true;
            this.timAskBits.Tick += new System.EventHandler(this.timAskBits_Tick);
            // 
            // lblConnCopy2
            // 
            this.lblConnCopy2.AutoSize = true;
            this.lblConnCopy2.Location = new System.Drawing.Point(431, 164);
            this.lblConnCopy2.Name = "lblConnCopy2";
            this.lblConnCopy2.Size = new System.Drawing.Size(84, 12);
            this.lblConnCopy2.TabIndex = 107;
            this.lblConnCopy2.Text = "lblConnCopy2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 596);
            this.Controls.Add(this.lblConnCopy2);
            this.Controls.Add(this.lblCommNG);
            this.Controls.Add(this.lblCommOK);
            this.Controls.Add(this.lblConnComm);
            this.Controls.Add(this.btnReadBits);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnServerMe);
            this.Controls.Add(this.btnServerLoopBack);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblConnChat);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.lblComInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.lblConnCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlDraw.ResumeLayout(false);
            this.pnlDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommNG;
        private System.Windows.Forms.Label lblCommOK;
        private System.Windows.Forms.Label lblConnComm;
        private System.Windows.Forms.Button btnReadBits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkDI0;
        private System.Windows.Forms.CheckBox chkDI1;
        private System.Windows.Forms.CheckBox chkDI2;
        private System.Windows.Forms.CheckBox chkDI3;
        private System.Windows.Forms.CheckBox chkDI4;
        private System.Windows.Forms.CheckBox chkDI5;
        private System.Windows.Forms.CheckBox chkDI6;
        private System.Windows.Forms.CheckBox chkDI7;
        private System.Windows.Forms.Button btnServerMe;
        private System.Windows.Forms.Button btnServerLoopBack;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblConnChat;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblComInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Label lblConnCopy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timConnStatus;
        private System.Windows.Forms.Timer timGetRcvMsg;
        private System.Windows.Forms.Timer timAskBits;
        private System.Windows.Forms.Label lblConnCopy2;
    }
}

