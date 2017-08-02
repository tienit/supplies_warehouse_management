using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Common;
using VKTIM.Component;

namespace VKTIM
{
    public partial class frmChangePass : CommonForm
    {
 
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txt_data_username.Text = GBTSCConstants.CURRENT_USER.USER_NAME;
            txt_data_password_current.Select();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Change();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Do_Change()
        {
            bool bCheck = GBTSCCommon.CheckValidForm(this);
            if (bCheck == false)
            {
                return;
            }
            else
            {
                HTUSERInfo uInfo = HTUSERController.Instance().GetOption(txt_data_username.Text, Crytopo.Encrypt_Rfc2898(txt_data_password_current.Text.Trim()));
                if (uInfo == null)
                {
                    GBTSCCommon.Message_Info(GBTSCConstants.MSG_CHANGE_PASS_CURRENT_INVALID, "PASSWORD", GBTSCCommon.MessageType.Message_NG);
                    return;
                }
                else
                {
                    if (txt_data_password_current.Text.Trim().Equals(txt_data_password_new.Text.Trim()))
                    {
                        GBTSCCommon.Message_Info(GBTSCConstants.MSG_CHANGE_PASS_NEW_EQUAL_CURRENT, "PASSWORD", GBTSCCommon.MessageType.Message_NG);
                        return;
                    }
                    else
                    {
                        HTUSERController.Instance().UpdatePassword(txt_data_username.Text, Crytopo.Encrypt_Rfc2898(txt_data_password_new.Text));
                        DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0,
                            "CHANGE_PASS",
                            "OK",
                            "Change password successful",
                            GBTSCCommon.SERVER_NOW(),
                            GBTSCConstants.CURRENT_USER.ID,
                            GBTSCConstants.CURRENT_USER.USER_NAME,
                            Environment.UserName,
                            Environment.MachineName,
                            Environment.UserDomainName,
                            Environment.CurrentDirectory,
                            ""));
                        GBTSCCommon.Message_Info(GBTSCConstants.MSG_CHANGE_PASS_SUCCESS_AND_RESTART, "CHANGE PASSWORD", GBTSCCommon.MessageType.Message_OK);
                        Application.Restart();
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
