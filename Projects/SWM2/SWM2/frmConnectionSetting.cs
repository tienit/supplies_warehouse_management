using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Common;

namespace VKTIM
{
    public partial class frmConnectionSetting : CommonForm
    {
        public frmConnectionSetting()
        {
            InitializeComponent();
        }

        private void frmConnectionSetting_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Setting();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Load_Setting()
        {
            txt_data_server.Text = Properties.Settings.Default.CS_ServerName;
            txt_data_username.Text = Properties.Settings.Default.CS_UserName;
            txt_data_password.Text = Properties.Settings.Default.CS_PassWord;
            txt_data_database.Text = Properties.Settings.Default.CS_DatabaseName;
        }

        private void Save_Setting()
        {
            Properties.Settings.Default.CS_ServerName = txt_data_server.Text.Trim();
            Properties.Settings.Default.CS_UserName = txt_data_username.Text.Trim();
            Properties.Settings.Default.CS_PassWord = txt_data_password.Text.Trim();
            Properties.Settings.Default.CS_DatabaseName = txt_data_database.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if (GBTSCCommon.Connection_Testing(txt_data_server.Text, txt_data_username.Text, txt_data_password.Text, txt_data_database.Text))
            {
                GBTSCCommon.Message_Info(GBTSCConstants.MSG_SERVER_CONNECT_SUCCESS, "CONNECTION TESTING", GBTSCCommon.MessageType.Message_OK);
                btn_Save.Enabled = true;
                btn_Save.Focus();
            }
            else
            {
                GBTSCCommon.Message_Info(GBTSCConstants.MSG_SERVER_CONNECT_FAILED_AND_CHECK, "CONNECTION TESTING", GBTSCCommon.MessageType.Message_NG);
                btn_Save.Enabled = false;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                bool bCheck = GBTSCCommon.CheckValidForm(this);
                if (!bCheck)
                {
                    return;
                }
                
                Save_Setting();
                Application.Restart();
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }
    }
}
