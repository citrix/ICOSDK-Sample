namespace SampleProject
{
    partial class ICOTesterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ICOTesterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCPAddress = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHTTPAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.RichTextBox();
            this.grpFarmInfor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.RichTextBox();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpVerInfo = new System.Windows.Forms.GroupBox();
            this.lblICOVer = new System.Windows.Forms.Label();
            this.lblICAVer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IsSeamless = new System.Windows.Forms.CheckBox();
            this.IsEmbedded = new System.Windows.Forms.CheckBox();
            this.btnDisconn1 = new System.Windows.Forms.Button();
            this.btnLogoff1 = new System.Windows.Forms.Button();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLaunchNotepad = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtScaleWidth = new System.Windows.Forms.TextBox();
            this.txtScaleHeight = new System.Windows.Forms.TextBox();
            this.btnScaleSession = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtScalePercent = new System.Windows.Forms.TextBox();
            this.btnScalePercent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.btnWinPosition = new System.Windows.Forms.Button();
            this.GetClientWindowSize = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.WindowTypeCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWinWidth = new System.Windows.Forms.TextBox();
            this.txtWinHeight = new System.Windows.Forms.TextBox();
            this.btnWindowSize = new System.Windows.Forms.Button();
            this.GetWinSize = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.ClearEventWindow = new System.Windows.Forms.Button();
            this.axICAClient1 = new AxWFICALib.AxICAClient();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpFarmInfor.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            this.grpVerInfo.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axICAClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCP Address:";
            // 
            // txtTCPAddress
            // 
            this.txtTCPAddress.Location = new System.Drawing.Point(115, 13);
            this.txtTCPAddress.Name = "txtTCPAddress";
            this.txtTCPAddress.Size = new System.Drawing.Size(149, 23);
            this.txtTCPAddress.TabIndex = 1;
            this.txtTCPAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HTTP Address:";
            // 
            // txtHTTPAddress
            // 
            this.txtHTTPAddress.Location = new System.Drawing.Point(115, 54);
            this.txtHTTPAddress.Name = "txtHTTPAddress";
            this.txtHTTPAddress.Size = new System.Drawing.Size(149, 23);
            this.txtHTTPAddress.TabIndex = 3;
            this.txtHTTPAddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "App Name:";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(115, 92);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(149, 23);
            this.txtAppName.TabIndex = 5;
            this.txtAppName.Text = "";
            // 
            // grpFarmInfor
            // 
            this.grpFarmInfor.Controls.Add(this.txtAppName);
            this.grpFarmInfor.Controls.Add(this.label3);
            this.grpFarmInfor.Controls.Add(this.txtHTTPAddress);
            this.grpFarmInfor.Controls.Add(this.label2);
            this.grpFarmInfor.Controls.Add(this.txtTCPAddress);
            this.grpFarmInfor.Controls.Add(this.label1);
            this.grpFarmInfor.Location = new System.Drawing.Point(12, 12);
            this.grpFarmInfor.Name = "grpFarmInfor";
            this.grpFarmInfor.Size = new System.Drawing.Size(279, 137);
            this.grpFarmInfor.TabIndex = 3;
            this.grpFarmInfor.TabStop = false;
            this.grpFarmInfor.Text = "Farm Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(115, 92);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(149, 23);
            this.txtDomain.TabIndex = 5;
            this.txtDomain.Text = "";
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.textBox2);
            this.grpUserInfo.Controls.Add(this.txtDomain);
            this.grpUserInfo.Controls.Add(this.label4);
            this.grpUserInfo.Controls.Add(this.label5);
            this.grpUserInfo.Controls.Add(this.txtUserName);
            this.grpUserInfo.Controls.Add(this.label6);
            this.grpUserInfo.Location = new System.Drawing.Point(321, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(279, 137);
            this.grpUserInfo.TabIndex = 4;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Information";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // grpVerInfo
            // 
            this.grpVerInfo.Controls.Add(this.lblICOVer);
            this.grpVerInfo.Controls.Add(this.lblICAVer);
            this.grpVerInfo.Controls.Add(this.label8);
            this.grpVerInfo.Controls.Add(this.label9);
            this.grpVerInfo.Location = new System.Drawing.Point(849, 47);
            this.grpVerInfo.Name = "grpVerInfo";
            this.grpVerInfo.Size = new System.Drawing.Size(193, 102);
            this.grpVerInfo.TabIndex = 7;
            this.grpVerInfo.TabStop = false;
            this.grpVerInfo.Text = "Version Information:";
            // 
            // lblICOVer
            // 
            this.lblICOVer.AutoSize = true;
            this.lblICOVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICOVer.ForeColor = System.Drawing.Color.Navy;
            this.lblICOVer.Location = new System.Drawing.Point(106, 19);
            this.lblICOVer.Name = "lblICOVer";
            this.lblICOVer.Size = new System.Drawing.Size(47, 13);
            this.lblICOVer.TabIndex = 4;
            this.lblICOVer.Text = "ICOVer";
            // 
            // lblICAVer
            // 
            this.lblICAVer.AutoSize = true;
            this.lblICAVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICAVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblICAVer.Location = new System.Drawing.Point(106, 45);
            this.lblICAVer.Name = "lblICAVer";
            this.lblICAVer.Size = new System.Drawing.Size(46, 13);
            this.lblICAVer.TabIndex = 3;
            this.lblICAVer.Text = "ICAVer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ICA Client Version:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ICO Version:";
            // 
            // IsSeamless
            // 
            this.IsSeamless.AutoSize = true;
            this.IsSeamless.Location = new System.Drawing.Point(980, 12);
            this.IsSeamless.Name = "IsSeamless";
            this.IsSeamless.Size = new System.Drawing.Size(71, 17);
            this.IsSeamless.TabIndex = 12;
            this.IsSeamless.Text = "Seamless";
            this.IsSeamless.UseVisualStyleBackColor = true;
            // 
            // IsEmbedded
            // 
            this.IsEmbedded.AutoSize = true;
            this.IsEmbedded.Checked = true;
            this.IsEmbedded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsEmbedded.Location = new System.Drawing.Point(849, 12);
            this.IsEmbedded.Name = "IsEmbedded";
            this.IsEmbedded.Size = new System.Drawing.Size(77, 17);
            this.IsEmbedded.TabIndex = 11;
            this.IsEmbedded.Text = "Embedded";
            this.IsEmbedded.UseVisualStyleBackColor = true;
            // 
            // btnDisconn1
            // 
            this.btnDisconn1.Location = new System.Drawing.Point(209, 20);
            this.btnDisconn1.Name = "btnDisconn1";
            this.btnDisconn1.Size = new System.Drawing.Size(123, 23);
            this.btnDisconn1.TabIndex = 9;
            this.btnDisconn1.Text = "Disconnect";
            this.btnDisconn1.UseVisualStyleBackColor = true;
            this.btnDisconn1.Click += new System.EventHandler(this.btnDisconn1_Click);
            // 
            // btnLogoff1
            // 
            this.btnLogoff1.Location = new System.Drawing.Point(394, 20);
            this.btnLogoff1.Name = "btnLogoff1";
            this.btnLogoff1.Size = new System.Drawing.Size(123, 23);
            this.btnLogoff1.TabIndex = 13;
            this.btnLogoff1.Text = "Logoff";
            this.btnLogoff1.UseVisualStyleBackColor = true;
            this.btnLogoff1.Click += new System.EventHandler(this.btnLogoff1_Click);
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(26, 20);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(123, 23);
            this.btnConnect1.TabIndex = 1;
            this.btnConnect1.Text = "Connect";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 155);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1039, 84);
            this.tabControl2.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLaunchNotepad);
            this.tabPage2.Controls.Add(this.btnConnect1);
            this.tabPage2.Controls.Add(this.btnDisconn1);
            this.tabPage2.Controls.Add(this.btnLogoff1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 58);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Connect Tests";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLaunchNotepad
            // 
            this.btnLaunchNotepad.Location = new System.Drawing.Point(577, 20);
            this.btnLaunchNotepad.Name = "btnLaunchNotepad";
            this.btnLaunchNotepad.Size = new System.Drawing.Size(123, 23);
            this.btnLaunchNotepad.TabIndex = 14;
            this.btnLaunchNotepad.Text = "LaunchNotepad";
            this.btnLaunchNotepad.UseVisualStyleBackColor = true;
            this.btnLaunchNotepad.Click += new System.EventHandler(this.btnLaunchNotepad_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 19;
            // 
            // txtScaleWidth
            // 
            this.txtScaleWidth.Location = new System.Drawing.Point(77, 16);
            this.txtScaleWidth.Name = "txtScaleWidth";
            this.txtScaleWidth.Size = new System.Drawing.Size(35, 20);
            this.txtScaleWidth.TabIndex = 20;
            // 
            // txtScaleHeight
            // 
            this.txtScaleHeight.Location = new System.Drawing.Point(191, 16);
            this.txtScaleHeight.Name = "txtScaleHeight";
            this.txtScaleHeight.Size = new System.Drawing.Size(35, 20);
            this.txtScaleHeight.TabIndex = 21;
            // 
            // btnScaleSession
            // 
            this.btnScaleSession.Location = new System.Drawing.Point(6, 42);
            this.btnScaleSession.Name = "btnScaleSession";
            this.btnScaleSession.Size = new System.Drawing.Size(220, 25);
            this.btnScaleSession.TabIndex = 22;
            this.btnScaleSession.Text = "Scale Session Size";
            this.btnScaleSession.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 18;
            // 
            // txtScalePercent
            // 
            this.txtScalePercent.Location = new System.Drawing.Point(95, 16);
            this.txtScalePercent.Name = "txtScalePercent";
            this.txtScalePercent.Size = new System.Drawing.Size(35, 20);
            this.txtScalePercent.TabIndex = 20;
            // 
            // btnScalePercent
            // 
            this.btnScalePercent.Location = new System.Drawing.Point(6, 42);
            this.btnScalePercent.Name = "btnScalePercent";
            this.btnScalePercent.Size = new System.Drawing.Size(124, 25);
            this.btnScalePercent.TabIndex = 22;
            this.btnScalePercent.Text = "Scale Session Percent";
            this.btnScalePercent.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 19;
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(74, 46);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(35, 20);
            this.txtXPos.TabIndex = 20;
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(189, 46);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(35, 20);
            this.txtYPos.TabIndex = 21;
            // 
            // btnWinPosition
            // 
            this.btnWinPosition.Location = new System.Drawing.Point(231, 43);
            this.btnWinPosition.Name = "btnWinPosition";
            this.btnWinPosition.Size = new System.Drawing.Size(124, 25);
            this.btnWinPosition.TabIndex = 22;
            this.btnWinPosition.Text = "Set Window Position";
            this.btnWinPosition.UseVisualStyleBackColor = true;
            // 
            // GetClientWindowSize
            // 
            this.GetClientWindowSize.Location = new System.Drawing.Point(361, 43);
            this.GetClientWindowSize.Name = "GetClientWindowSize";
            this.GetClientWindowSize.Size = new System.Drawing.Size(116, 25);
            this.GetClientWindowSize.TabIndex = 20;
            this.GetClientWindowSize.Text = "GetWindowPosition";
            this.GetClientWindowSize.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 23;
            // 
            // WindowTypeCombo
            // 
            this.WindowTypeCombo.FormattingEnabled = true;
            this.WindowTypeCombo.Items.AddRange(new object[] {
            "ICO Window",
            "Control Window",
            "Client Window",
            "Container Window"});
            this.WindowTypeCombo.Location = new System.Drawing.Point(108, 18);
            this.WindowTypeCombo.Name = "WindowTypeCombo";
            this.WindowTypeCombo.Size = new System.Drawing.Size(223, 21);
            this.WindowTypeCombo.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            // 
            // txtWinWidth
            // 
            this.txtWinWidth.Location = new System.Drawing.Point(44, 16);
            this.txtWinWidth.Name = "txtWinWidth";
            this.txtWinWidth.Size = new System.Drawing.Size(45, 20);
            this.txtWinWidth.TabIndex = 20;
            // 
            // txtWinHeight
            // 
            this.txtWinHeight.Location = new System.Drawing.Point(44, 42);
            this.txtWinHeight.Name = "txtWinHeight";
            this.txtWinHeight.Size = new System.Drawing.Size(45, 20);
            this.txtWinHeight.TabIndex = 21;
            // 
            // btnWindowSize
            // 
            this.btnWindowSize.Location = new System.Drawing.Point(100, 13);
            this.btnWindowSize.Name = "btnWindowSize";
            this.btnWindowSize.Size = new System.Drawing.Size(167, 25);
            this.btnWindowSize.TabIndex = 23;
            this.btnWindowSize.Text = "Set Window Size";
            this.btnWindowSize.UseVisualStyleBackColor = true;
            // 
            // GetWinSize
            // 
            this.GetWinSize.Location = new System.Drawing.Point(100, 41);
            this.GetWinSize.Name = "GetWinSize";
            this.GetWinSize.Size = new System.Drawing.Size(167, 25);
            this.GetWinSize.TabIndex = 24;
            this.GetWinSize.Text = "Get Window Size";
            this.GetWinSize.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 664);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(914, 69);
            this.lstResults.TabIndex = 16;
            // 
            // ClearEventWindow
            // 
            this.ClearEventWindow.Location = new System.Drawing.Point(938, 685);
            this.ClearEventWindow.Name = "ClearEventWindow";
            this.ClearEventWindow.Size = new System.Drawing.Size(113, 27);
            this.ClearEventWindow.TabIndex = 25;
            this.ClearEventWindow.Text = "ClearResultsWindow";
            this.ClearEventWindow.UseVisualStyleBackColor = true;
            this.ClearEventWindow.Click += new System.EventHandler(this.ClearEventWindow_Click);
            // 
            // axICAClient1
            // 
            this.axICAClient1.Enabled = true;
            this.axICAClient1.Location = new System.Drawing.Point(12, 245);
            this.axICAClient1.Name = "axICAClient1";
            this.axICAClient1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axICAClient1.OcxState")));
            this.axICAClient1.Size = new System.Drawing.Size(1039, 413);
            this.axICAClient1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Launch ICA file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 26;
            // 
            // ICOTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1063, 736);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearEventWindow);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.IsSeamless);
            this.Controls.Add(this.IsEmbedded);
            this.Controls.Add(this.grpVerInfo);
            this.Controls.Add(this.grpUserInfo);
            this.Controls.Add(this.grpFarmInfor);
            this.Controls.Add(this.axICAClient1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ICOTesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICO Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFarmInfor.ResumeLayout(false);
            this.grpFarmInfor.PerformLayout();
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.grpVerInfo.ResumeLayout(false);
            this.grpVerInfo.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axICAClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTCPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtHTTPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtAppName;
        private System.Windows.Forms.GroupBox grpFarmInfor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDomain;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.GroupBox grpVerInfo;
        private System.Windows.Forms.Label lblICOVer;
        private System.Windows.Forms.Label lblICAVer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox IsSeamless;
        private System.Windows.Forms.CheckBox IsEmbedded;
        private AxWFICALib.AxICAClient axICAClient1;
        private System.Windows.Forms.Button btnDisconn1;
        private System.Windows.Forms.Button btnLogoff1;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtScaleWidth;
        private System.Windows.Forms.TextBox txtScaleHeight;
        private System.Windows.Forms.Button btnScaleSession;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtScalePercent;
        private System.Windows.Forms.Button btnScalePercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.Button btnWinPosition;
        private System.Windows.Forms.Button GetClientWindowSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox WindowTypeCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWinWidth;
        private System.Windows.Forms.TextBox txtWinHeight;
        private System.Windows.Forms.Button btnWindowSize;
        private System.Windows.Forms.Button GetWinSize;
        private System.Windows.Forms.Button btnLaunchNotepad;
        public System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button ClearEventWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

  


    }
}

