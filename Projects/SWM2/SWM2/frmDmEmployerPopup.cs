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
    public partial class frmDmEmployerPopup : CommonForm
    {
        private ACTION_TYPE _ACTION_TYPE;

        public ACTION_TYPE ACTION_TYPE { get => _ACTION_TYPE; set => _ACTION_TYPE = value; }

        private int _OBJECT_ID;

        public int OBJECT_ID { get => _OBJECT_ID; set => _OBJECT_ID = value; }

        public frmDmEmployerPopup()
        {
            InitializeComponent();
        }

        private void frmDmEmployerPopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (_ACTION_TYPE == ACTION_TYPE.AddNew)
                {
                    txt_data_employername.Focus();
                }
                else if (_ACTION_TYPE == ACTION_TYPE.Update)
                {
                    btn_Submit.Focus();
                }
                else if (_ACTION_TYPE == ACTION_TYPE.OnlyView)
                {
                    btn_Submit.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool bCheck = GBTSCCommon.CheckValidForm(this);
            if (!bCheck)
            {
                return;
            }

            DMEMPLOYERInfo unitInfo = new DMEMPLOYERInfo();
            unitInfo.CODE = txt_data_code.Text;
            unitInfo.EMPLOYER_NAME = txt_data_employername.Text;
            unitInfo.EMPLOYER_SEX = txt_data_employersex.Text;
            unitInfo.BIRTHDAY = DateTime.Parse( txt_data_birthday.Text);
            unitInfo.TINH_LOCATION_NAME = txt_data_tinh.Text;
            unitInfo.HUYEN_LOCATION_NAME = txt_data_huyen.Text;
            unitInfo.XA_LOCATION_NAME = txt_data_xa.Text;
            unitInfo.RANK_ID = int.Parse( txt_data_rank.Text);
            unitInfo.TITLE_ID = int.Parse(txt_data_title.Text);
            unitInfo.ORGANIZATION_ID = int.Parse(txt_data_organization.Text);
            unitInfo.PHONE1 = txt_data_phone1.Text;
            unitInfo.PHONE2 = txt_data_phone2.Text;
            unitInfo.AVATAR = txt_data_avatar.Text;
            unitInfo.EMAIL = txt_data_email.Text;
            unitInfo.ADDRESS = txt_data_address.Text;
            unitInfo.RETRIED = bool.Parse(txt_data_retried.Text);

            if (_ACTION_TYPE == ACTION_TYPE.AddNew)
            {
                try
                {
                    unitInfo = DMEMPLOYERController.Instance().Insert(unitInfo);
                    if (unitInfo != null)
                    {
                        _OBJECT_ID = unitInfo.ID;
                        //------ Add log -------
                        DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "EMPLOYER_ADD", "OK", "Thêm cán bộ thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        GBTSCCommon.Message_Info(GBTSCConstants.MSG_ADD_FAILED, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                    }
                }
                catch (Exception ex)
                {
                    GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
            else if (_ACTION_TYPE == ACTION_TYPE.Update)
            {
                try
                {
                    unitInfo.ID = Convert.ToInt32(txt_data_id.Text);
                    DMEMPLOYERController.Instance().Update(unitInfo);
                    _OBJECT_ID = unitInfo.ID;
                    //------ Add log -------
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "EMPLOYER_ADD", "OK", "Thêm cán bộ thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
