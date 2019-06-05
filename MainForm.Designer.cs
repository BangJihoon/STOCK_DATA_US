namespace YOACOMClientCSharp
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAcctList = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGetAccount = new System.Windows.Forms.Button();
            this.btnInitial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserPW = new System.Windows.Forms.TextBox();
            this.txtCertPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBtn = new System.Windows.Forms.Button();
            this.AllBtn = new System.Windows.Forms.RadioButton();
            this.NyseBtn = new System.Windows.Forms.RadioButton();
            this.NasdaqBtn = new System.Windows.Forms.RadioButton();
            this.textbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBTVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBTDebiRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBTDebi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBTCurJuka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBTJongName = new System.Windows.Forms.TextBox();
            this.txtBTJongCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMainLog = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(15, 55);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(360, 26);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "No";
            this.columnHeader13.Width = 35;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "계좌번호";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 152;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "계좌명";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 150;
            // 
            // lvAcctList
            // 
            this.lvAcctList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvAcctList.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lvAcctList.GridLines = true;
            this.lvAcctList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAcctList.Location = new System.Drawing.Point(15, 80);
            this.lvAcctList.Name = "lvAcctList";
            this.lvAcctList.Size = new System.Drawing.Size(360, 122);
            this.lvAcctList.TabIndex = 15;
            this.lvAcctList.UseCompatibleStateImageBehavior = false;
            this.lvAcctList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "No";
            this.columnHeader16.Width = 34;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "계좌번호";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 152;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "계좌명";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lvAcctList);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.btnGetAccount);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " 계좌 ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "주식 종목 초기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetAccount
            // 
            this.btnGetAccount.Enabled = false;
            this.btnGetAccount.Location = new System.Drawing.Point(14, 20);
            this.btnGetAccount.Name = "btnGetAccount";
            this.btnGetAccount.Size = new System.Drawing.Size(143, 28);
            this.btnGetAccount.TabIndex = 9;
            this.btnGetAccount.Text = "계좌 가져오기";
            this.btnGetAccount.UseVisualStyleBackColor = true;
            this.btnGetAccount.Click += new System.EventHandler(this.btnGetAccount_Click);
            // 
            // btnInitial
            // 
            this.btnInitial.Location = new System.Drawing.Point(15, 20);
            this.btnInitial.Name = "btnInitial";
            this.btnInitial.Size = new System.Drawing.Size(215, 28);
            this.btnInitial.TabIndex = 0;
            this.btnInitial.Text = "Yuanta API 모듈 초기화";
            this.btnInitial.UseVisualStyleBackColor = true;
            this.btnInitial.Click += new System.EventHandler(this.btnInitial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "인증서비번";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(96, 60);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(132, 21);
            this.txtUserID.TabIndex = 4;
            this.txtUserID.Text = "gg8820";
            // 
            // txtUserPW
            // 
            this.txtUserPW.Location = new System.Drawing.Point(96, 93);
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.PasswordChar = '●';
            this.txtUserPW.Size = new System.Drawing.Size(132, 21);
            this.txtUserPW.TabIndex = 5;
            this.txtUserPW.Text = "blue12!@";
            // 
            // txtCertPW
            // 
            this.txtCertPW.Location = new System.Drawing.Point(96, 126);
            this.txtCertPW.Name = "txtCertPW";
            this.txtCertPW.PasswordChar = '●';
            this.txtCertPW.Size = new System.Drawing.Size(132, 21);
            this.txtCertPW.TabIndex = 6;
            this.txtCertPW.Text = "server12!@";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(16, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(126, 161);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 28);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtCertPW);
            this.groupBox1.Controls.Add(this.txtUserPW);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInitial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 로그인 ";
            // 
            // tabPanel
            // 
            this.tabPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPanel.Controls.Add(this.tabPage1);
            this.tabPanel.Location = new System.Drawing.Point(12, 220);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(630, 331);
            this.tabPanel.TabIndex = 2;
            this.tabPanel.SelectedIndexChanged += new System.EventHandler(this.tabPanel_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 305);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "기본테스트";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.checkBtn);
            this.panel2.Controls.Add(this.AllBtn);
            this.panel2.Controls.Add(this.NyseBtn);
            this.panel2.Controls.Add(this.NasdaqBtn);
            this.panel2.Controls.Add(this.textbtn);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.txtBTJongCode);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 282);
            this.panel2.TabIndex = 4;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(483, 22);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(79, 45);
            this.checkBtn.TabIndex = 27;
            this.checkBtn.Text = "Data Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // AllBtn
            // 
            this.AllBtn.AutoSize = true;
            this.AllBtn.Checked = true;
            this.AllBtn.Location = new System.Drawing.Point(232, 12);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Size = new System.Drawing.Size(45, 16);
            this.AllBtn.TabIndex = 26;
            this.AllBtn.TabStop = true;
            this.AllBtn.Text = "ALL";
            this.AllBtn.UseVisualStyleBackColor = true;
            this.AllBtn.CheckedChanged += new System.EventHandler(this.AllBtn_CheckedChanged);
            // 
            // NyseBtn
            // 
            this.NyseBtn.AutoSize = true;
            this.NyseBtn.Location = new System.Drawing.Point(232, 57);
            this.NyseBtn.Name = "NyseBtn";
            this.NyseBtn.Size = new System.Drawing.Size(56, 16);
            this.NyseBtn.TabIndex = 25;
            this.NyseBtn.Text = "NYSE";
            this.NyseBtn.UseVisualStyleBackColor = true;
            this.NyseBtn.CheckedChanged += new System.EventHandler(this.NyseBtn_CheckedChanged);
            // 
            // NasdaqBtn
            // 
            this.NasdaqBtn.AutoSize = true;
            this.NasdaqBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NasdaqBtn.Location = new System.Drawing.Point(232, 34);
            this.NasdaqBtn.Name = "NasdaqBtn";
            this.NasdaqBtn.Size = new System.Drawing.Size(79, 17);
            this.NasdaqBtn.TabIndex = 24;
            this.NasdaqBtn.Text = "NASDAQ";
            this.NasdaqBtn.UseVisualStyleBackColor = true;
            this.NasdaqBtn.CheckedChanged += new System.EventHandler(this.NasdaqBtn_CheckedChanged);
            // 
            // textbtn
            // 
            this.textbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.textbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textbtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbtn.Location = new System.Drawing.Point(339, 21);
            this.textbtn.Name = "textbtn";
            this.textbtn.Size = new System.Drawing.Size(109, 46);
            this.textbtn.TabIndex = 23;
            this.textbtn.Text = "START";
            this.textbtn.UseVisualStyleBackColor = false;
            this.textbtn.Click += new System.EventHandler(this.textbtn_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbLog);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtBTVolume);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtBTDebiRate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtBTDebi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBTCurJuka);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtBTJongName);
            this.groupBox4.Location = new System.Drawing.Point(21, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 199);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(267, 20);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(274, 160);
            this.lbLog.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "거래량";
            // 
            // txtBTVolume
            // 
            this.txtBTVolume.Location = new System.Drawing.Point(86, 165);
            this.txtBTVolume.Name = "txtBTVolume";
            this.txtBTVolume.Size = new System.Drawing.Size(154, 21);
            this.txtBTVolume.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "등락률";
            // 
            // txtBTDebiRate
            // 
            this.txtBTDebiRate.Location = new System.Drawing.Point(86, 129);
            this.txtBTDebiRate.Name = "txtBTDebiRate";
            this.txtBTDebiRate.Size = new System.Drawing.Size(154, 21);
            this.txtBTDebiRate.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "전일대비";
            // 
            // txtBTDebi
            // 
            this.txtBTDebi.Location = new System.Drawing.Point(86, 93);
            this.txtBTDebi.Name = "txtBTDebi";
            this.txtBTDebi.Size = new System.Drawing.Size(154, 21);
            this.txtBTDebi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "현재가";
            // 
            // txtBTCurJuka
            // 
            this.txtBTCurJuka.Location = new System.Drawing.Point(86, 58);
            this.txtBTCurJuka.Name = "txtBTCurJuka";
            this.txtBTCurJuka.Size = new System.Drawing.Size(154, 21);
            this.txtBTCurJuka.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "종목명";
            // 
            // txtBTJongName
            // 
            this.txtBTJongName.Location = new System.Drawing.Point(86, 22);
            this.txtBTJongName.Name = "txtBTJongName";
            this.txtBTJongName.Size = new System.Drawing.Size(154, 21);
            this.txtBTJongName.TabIndex = 6;
            // 
            // txtBTJongCode
            // 
            this.txtBTJongCode.Location = new System.Drawing.Point(112, 35);
            this.txtBTJongCode.Name = "txtBTJongCode";
            this.txtBTJongCode.Size = new System.Drawing.Size(100, 21);
            this.txtBTJongCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "주식종목코드";
            // 
            // lbMainLog
            // 
            this.lbMainLog.FormattingEnabled = true;
            this.lbMainLog.ItemHeight = 12;
            this.lbMainLog.Location = new System.Drawing.Point(16, 578);
            this.lbMainLog.Name = "lbMainLog";
            this.lbMainLog.Size = new System.Drawing.Size(626, 256);
            this.lbMainLog.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 855);
            this.Controls.Add(this.lbMainLog);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "유안타 오픈 API 클라이언트(COM용)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader columnHeader13;
        public System.Windows.Forms.ColumnHeader columnHeader14;
        public System.Windows.Forms.ColumnHeader columnHeader15;
        public System.Windows.Forms.ListView lvAcctList;
        public System.Windows.Forms.ColumnHeader columnHeader16;
        public System.Windows.Forms.ColumnHeader columnHeader17;
        public System.Windows.Forms.ColumnHeader columnHeader18;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnGetAccount;
        public System.Windows.Forms.Button btnInitial;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUserID;
        public System.Windows.Forms.TextBox txtUserPW;
        public System.Windows.Forms.TextBox txtCertPW;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TabControl tabPanel;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton NyseBtn;
        private System.Windows.Forms.RadioButton NasdaqBtn;
        public System.Windows.Forms.Button textbtn;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ListBox lbLog;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtBTVolume;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBTDebiRate;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBTDebi;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBTCurJuka;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBTJongName;
        public System.Windows.Forms.TextBox txtBTJongCode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox lbMainLog;
        private System.Windows.Forms.RadioButton AllBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button button1;
    }
}

