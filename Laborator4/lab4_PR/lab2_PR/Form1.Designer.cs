namespace lab2_PR
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCompose = new System.Windows.Forms.TabPage();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonClearMsg = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSMTP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbToName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFromName = new System.Windows.Forms.TextBox();
            this.tbMainPassword = new System.Windows.Forms.TextBox();
            this.tbMainUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageRead = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPopPort = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPop3 = new System.Windows.Forms.TextBox();
            this.tbPopPassword = new System.Windows.Forms.TextBox();
            this.tbPopUsername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCompose.SuspendLayout();
            this.tabPageRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 255);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(207, 288);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(207, 323);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(192, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 30);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLoginError
            // 
            this.labelLoginError.AutoSize = true;
            this.labelLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(90, 389);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(315, 16);
            this.labelLoginError.TabIndex = 6;
            this.labelLoginError.Text = "That combinations of Email & Password doesn\'t exist!";
            this.labelLoginError.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelLoginError);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.tbEmail);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(464, 439);
            this.panelLogin.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(464, 442);
            this.panelMain.TabIndex = 7;
            this.panelMain.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCompose);
            this.tabControl1.Controls.Add(this.tabPageRead);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCompose
            // 
            this.tabPageCompose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCompose.Controls.Add(this.labelSuccess);
            this.tabPageCompose.Controls.Add(this.tbMessage);
            this.tabPageCompose.Controls.Add(this.tbSubject);
            this.tabPageCompose.Controls.Add(this.label9);
            this.tabPageCompose.Controls.Add(this.label8);
            this.tabPageCompose.Controls.Add(this.tbPort);
            this.tabPageCompose.Controls.Add(this.label6);
            this.tabPageCompose.Controls.Add(this.buttonClearMsg);
            this.tabPageCompose.Controls.Add(this.buttonSend);
            this.tabPageCompose.Controls.Add(this.label3);
            this.tabPageCompose.Controls.Add(this.tbSMTP);
            this.tabPageCompose.Controls.Add(this.label10);
            this.tabPageCompose.Controls.Add(this.tbToName);
            this.tabPageCompose.Controls.Add(this.label7);
            this.tabPageCompose.Controls.Add(this.tbFromName);
            this.tabPageCompose.Controls.Add(this.tbMainPassword);
            this.tabPageCompose.Controls.Add(this.tbMainUsername);
            this.tabPageCompose.Controls.Add(this.label5);
            this.tabPageCompose.Controls.Add(this.label4);
            this.tabPageCompose.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompose.Name = "tabPageCompose";
            this.tabPageCompose.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompose.Size = new System.Drawing.Size(456, 416);
            this.tabPageCompose.TabIndex = 0;
            this.tabPageCompose.Text = "Compose";
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSuccess.Location = new System.Drawing.Point(185, 394);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(98, 16);
            this.labelSuccess.TabIndex = 40;
            this.labelSuccess.Text = "Message Sent!";
            this.labelSuccess.Visible = false;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(0, 182);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(456, 235);
            this.tbMessage.TabIndex = 41;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(71, 134);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(298, 20);
            this.tbSubject.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Subject:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(309, 6);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(60, 20);
            this.tbPort.TabIndex = 36;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Message:";
            // 
            // buttonClearMsg
            // 
            this.buttonClearMsg.Location = new System.Drawing.Point(375, 33);
            this.buttonClearMsg.Name = "buttonClearMsg";
            this.buttonClearMsg.Size = new System.Drawing.Size(75, 23);
            this.buttonClearMsg.TabIndex = 34;
            this.buttonClearMsg.Text = "Clear Msg";
            this.buttonClearMsg.UseVisualStyleBackColor = true;
            this.buttonClearMsg.Click += new System.EventHandler(this.buttonClearMsg_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(375, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 33;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "SMTP:";
            // 
            // tbSMTP
            // 
            this.tbSMTP.Location = new System.Drawing.Point(71, 6);
            this.tbSMTP.Name = "tbSMTP";
            this.tbSMTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSMTP.Size = new System.Drawing.Size(191, 20);
            this.tbSMTP.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "To:";
            // 
            // tbToName
            // 
            this.tbToName.Location = new System.Drawing.Point(71, 110);
            this.tbToName.Name = "tbToName";
            this.tbToName.Size = new System.Drawing.Size(298, 20);
            this.tbToName.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "From:";
            // 
            // tbFromName
            // 
            this.tbFromName.Location = new System.Drawing.Point(71, 84);
            this.tbFromName.Name = "tbFromName";
            this.tbFromName.Size = new System.Drawing.Size(298, 20);
            this.tbFromName.TabIndex = 22;
            // 
            // tbMainPassword
            // 
            this.tbMainPassword.Location = new System.Drawing.Point(71, 58);
            this.tbMainPassword.Name = "tbMainPassword";
            this.tbMainPassword.PasswordChar = '*';
            this.tbMainPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMainPassword.Size = new System.Drawing.Size(298, 20);
            this.tbMainPassword.TabIndex = 19;
            // 
            // tbMainUsername
            // 
            this.tbMainUsername.Location = new System.Drawing.Point(71, 32);
            this.tbMainUsername.Name = "tbMainUsername";
            this.tbMainUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMainUsername.Size = new System.Drawing.Size(298, 20);
            this.tbMainUsername.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Username:";
            // 
            // tabPageRead
            // 
            this.tabPageRead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageRead.Controls.Add(this.dataGridView);
            this.tabPageRead.Controls.Add(this.buttonCheck);
            this.tabPageRead.Controls.Add(this.label11);
            this.tabPageRead.Controls.Add(this.tbPopPort);
            this.tabPageRead.Controls.Add(this.label12);
            this.tabPageRead.Controls.Add(this.tbPop3);
            this.tabPageRead.Controls.Add(this.tbPopPassword);
            this.tabPageRead.Controls.Add(this.tbPopUsername);
            this.tabPageRead.Controls.Add(this.label13);
            this.tabPageRead.Controls.Add(this.label14);
            this.tabPageRead.Location = new System.Drawing.Point(4, 22);
            this.tabPageRead.Name = "tabPageRead";
            this.tabPageRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRead.Size = new System.Drawing.Size(456, 416);
            this.tabPageRead.TabIndex = 1;
            this.tabPageRead.Text = "Read";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnSubject,
            this.ColumnFrom,
            this.ColumnDate});
            this.dataGridView.Location = new System.Drawing.Point(6, 84);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(444, 323);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 30;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnFrom
            // 
            this.ColumnFrom.HeaderText = "From";
            this.ColumnFrom.Name = "ColumnFrom";
            this.ColumnFrom.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 152;
            // 
            // buttonCheck
            // 
            this.buttonCheck.AutoEllipsis = true;
            this.buttonCheck.Location = new System.Drawing.Point(375, 4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 46;
            this.buttonCheck.Text = "Check mail";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Port:";
            // 
            // tbPopPort
            // 
            this.tbPopPort.Location = new System.Drawing.Point(309, 6);
            this.tbPopPort.Name = "tbPopPort";
            this.tbPopPort.Size = new System.Drawing.Size(60, 20);
            this.tbPopPort.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "POP3:";
            // 
            // tbPop3
            // 
            this.tbPop3.Location = new System.Drawing.Point(71, 6);
            this.tbPop3.Name = "tbPop3";
            this.tbPop3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPop3.Size = new System.Drawing.Size(191, 20);
            this.tbPop3.TabIndex = 42;
            // 
            // tbPopPassword
            // 
            this.tbPopPassword.Location = new System.Drawing.Point(71, 58);
            this.tbPopPassword.Name = "tbPopPassword";
            this.tbPopPassword.PasswordChar = '*';
            this.tbPopPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPopPassword.Size = new System.Drawing.Size(298, 20);
            this.tbPopPassword.TabIndex = 41;
            // 
            // tbPopUsername
            // 
            this.tbPopUsername.Location = new System.Drawing.Point(71, 32);
            this.tbPopUsername.Name = "tbPopUsername";
            this.tbPopUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPopUsername.Size = new System.Drawing.Size(298, 20);
            this.tbPopUsername.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Password:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Username:";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 640);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCompose.ResumeLayout(false);
            this.tabPageCompose.PerformLayout();
            this.tabPageRead.ResumeLayout(false);
            this.tabPageRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLoginError;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCompose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbToName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFromName;
        private System.Windows.Forms.TextBox tbMainPassword;
        private System.Windows.Forms.TextBox tbMainUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSMTP;
        private System.Windows.Forms.Button buttonClearMsg;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPopPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPop3;
        private System.Windows.Forms.TextBox tbPopPassword;
        private System.Windows.Forms.TextBox tbPopUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;

    }
}

