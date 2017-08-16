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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuTop = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pn_Pinned_Title = new System.Windows.Forms.Panel();
            this.btn_screen_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_screen_back = new System.Windows.Forms.Button();
            this.lbl_dis_CURRENT_FORM_TITLE = new System.Windows.Forms.Label();
            this.pn_Main_Content = new System.Windows.Forms.Panel();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.pn_Pinned_Title.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Form
            // 
            this.pn_Form.BackColor = System.Drawing.Color.White;
            this.pn_Form.Controls.Add(this.pn_Main_Content);
            this.pn_Form.Controls.Add(this.pn_Pinned_Title);
            this.pn_Form.Controls.Add(this.menuStripMain);
            this.pn_Form.Size = new System.Drawing.Size(1098, 640);
            this.pn_Form.Controls.SetChildIndex(this.menuStripMain, 0);
            this.pn_Form.Controls.SetChildIndex(this.pn_Pinned_Title, 0);
            this.pn_Form.Controls.SetChildIndex(this.pn_Main_Content, 0);
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.Size = new System.Drawing.Size(911, 37);
            this.lbl_FormTitle.Text = "";
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTop,
            this.mnuFile,
            this.mnuWarehouse,
            this.mnuSystem,
            this.mnuReport,
            this.mnuManagement,
            this.mnuHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 45);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(170, 595);
            this.menuStripMain.TabIndex = 63;
            // 
            // mnuTop
            // 
            this.mnuTop.AutoSize = false;
            this.mnuTop.Image = global::VKTIM.Properties.Resources.e_icon_top_collapse;
            this.mnuTop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Padding = new System.Windows.Forms.Padding(5);
            this.mnuTop.Size = new System.Drawing.Size(160, 24);
            this.mnuTop.Click += new System.EventHandler(this.mnuTop_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.AutoSize = false;
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
            this.mnuFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Padding = new System.Windows.Forms.Padding(5);
            this.mnuFile.Size = new System.Drawing.Size(160, 68);
            this.mnuFile.DropDownClosed += new System.EventHandler(this.mnuFile_DropDownClosed);
            this.mnuFile.DropDownOpened += new System.EventHandler(this.mnuFile_DropDownOpened);
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
            this.mnuWarehouse.AutoSize = false;
            this.mnuWarehouse.ForeColor = System.Drawing.Color.White;
            this.mnuWarehouse.Image = global::VKTIM.Properties.Resources.mnuWarehouseWhite32;
            this.mnuWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuWarehouse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuWarehouse.Name = "mnuWarehouse";
            this.mnuWarehouse.Padding = new System.Windows.Forms.Padding(5);
            this.mnuWarehouse.Size = new System.Drawing.Size(160, 68);
            this.mnuWarehouse.DropDownClosed += new System.EventHandler(this.mnuWarehouse_DropDownClosed);
            this.mnuWarehouse.DropDownOpened += new System.EventHandler(this.mnuWarehouse_DropDownOpened);
            // 
            // mnuSystem
            // 
            this.mnuSystem.AutoSize = false;
            this.mnuSystem.ForeColor = System.Drawing.Color.White;
            this.mnuSystem.Image = global::VKTIM.Properties.Resources.mnuSystemWhite32;
            this.mnuSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuSystem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Padding = new System.Windows.Forms.Padding(5);
            this.mnuSystem.Size = new System.Drawing.Size(160, 68);
            this.mnuSystem.DropDownClosed += new System.EventHandler(this.mnuSystem_DropDownClosed);
            this.mnuSystem.DropDownOpened += new System.EventHandler(this.mnuSystem_DropDownOpened);
            // 
            // mnuReport
            // 
            this.mnuReport.AutoSize = false;
            this.mnuReport.ForeColor = System.Drawing.Color.White;
            this.mnuReport.Image = global::VKTIM.Properties.Resources.mnuReportWhite32;
            this.mnuReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Padding = new System.Windows.Forms.Padding(5);
            this.mnuReport.Size = new System.Drawing.Size(160, 68);
            this.mnuReport.DropDownClosed += new System.EventHandler(this.mnuReport_DropDownClosed);
            this.mnuReport.DropDownOpened += new System.EventHandler(this.mnuReport_DropDownOpened);
            // 
            // mnuManagement
            // 
            this.mnuManagement.AutoSize = false;
            this.mnuManagement.ForeColor = System.Drawing.Color.White;
            this.mnuManagement.Image = global::VKTIM.Properties.Resources.mnuManagementWhite32;
            this.mnuManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuManagement.Name = "mnuManagement";
            this.mnuManagement.Padding = new System.Windows.Forms.Padding(5);
            this.mnuManagement.Size = new System.Drawing.Size(160, 68);
            this.mnuManagement.DropDownClosed += new System.EventHandler(this.mnuManagement_DropDownClosed);
            this.mnuManagement.DropDownOpened += new System.EventHandler(this.mnuManagement_DropDownOpened);
            // 
            // mnuHelp
            // 
            this.mnuHelp.AutoSize = false;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_UserGuide,
            this.mnuHelp_About,
            this.mnuHelp_Update});
            this.mnuHelp.ForeColor = System.Drawing.Color.White;
            this.mnuHelp.Image = global::VKTIM.Properties.Resources.mnuHelpWhite32;
            this.mnuHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Padding = new System.Windows.Forms.Padding(5);
            this.mnuHelp.Size = new System.Drawing.Size(160, 68);
            this.mnuHelp.DropDownClosed += new System.EventHandler(this.mnuHelp_DropDownClosed);
            this.mnuHelp.DropDownOpened += new System.EventHandler(this.mnuHelp_DropDownOpened);
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
            this.statusStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStripMain.AutoSize = false;
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.statusStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_dis_version,
            this.lbl_dis_server,
            this.ddb_user,
            this.ddb_icon_warning,
            this.lbl_dis_update_now});
            this.statusStripMain.Location = new System.Drawing.Point(0, 640);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(636, 26);
            this.statusStripMain.TabIndex = 62;
            // 
            // lbl_dis_version
            // 
            this.lbl_dis_version.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_version.Name = "lbl_dis_version";
            this.lbl_dis_version.Size = new System.Drawing.Size(45, 21);
            this.lbl_dis_version.Text = "Version";
            // 
            // lbl_dis_server
            // 
            this.lbl_dis_server.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_server.Name = "lbl_dis_server";
            this.lbl_dis_server.Size = new System.Drawing.Size(39, 21);
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
            this.ddb_user.ForeColor = System.Drawing.Color.White;
            this.ddb_user.Image = global::VKTIM.Properties.Resources.e_icon_user2_24;
            this.ddb_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddb_user.Name = "ddb_user";
            this.ddb_user.Size = new System.Drawing.Size(29, 24);
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
            this.ddb_icon_warning.ForeColor = System.Drawing.Color.White;
            this.ddb_icon_warning.Image = global::VKTIM.Properties.Resources.e_icon_warning_24;
            this.ddb_icon_warning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddb_icon_warning.Name = "ddb_icon_warning";
            this.ddb_icon_warning.Size = new System.Drawing.Size(29, 24);
            this.ddb_icon_warning.Text = "toolStripDropDownButton1";
            this.ddb_icon_warning.Visible = false;
            // 
            // lbl_dis_update_now
            // 
            this.lbl_dis_update_now.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dis_update_now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lbl_dis_update_now.Name = "lbl_dis_update_now";
            this.lbl_dis_update_now.Size = new System.Drawing.Size(81, 21);
            this.lbl_dis_update_now.Text = "Update Now!";
            this.lbl_dis_update_now.Visible = false;
            // 
            // lbl_dis_notify
            // 
            this.lbl_dis_notify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dis_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lbl_dis_notify.Direction = "2";
            this.lbl_dis_notify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_dis_notify.ForeColor = System.Drawing.Color.White;
            this.lbl_dis_notify.Location = new System.Drawing.Point(622, 641);
            this.lbl_dis_notify.Name = "lbl_dis_notify";
            this.lbl_dis_notify.Size = new System.Drawing.Size(455, 24);
            this.lbl_dis_notify.TabIndex = 61;
            this.lbl_dis_notify.Text = "Thông báo";
            this.lbl_dis_notify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_dis_notify.UseCompatibleTextRendering = true;
            // 
            // hlp_ComOperation
            // 
            this.hlp_ComOperation.HelpNamespace = "Help\\vktim_help.chm";
            // 
            // pn_Pinned_Title
            // 
            this.pn_Pinned_Title.BackColor = System.Drawing.Color.LightGray;
            this.pn_Pinned_Title.Controls.Add(this.btn_screen_close);
            this.pn_Pinned_Title.Controls.Add(this.button2);
            this.pn_Pinned_Title.Controls.Add(this.btn_screen_back);
            this.pn_Pinned_Title.Controls.Add(this.lbl_dis_CURRENT_FORM_TITLE);
            this.pn_Pinned_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Pinned_Title.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.pn_Pinned_Title.Location = new System.Drawing.Point(170, 45);
            this.pn_Pinned_Title.Name = "pn_Pinned_Title";
            this.pn_Pinned_Title.Size = new System.Drawing.Size(928, 40);
            this.pn_Pinned_Title.TabIndex = 64;
            this.pn_Pinned_Title.Visible = false;
            // 
            // btn_screen_close
            // 
            this.btn_screen_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_screen_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_screen_close.Enabled = false;
            this.btn_screen_close.FlatAppearance.BorderSize = 0;
            this.btn_screen_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_screen_close.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_screen_close.ForeColor = System.Drawing.Color.White;
            this.btn_screen_close.Image = global::VKTIM.Properties.Resources.e_icon_screen_close_24;
            this.btn_screen_close.Location = new System.Drawing.Point(893, 10);
            this.btn_screen_close.Name = "btn_screen_close";
            this.btn_screen_close.Size = new System.Drawing.Size(24, 24);
            this.btn_screen_close.TabIndex = 3;
            this.btn_screen_close.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::VKTIM.Properties.Resources.e_icon_screen_next;
            this.button2.Location = new System.Drawing.Point(41, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_screen_back
            // 
            this.btn_screen_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_screen_back.Enabled = false;
            this.btn_screen_back.FlatAppearance.BorderSize = 0;
            this.btn_screen_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_screen_back.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_screen_back.ForeColor = System.Drawing.Color.White;
            this.btn_screen_back.Image = global::VKTIM.Properties.Resources.e_icon_screen_back;
            this.btn_screen_back.Location = new System.Drawing.Point(10, 8);
            this.btn_screen_back.Name = "btn_screen_back";
            this.btn_screen_back.Size = new System.Drawing.Size(25, 24);
            this.btn_screen_back.TabIndex = 1;
            this.btn_screen_back.UseVisualStyleBackColor = false;
            // 
            // lbl_dis_CURRENT_FORM_TITLE
            // 
            this.lbl_dis_CURRENT_FORM_TITLE.AutoSize = true;
            this.lbl_dis_CURRENT_FORM_TITLE.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_dis_CURRENT_FORM_TITLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_dis_CURRENT_FORM_TITLE.Location = new System.Drawing.Point(86, 10);
            this.lbl_dis_CURRENT_FORM_TITLE.Name = "lbl_dis_CURRENT_FORM_TITLE";
            this.lbl_dis_CURRENT_FORM_TITLE.Size = new System.Drawing.Size(80, 21);
            this.lbl_dis_CURRENT_FORM_TITLE.TabIndex = 0;
            this.lbl_dis_CURRENT_FORM_TITLE.Text = "Form Title";
            // 
            // pn_Main_Content
            // 
            this.pn_Main_Content.AutoScroll = true;
            this.pn_Main_Content.BackColor = System.Drawing.Color.Silver;
            this.pn_Main_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pn_Main_Content.Location = new System.Drawing.Point(170, 85);
            this.pn_Main_Content.Name = "pn_Main_Content";
            this.pn_Main_Content.Size = new System.Drawing.Size(928, 555);
            this.pn_Main_Content.TabIndex = 65;
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Hệ thống quản lý kho/vật tư Viện kỹ thuật PK-KQ";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.notifyIconMain_DoubleClick);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_Show,
            this.context_Exit});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(104, 48);
            // 
            // context_Show
            // 
            this.context_Show.Name = "context_Show";
            this.context_Show.Size = new System.Drawing.Size(103, 22);
            this.context_Show.Text = "Show";
            this.context_Show.Click += new System.EventHandler(this.context_Show_Click);
            // 
            // context_Exit
            // 
            this.context_Exit.Name = "context_Exit";
            this.context_Exit.Size = new System.Drawing.Size(103, 22);
            this.context_Exit.Text = "Exit";
            this.context_Exit.Click += new System.EventHandler(this.context_Exit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1100, 666);
            this.Controls.Add(this.lbl_dis_notify);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Is_Show_Help = true;
            this.Is_Show_Maximized = true;
            this.Is_Show_Minimized = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1050);
            this.MinimumSize = new System.Drawing.Size(735, 500);
            this.Name = "frmMain";
            this.Text = "Supplies Warehouse Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.Controls.SetChildIndex(this.statusStripMain, 0);
            this.Controls.SetChildIndex(this.pn_Form, 0);
            this.Controls.SetChildIndex(this.lbl_dis_notify, 0);
            this.pn_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainError)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.pn_Pinned_Title.ResumeLayout(false);
            this.pn_Pinned_Title.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pn_Main_Content;
        private System.Windows.Forms.Panel pn_Pinned_Title;
        private System.Windows.Forms.Label lbl_dis_CURRENT_FORM_TITLE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_screen_back;
        private System.Windows.Forms.Button btn_screen_close;
        private System.Windows.Forms.ToolStripMenuItem mnuTop;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem context_Show;
        private System.Windows.Forms.ToolStripMenuItem context_Exit;
    }
}

