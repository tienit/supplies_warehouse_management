namespace VKTIM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_ChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_UserGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lbl_dis_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dis_server = new System.Windows.Forms.ToolStripStatusLabel();
            this.ddb_user = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddb_user_change_pass = new System.Windows.Forms.ToolStripMenuItem();
            this.ddb_user_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ddb_user_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ddb_icon_warning = new System.Windows.Forms.ToolStripDropDownButton();
            this.lbl_dis_update_now = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_dis_notify = new VKTIM.UserControl.MarqueeLabel();
            this.hlp_ComOperation = new System.Windows.Forms.HelpProvider();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.Controls.Add(this.lbl_dis_notify);
            this.pn_Form.Controls.Add(this.statusStripMain);
            this.pn_Form.Controls.Add(this.menuStripMain);
            this.pn_Form.Size = new System.Drawing.Size(1098, 650);
            this.pn_Form.Controls.SetChildIndex(this.menuStripMain, 0);
            this.pn_Form.Controls.SetChildIndex(this.statusStripMain, 0);
            this.pn_Form.Controls.SetChildIndex(this.lbl_dis_notify, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(911, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWarehouse,
            this.mnuSystem,
            this.mnuReport,
            this.mnuManagement,
            this.mnuHelp});
            this.menuStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStripMain.Location = new System.Drawing.Point(0, 45);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1098, 40);
            this.menuStripMain.TabIndex = 58;
            // 
            // mnuFile
            // 
            this.mnuFile.Checked = true;
            this.mnuFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Login,
            this.mnuFile_ChangePass,
            this.mnuFile_Logout,
            this.toolStripSeparator1,
            this.mnuFile_Connection,
            this.toolStripSeparator2,
            this.mnuFile_Exit});
            this.mnuFile.ForeColor = System.Drawing.Color.White;
            this.mnuFile.Image = global::VKTIM.Properties.Resources.mnuFileWhite32;
            this.mnuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(78, 36);
            this.mnuFile.Text = "&File";
            // 
            // mnuFile_Login
            // 
            this.mnuFile_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuFile_Login.Image = global::VKTIM.Properties.Resources.e_icon_login_24;
            this.mnuFile_Login.Name = "mnuFile_Login";
            this.mnuFile_Login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuFile_Login.Size = new System.Drawing.Size(252, 24);
            this.mnuFile_Login.Text = "Login";
            this.mnuFile_Login.Click += new System.EventHandler(this.mnuFile_Login_Click);
            // 
            // mnuFile_ChangePass
            // 
            this.mnuFile_ChangePass.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuFile_ChangePass.Image = global::VKTIM.Properties.Resources.e_icon_changepass_24;
            this.mnuFile_ChangePass.Name = "mnuFile_ChangePass";
            this.mnuFile_ChangePass.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuFile_ChangePass.Size = new System.Drawing.Size(252, 24);
            this.mnuFile_ChangePass.Text = "Change Password";
            this.mnuFile_ChangePass.Click += new System.EventHandler(this.mnuFile_ChangePass_Click);
            // 
            // mnuFile_Logout
            // 
            this.mnuFile_Logout.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuFile_Logout.Image = global::VKTIM.Properties.Resources.e_icon_logout_24;
            this.mnuFile_Logout.Name = "mnuFile_Logout";
            this.mnuFile_Logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFile_Logout.Size = new System.Drawing.Size(252, 24);
            this.mnuFile_Logout.Text = "Logout";
            this.mnuFile_Logout.Click += new System.EventHandler(this.mnuFile_Logout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuFile_Connection
            // 
            this.mnuFile_Connection.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuFile_Connection.Image = global::VKTIM.Properties.Resources.e_icon_connection_24;
            this.mnuFile_Connection.Name = "mnuFile_Connection";
            this.mnuFile_Connection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuFile_Connection.Size = new System.Drawing.Size(252, 24);
            this.mnuFile_Connection.Text = "Connection Setting";
            this.mnuFile_Connection.Click += new System.EventHandler(this.mnuFile_Connection_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuFile_Exit.Image = global::VKTIM.Properties.Resources.e_icon_exit_24;
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuFile_Exit.Size = new System.Drawing.Size(252, 24);
            this.mnuFile_Exit.Text = "Exit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuWarehouse
            // 
            this.mnuWarehouse.ForeColor = System.Drawing.Color.White;
            this.mnuWarehouse.Image = global::VKTIM.Properties.Resources.mnuWarehouseWhite32;
            this.mnuWarehouse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuWarehouse.Name = "mnuWarehouse";
            this.mnuWarehouse.Size = new System.Drawing.Size(132, 36);
            this.mnuWarehouse.Text = "&Warehouse";
            // 
            // mnuSystem
            // 
            this.mnuSystem.ForeColor = System.Drawing.Color.White;
            this.mnuSystem.Image = global::VKTIM.Properties.Resources.mnuSystemWhite32;
            this.mnuSystem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(105, 36);
            this.mnuSystem.Text = "&System";
            // 
            // mnuReport
            // 
            this.mnuReport.ForeColor = System.Drawing.Color.White;
            this.mnuReport.Image = global::VKTIM.Properties.Resources.mnuReportWhite32;
            this.mnuReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(101, 36);
            this.mnuReport.Text = "Report";
            // 
            // mnuManagement
            // 
            this.mnuManagement.ForeColor = System.Drawing.Color.White;
            this.mnuManagement.Image = global::VKTIM.Properties.Resources.mnuManagementWhite32;
            this.mnuManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuManagement.Name = "mnuManagement";
            this.mnuManagement.Size = new System.Drawing.Size(146, 36);
            this.mnuManagement.Text = "&Management";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_UserGuide,
            this.mnuHelp_About,
            this.mnuHelp_Update});
            this.mnuHelp.ForeColor = System.Drawing.Color.White;
            this.mnuHelp.Image = global::VKTIM.Properties.Resources.mnuHelpWhite32;
            this.mnuHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(86, 36);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp_UserGuide
            // 
            this.mnuHelp_UserGuide.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuHelp_UserGuide.Image = global::VKTIM.Properties.Resources.e_icon_userguide_24;
            this.mnuHelp_UserGuide.Name = "mnuHelp_UserGuide";
            this.mnuHelp_UserGuide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp_UserGuide.Size = new System.Drawing.Size(175, 24);
            this.mnuHelp_UserGuide.Text = "User Guide";
            this.mnuHelp_UserGuide.Click += new System.EventHandler(this.mnuHelp_UserGuide_Click);
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuHelp_About.Image = global::VKTIM.Properties.Resources.e_icon_about_24;
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuHelp_About.Size = new System.Drawing.Size(175, 24);
            this.mnuHelp_About.Text = "About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // mnuHelp_Update
            // 
            this.mnuHelp_Update.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mnuHelp_Update.Image = global::VKTIM.Properties.Resources.e_icon_update_24;
            this.mnuHelp_Update.Name = "mnuHelp_Update";
            this.mnuHelp_Update.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuHelp_Update.Size = new System.Drawing.Size(175, 24);
            this.mnuHelp_Update.Text = "Update";
            this.mnuHelp_Update.Click += new System.EventHandler(this.mnuHelp_Update_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_dis_version,
            this.lbl_dis_server,
            this.ddb_user,
            this.ddb_icon_warning,
            this.lbl_dis_update_now});
            this.statusStripMain.Location = new System.Drawing.Point(0, 628);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1098, 22);
            this.statusStripMain.TabIndex = 62;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lbl_dis_version
            // 
            this.lbl_dis_version.Name = "lbl_dis_version";
            this.lbl_dis_version.Size = new System.Drawing.Size(45, 17);
            this.lbl_dis_version.Text = "Version";
            // 
            // lbl_dis_server
            // 
            this.lbl_dis_server.Name = "lbl_dis_server";
            this.lbl_dis_server.Size = new System.Drawing.Size(39, 17);
            this.lbl_dis_server.Text = "Server";
            this.lbl_dis_server.Visible = false;
            // 
            // ddb_user
            // 
            this.ddb_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ddb_user.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddb_user_change_pass,
            this.ddb_user_logout,
            this.toolStripSeparator3,
            this.ddb_user_exit});
            this.ddb_user.Image = global::VKTIM.Properties.Resources.e_icon_user2_24;
            this.ddb_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddb_user.Name = "ddb_user";
            this.ddb_user.Size = new System.Drawing.Size(29, 20);
            this.ddb_user.Text = "toolStripDropDownButton1";
            this.ddb_user.Visible = false;
            // 
            // ddb_user_change_pass
            // 
            this.ddb_user_change_pass.Name = "ddb_user_change_pass";
            this.ddb_user_change_pass.Size = new System.Drawing.Size(168, 22);
            this.ddb_user_change_pass.Text = "Change Password";
            this.ddb_user_change_pass.Click += new System.EventHandler(this.ddb_user_change_pass_Click);
            // 
            // ddb_user_logout
            // 
            this.ddb_user_logout.Name = "ddb_user_logout";
            this.ddb_user_logout.Size = new System.Drawing.Size(168, 22);
            this.ddb_user_logout.Text = "Log Out";
            this.ddb_user_logout.Click += new System.EventHandler(this.ddb_user_logout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // ddb_user_exit
            // 
            this.ddb_user_exit.Name = "ddb_user_exit";
            this.ddb_user_exit.Size = new System.Drawing.Size(168, 22);
            this.ddb_user_exit.Text = "Exit";
            this.ddb_user_exit.Click += new System.EventHandler(this.ddb_user_exit_Click);
            // 
            // ddb_icon_warning
            // 
            this.ddb_icon_warning.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ddb_icon_warning.Image = global::VKTIM.Properties.Resources.e_icon_warning_24;
            this.ddb_icon_warning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddb_icon_warning.Name = "ddb_icon_warning";
            this.ddb_icon_warning.Size = new System.Drawing.Size(29, 20);
            this.ddb_icon_warning.Text = "toolStripDropDownButton1";
            this.ddb_icon_warning.Visible = false;
            // 
            // lbl_dis_update_now
            // 
            this.lbl_dis_update_now.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_update_now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lbl_dis_update_now.Name = "lbl_dis_update_now";
            this.lbl_dis_update_now.Size = new System.Drawing.Size(81, 17);
            this.lbl_dis_update_now.Text = "Update Now!";
            this.lbl_dis_update_now.Visible = false;
            // 
            // lbl_dis_notify
            // 
            this.lbl_dis_notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dis_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lbl_dis_notify.Direction = "2";
            this.lbl_dis_notify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_dis_notify.Location = new System.Drawing.Point(629, 630);
            this.lbl_dis_notify.Name = "lbl_dis_notify";
            this.lbl_dis_notify.Size = new System.Drawing.Size(459, 18);
            this.lbl_dis_notify.TabIndex = 63;
            this.lbl_dis_notify.Text = "Thông báo";
            this.lbl_dis_notify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_dis_notify.UseCompatibleTextRendering = true;
            // 
            // hlp_ComOperation
            // 
            this.hlp_ComOperation.HelpNamespace = "Help\\vktim_help.chm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 666);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Is_Show_Help = true;
            this.Is_Show_Maximized = true;
            this.Is_Show_Minimized = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.MinimumSize = new System.Drawing.Size(735, 500);
            this.Name = "frmMain";
            this.Text = "Supplies Warehouse Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pn_Form.ResumeLayout(false);
            this.pn_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Login;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_ChangePass;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Connection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuWarehouse;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_UserGuide;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Update;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dis_version;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dis_server;
        private System.Windows.Forms.ToolStripDropDownButton ddb_user;
        private System.Windows.Forms.ToolStripMenuItem ddb_user_change_pass;
        private System.Windows.Forms.ToolStripMenuItem ddb_user_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ddb_user_exit;
        private System.Windows.Forms.ToolStripDropDownButton ddb_icon_warning;
        private System.Windows.Forms.ToolStripStatusLabel lbl_dis_update_now;
        private UserControl.MarqueeLabel lbl_dis_notify;
        private System.Windows.Forms.HelpProvider hlp_ComOperation;
    }
}

