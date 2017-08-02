using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using VKTIM.Common;
using VKTIM.Component;

namespace VKTIM
{
    public partial class frmLogin : CommonForm
    {
        private HTUSERInfo _CURRENT_USER;
        public HTUSERInfo CURRENT_USER { get => _CURRENT_USER; set => _CURRENT_USER = value; }

        private bool b_username_null = false;
        private bool b_password_null = false;
        private bool b_account_invalid = false;
        private bool b_account_locked = false;
        private bool b_connect_server = false;

        private string _IP_ADDRESS = String.Empty;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
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

        private void InitControl()
        {
            lbl_dis_error.Text = "";
            txt_data_username.Select();
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ips)
            {
                _IP_ADDRESS += ip + "/";
            }
        }

        private void bwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            Do_Login();
        }

        private void bwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 88)
            {
                btn_Submit.Enabled = false;
                btn_Cancel.Enabled = false;
            }
        }

        private void bwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picLoading.Visible = false;
            if (b_username_null)
            {
                lbl_dis_username.ForeColor = Color.Red;
                txt_data_username.Focus();
                return;
            }
            if (b_password_null)
            {
                lbl_dis_password.ForeColor = Color.Red;
                txt_data_password.Focus();
                return;
            }
            if (!b_connect_server)
            {
                lbl_dis_error.Text = GBTSCConstants.MSG_SERVER_CONNECT_FAILED_AND_CHECK;
                txt_data_username.Focus();
                return;
            }
            if (b_account_invalid)
            {
                lbl_dis_error.Text = GBTSCConstants.MSG_LOGIN_ACCOUNT_NOT_VALID;
                txt_data_username.Focus();
                return;
            }
            if (b_account_locked)
            {
                lbl_dis_error.Text = GBTSCConstants.MSG_LOGIN_ACCOUNT_LOCKED;
                return;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            picLoading.Visible = true;
            bwMain.RunWorkerAsync();
        }

        private void Do_Login()
        {
            bool bCheck = true;
            if (txt_data_username.Text == null || txt_data_username.Text.Equals(""))
            {
                b_username_null = true;
                bCheck = false;
            }
            if (txt_data_password.Text == null || txt_data_password.Text.Equals(""))
            {
                b_password_null = true;
                bCheck = false;
            }
            if (bCheck == false)
            {
                return;
            }
            if (GBTSCCommon.Connection_Testing_Inner())
            {
                b_connect_server = true;
                HTUSERInfo uInfo = HTUSERController.Instance().GetOption(txt_data_username.Text.Trim(), Crytopo.Encrypt_Rfc2898(txt_data_password.Text.Trim()));
                if (uInfo != null)
                {
                    if (uInfo.IS_BLOCKED)
                    {
                        b_account_locked = true;
                    }
                    else
                    {
                        bwMain.ReportProgress(88);
                        _CURRENT_USER = uInfo;

                        //Update logged information
                        HTUSERController.Instance().UpdateLog(uInfo.USER_NAME, _IP_ADDRESS);

                        DTLOGLOGINController.Instance().Insert(new DTLOGLOGINInfo(0,
                            "LOGIN_OK",
                            "Login successful",
                            "OK",
                            "Login successful",
                            GBTSCCommon.SERVER_NOW(),
                            uInfo.ID,
                            uInfo.USER_NAME,
                            Environment.UserName,
                            Environment.MachineName,
                            Environment.UserDomainName,
                            Environment.CurrentDirectory,
                            ""));
                        this.DialogResult = DialogResult.Yes;
                    }
                }
                else
                {
                    b_account_invalid = true;
                }
            }
            else
            {
                b_connect_server = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
