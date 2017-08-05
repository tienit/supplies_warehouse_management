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
    public partial class frmSettingPopup : CommonForm
    {
        private ACTION_TYPE _ACTION_TYPE;

        public ACTION_TYPE ACTION_TYPE { get => _ACTION_TYPE; set => _ACTION_TYPE = value; }

        private int _OBJECT_ID;

        public int OBJECT_ID { get => _OBJECT_ID; set => _OBJECT_ID = value; }

        public frmSettingPopup()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool bCheck = GBTSCCommon.CheckValidForm(this);
            if (!bCheck)
            {
                return;
            }

            HTCONFIGInfo configInfo = new HTCONFIGInfo();
            configInfo.CONFIG_NAME = txt_data_name.Text;
            configInfo.CONFIG_DESCRIPTION = txt_data_description.Text;
            configInfo.CONFIG_CODE = txt_data_code.Text;
            configInfo.CONFIG_VALUE = txt_data_value.Text;

            if (_ACTION_TYPE == ACTION_TYPE.AddNew)
            {
                try
                {
                    configInfo = HTCONFIGController.Instance().Insert(configInfo);
                    if (configInfo != null)
                    {
                        _OBJECT_ID = configInfo.ID;
                        //------ Add log -------
                        DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "CONFIG_ADD", "OK", "Thêm thiết lập thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
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
                    configInfo.ID = Convert.ToInt32(txt_data_id.Text);
                    HTCONFIGController.Instance().Update(configInfo);
                    _OBJECT_ID = configInfo.ID;
                    //------ Add log -------
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "CONFIG_UPDATE", "OK", "Cập nhật thiết lập thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
        }

        private void frmDmPricePopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (_ACTION_TYPE == ACTION_TYPE.AddNew)
                {
                    txt_data_code.Focus();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
