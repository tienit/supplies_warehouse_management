using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Common;
using VKTIM.Component;

namespace VKTIM
{
    public partial class frmMain : CommonForm
    {
        frmSplashLoadForm m_Splash; //Splash form / Wait form
        CommonFormAdmin frmCommonAdmin = null;
        CommonForm frmCommon = null;
        string CM_NONE_OR_ADMIN = "CM_NONE";

        public frmMain()
        {
            InitializeComponent();
            InitSetting();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                InitControl();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
            
        }

        private void InitSetting()
        {

        }

        private void InitControl()
        {
            //Color
            this.BackColor = Color.FromArgb(0, 0, 50);
            //Working size
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            //Set text for menu item
            GBTSCCommon.SetMenuText(menuStripMain, this.Name);
            GBTSCCommon.SetStatusStripText(ddb_user, this.Name);

            //Init menu item state
            mnuFile_Logout.Visible = false;
            mnuFile_Logout.Enabled = false;
            mnuFile_ChangePass.Visible = false;
            mnuFile_ChangePass.Enabled = false;

            mnuWarehouse.Visible = false;
            mnuSystem.Visible = false;
            mnuManagement.Visible = false;
            mnuReport.Visible = false;

            //Current User
            //GBTSCConstants.CURRENT_USER = HTUSERController.Instance().GetById(1);

            //Status bar
            string app_revision = Application.ProductVersion.Substring(Application.ProductVersion.LastIndexOf(".") + 1);
            lbl_dis_version.Text = String.Format(GBTSCConstants.TXT_REVISION, app_revision);

            //Check Update
            HTCONFIGInfo configInfo = HTCONFIGController.Instance().GetByCode("CURRENT_VERSION");
            if (configInfo != null)
            {
                if (!configInfo.CONFIG_VALUE.Equals(app_revision))
                {
                    ddb_icon_warning.Visible = true;
                    lbl_dis_update_now.Visible = true;
                    string current_version = configInfo.CONFIG_VALUE;
                    configInfo = HTCONFIGController.Instance().GetByCode("UPDATE_TEXT");
                    if (configInfo != null)
                    {
                        lbl_dis_update_now.Text = String.Format(configInfo.CONFIG_VALUE, current_version);
                    }
                }
            }

            configInfo = HTCONFIGController.Instance().GetByCode("SYSTEM_NOTIFICATION");
            if (configInfo != null)
            {
                lbl_dis_notify.Text = configInfo.CONFIG_VALUE;
            }

            this.WindowState = FormWindowState.Maximized;
        }


        private void mnuFile_Login_Click(object sender, EventArgs e)
        {
            if (GBTSCCommon.CheckBeforeLogin() == false)
            {
                return;
            }

            frmLogin m_Frm = new frmLogin();
            if (m_Frm.ShowDialog() == DialogResult.Yes)
            {
                GBTSCCommon.SetMenuText(menuStripMain, this.Name);
                HTROLEInfo roleInfo = HTROLEController.Instance().GetByUser(m_Frm.CURRENT_USER.ID);
                SetPermisson(roleInfo.ID);
                GBTSCConstants.CURRENT_USER = m_Frm.CURRENT_USER;
                ddb_user.Visible = true;
                ddb_user.Text = m_Frm.CURRENT_USER.USER_NAME;
                lbl_dis_server.Visible = true;
                lbl_dis_server.Text = String.Format(GBTSCConstants.TXT_SERVER, Properties.Settings.Default.CS_ServerName);
                PermissionAfterLogged();
            }
        }

        private void SetPermisson(int roleID)
        {
            List<HTFORMInfo> lst = null;
            if (roleID == 1)
            {
                lst = HTFORMController.Instance().GetUsed();
            }
            else
            {
                lst = HTFORMController.Instance().GetByRole(roleID);
            }
            
            if (lst.Count > 0)
            {
                foreach (HTFORMInfo fInfo in lst)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    string culture_name = GBTSCConstants.CURRENT_CULTURE.Name.ToLower();

                    if (culture_name.Equals("vi-vn"))
                    {
                        item = new ToolStripMenuItem(fInfo.FORM_TITLE, Properties.Resources.e_icon_menu_item_24, mnu_Item_Click, fInfo.MENU_NAME);
                    }
                    else if (culture_name.Equals("en-us"))
                    {
                        item = new ToolStripMenuItem(fInfo.FORM_TITLE_EN, Properties.Resources.e_icon_menu_item_24, mnu_Item_Click, fInfo.MENU_NAME);
                    }
                    item.Tag = fInfo.FORM_NAME;
                    item.AccessibleDescription = (fInfo.IS_SHOW_DIALOG == true) ? "1" : "0";
                    GBTSCCommon.SetKeysForItem(item, fInfo.SHORTCUT_KEY);

                    switch (fInfo.MENU_NAME.Substring(0, 6))
                    {
                        case "mnuWHS":
                            mnuWarehouse.DropDownItems.Add(item);
                            break;
                        case "mnuSYS":
                            mnuSystem.DropDownItems.Add(item);
                            break;
                        case "mnuRPT":
                            mnuReport.DropDownItems.Add(item);
                            break;
                        case "mnuMNG":
                            mnuManagement.DropDownItems.Add(item);
                            break;
                        default:
                            break;
                    }
                }

                if (mnuWarehouse.DropDownItems.Count > 0)
                {
                    mnuWarehouse.Visible = true;
                }
                if (mnuSystem.DropDownItems.Count > 0)
                {
                    mnuSystem.Visible = true;
                }
                if (mnuReport.DropDownItems.Count > 0)
                {
                    mnuReport.Visible = true;
                }
                if (mnuManagement.DropDownItems.Count > 0)
                {
                    mnuManagement.Visible = true;
                }
            }
        }

        private void mnu_Item_Click(object sender, EventArgs e)
        {
            Form frm = null;
            ToolStripMenuItem itemSender = (ToolStripMenuItem)sender;
            //if (itemSender.AccessibleDescription.Equals("1"))
            //{
            //    //GBTSCCommon.ShowForm_ClassName(itemSender.Tag.ToString(), itemSender.Text.Trim());
            //    //frm = GBTSCCommon.GetForm_From_ClassName(itemSender.Tag.ToString(), itemSender.Text.Trim());
            //}
            //else
            //{
            //    //GBTSCCommon.ShowForm_ClassName_2(itemSender.Tag.ToString(), itemSender.Text.Trim());
            //    //frm = GBTSCCommon.GetForm_From_ClassName_2(itemSender.Tag.ToString(), itemSender.Text.Trim());
            //}

            m_Splash = new frmSplashLoadForm();
            if (m_Splash != null)
            {
                System.Threading.Thread splashThread = new System.Threading.Thread(new System.Threading.ThreadStart(
                    () => { Application.Run(m_Splash); }));
                splashThread.SetApartmentState(System.Threading.ApartmentState.STA);
                splashThread.Start();
            }

            frm = GBTSCCommon.GetForm_From_ClassName(itemSender.Tag.ToString(), itemSender.Text.Trim());
            try
            {
                frmCommonAdmin = (CommonFormAdmin)frm;
                CM_NONE_OR_ADMIN = "CM_ADMIN";
            }
            catch
            {
                frmCommon = (CommonForm)frm;
                CM_NONE_OR_ADMIN = "CM_NONE";
            }

            if (CM_NONE_OR_ADMIN.Equals("CM_ADMIN"))
            {
                frmCommonAdmin.LoadCompleted += AdminForm_LoadCompleted;
                frmCommonAdmin.Show();
                
            }
            else if (CM_NONE_OR_ADMIN.Equals("CM_NONE"))
            {
                frmCommon.LoadCompleted += AdminForm_LoadCompleted;
                frmCommon.Show();
            }
        }

        private void AdminForm_LoadCompleted(object sender, EventArgs e)
        {
            if (m_Splash == null || m_Splash.Disposing || m_Splash.IsDisposed)
            {
                return;
            }
            m_Splash.Invoke(new Action(() => { m_Splash.Close(); }));
            m_Splash.Dispose();
            m_Splash = null;

            if (CM_NONE_OR_ADMIN.Equals("CM_ADMIN"))
            {
                frmCommonAdmin.Activate();

            }
            else if (CM_NONE_OR_ADMIN.Equals("CM_NONE"))
            {
                frmCommon.Activate();
            }
            
        }

        private void PermissionAfterLogged()
        {
            mnuFile_Login.Visible = false;
            mnuFile_Login.Enabled = false;
            mnuFile_Logout.Visible = true;
            mnuFile_Logout.Enabled = true;
            mnuFile_ChangePass.Visible = true;
            mnuFile_ChangePass.Enabled = true;
        }

        private void PermissionAfterLogout()
        {
            mnuFile_Login.Visible = true;
            mnuFile_Login.Enabled = true;
            mnuFile_Logout.Visible = false;
            mnuFile_Logout.Enabled = false;
            mnuFile_ChangePass.Visible = false;
            mnuFile_ChangePass.Enabled = false;

            mnuWarehouse.Visible = false;
            mnuWarehouse.DropDownItems.Clear();
            mnuSystem.Visible = false;
            mnuSystem.DropDownItems.Clear();
            mnuManagement.Visible = false;
            mnuManagement.DropDownItems.Clear();
            mnuReport.Visible = false;
            mnuReport.DropDownItems.Clear();

            ddb_user.Visible = false;
            GBTSCConstants.CURRENT_USER = null;
            lbl_dis_server.Visible = false;
            lbl_dis_server.Text = "";
        }


        private void mnuFile_ChangePass_Click(object sender, EventArgs e)
        {
            Do_ChangePassword();
        }

        private void Do_ChangePassword()
        {
            frmChangePass m_Frm = new frmChangePass();
            //m_Frm.TopLevel = false;
            //m_Frm.AutoScroll = true;
            //this.pn_Main_Content.Controls.Clear();
            //this.pn_Main_Content.Controls.Add(m_Frm);
            //m_Frm.Show();
            m_Frm.ShowDialog();
        }

        private void mnuFile_Logout_Click(object sender, EventArgs e)
        {
            Do_Logout();
        }

        private void Do_Logout()
        {
            if (GBTSCCommon.Message_Confirm(GBTSCConstants.MSG_LOGOUT_CONFIRM, "LOGOUT") == DialogResult.Yes)
            {
                //this.BackColor = Properties.Settings.Default.COLOR_APP_BACK;
                DTLOGLOGINController.Instance().Insert(new DTLOGLOGINInfo(0,
                            "LOGIN_OK",
                            "Login successful",
                            "OK",
                            "Login successful",
                            GBTSCCommon.SERVER_NOW(),
                            GBTSCConstants.CURRENT_USER.ID,
                            GBTSCConstants.CURRENT_USER.USER_NAME,
                            Environment.UserName,
                            Environment.MachineName,
                            Environment.UserDomainName,
                            Environment.CurrentDirectory,
                            ""));
                PermissionAfterLogout();

                if (GBTSCCommon.CheckBeforeLogin() == false)
                {
                    return;
                }

                frmLogin m_Frm = new frmLogin();
                if (m_Frm.ShowDialog() == DialogResult.Yes)
                {
                    GBTSCCommon.SetMenuText(menuStripMain, this.Name);
                    HTROLEInfo roleInfo = HTROLEController.Instance().GetByUser(m_Frm.CURRENT_USER.ID);
                    SetPermisson(roleInfo.ID);
                    GBTSCConstants.CURRENT_USER = m_Frm.CURRENT_USER;
                    ddb_user.Visible = true;
                    ddb_user.Text = m_Frm.CURRENT_USER.USER_NAME;
                    lbl_dis_server.Visible = true;
                    lbl_dis_server.Text = Properties.Settings.Default.CS_ServerName;
                    PermissionAfterLogged();
                }
            }
        }

        private void mnuFile_Connection_Click(object sender, EventArgs e)
        {
            frmConnectionSetting m_Frm = new frmConnectionSetting();
            if (m_Frm.ShowDialog() == DialogResult.Yes)
            {
                GBTSCCommon.Message_Info(GBTSCConstants.MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART, "CONNECTION SETTING", GBTSCCommon.MessageType.Message_OK);
                Application.Restart();
            }
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {
            Do_Exit();
        }

        private void Do_Exit()
        {
            if (GBTSCCommon.Message_Confirm(GBTSCConstants.MSG_EXIT_CONFIRM, "EXIT SYSTEM") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuHelp_UserGuide_Click(object sender, EventArgs e)
        {
            //frmUserGuide m_Frm = new frmUserGuide();
            //m_Frm.ShowDialog();
            Help.ShowHelp(this, hlp_ComOperation.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            frmAbout m_Frm = new frmAbout();
            m_Frm.ShowDialog();
        }

        private void mnuHelp_Update_Click(object sender, EventArgs e)
        {
            //int server_revision = Convert.ToInt32(TMSETTINGController.Instance().GetByCode("UPDATE_NOTIFY").CHR_VALUE);
            string server_revision_str = HTCONFIGController.Instance().GetByCode("CURRENT_VERSION").CONFIG_VALUE;
            string updater_path = HTCONFIGController.Instance().GetByCode("UPDATER_PATH").CONFIG_VALUE;
            string updater_type = HTCONFIGController.Instance().GetByCode("UPDATE_TYPE").CONFIG_VALUE;
            string update_source_path = HTCONFIGController.Instance().GetByCode("UPDATE_SOURCE_PATH").CONFIG_VALUE;

            if (server_revision_str.Equals(Application.ProductVersion.Substring(Application.ProductVersion.LastIndexOf(".") + 1)))
            {
                GBTSCCommon.Message_Info(GBTSCConstants.MSG_UPDATE_LATEST_VERSION, "LASTEST VERSION", GBTSCCommon.MessageType.Message_OK);
                return;
            }
            Process pInfo = new Process();
            ProcessStartInfo sInfo = new ProcessStartInfo();
            if (updater_type.Trim().Equals("1")) //Local Path
            {
                sInfo.FileName = Application.StartupPath + updater_path;
            }
            else //Network Path
            {
                sInfo.FileName = updater_path;
            }
            //MessageBox.Show(sInfo.FileName);
            sInfo.Arguments = update_source_path;
            pInfo.StartInfo = sInfo;
            pInfo.Start();
            Properties.Settings.Default.APP_REVISION = server_revision_str;
            Properties.Settings.Default.Save();

            //Close All Process
            try
            {
                Process[] arr = Process.GetProcessesByName("VKTIM");
                foreach (Process pro in arr)
                {
                    pro.Kill();
                }
            }
            catch
            {
            }
        }


        private void ddb_user_change_pass_Click(object sender, EventArgs e)
        {
            Do_ChangePassword();
        }

        private void ddb_user_logout_Click(object sender, EventArgs e)
        {
            Do_Logout();
        }

        private void ddb_user_exit_Click(object sender, EventArgs e)
        {
            Do_Exit();
        }



        private void mnuFile_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuFileGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuFile_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuFileWhite32;
            item.ForeColor = Color.White;
        }

        private void mnuWarehouse_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuWarehouseGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuWarehouse_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuWarehouseWhite32;
            item.ForeColor = Color.White;
        }

        private void mnuSystem_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuSystemGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuSystem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuSystemWhite32;
            item.ForeColor = Color.White;
        }

        private void mnuReport_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuReportGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuReport_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuReportWhite32;
            item.ForeColor = Color.White;
        }

        private void mnuManagement_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuManagementGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuManagement_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuManagementWhite32;
            item.ForeColor = Color.White;
        }

        private void mnuHelp_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuHelpGreen32;
            item.ForeColor = Color.FromArgb(57, 115, 13);
        }

        private void mnuHelp_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Image = Properties.Resources.mnuHelpWhite32;
            item.ForeColor = Color.White;
        }
    }
}
