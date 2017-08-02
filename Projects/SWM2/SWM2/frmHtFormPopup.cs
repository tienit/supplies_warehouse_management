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
    public partial class frmHtFormPopup : CommonForm
    {
        private ACTION_TYPE _ACTION_TYPE;

        public ACTION_TYPE ACTION_TYPE { get => _ACTION_TYPE; set => _ACTION_TYPE = value; }

        private int _OBJECT_ID;

        public int OBJECT_ID { get => _OBJECT_ID; set => _OBJECT_ID = value; }

        public frmHtFormPopup()
        {
            InitializeComponent();
        }

        private void frmHtFormPopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (_ACTION_TYPE == ACTION_TYPE.AddNew)
                {
                    txt_data_name.Focus();
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

        private string GetListKeys()
        {
            string lstKeys = "";
            if (cmb_data_shortcut_key.SelectedIndex > 0)
            {
                if (chk_data_ctrl.Checked)
                {
                    lstKeys = lstKeys + Keys.Control.ToString() + "+";
                }
                if (chk_data_shift.Checked)
                {
                    lstKeys = lstKeys + Keys.Shift.ToString() + "+";
                }
                if (chk_data_alt.Checked)
                {
                    lstKeys = lstKeys + Keys.Alt.ToString() + "+";
                }
                lstKeys = lstKeys + cmb_data_shortcut_key.SelectedItem.ToString();
            }
            return lstKeys;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool bCheck = GBTSCCommon.CheckValidForm(this);
            if (!bCheck)
            {
                return;
            }

            HTFORMInfo formInfo = new HTFORMInfo();
            formInfo.FORM_NAME = txt_data_name.Text;
            formInfo.FORM_TITLE = txt_data_title.Text;
            formInfo.FORM_TITLE_EN = txt_data_title_en.Text;
            formInfo.MENU_NAME = txt_data_menu_name.Text;
            formInfo.IS_SHOW_DIALOG = chk_data_show_dialog.Checked;
            formInfo.SHORTCUT_KEY = GetListKeys();
            formInfo.IS_USED = chk_data_used.Checked;
            formInfo.FORM_ORDER = Convert.ToInt32(nud_data_order.Value);

            if (_ACTION_TYPE == ACTION_TYPE.AddNew)
            {
                try
                {
                    formInfo = HTFORMController.Instance().Insert(formInfo);
                    if (formInfo != null)
                    {
                        _OBJECT_ID = formInfo.ID;
                        //------ Add log -------
                        DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "FORM_ADD", "OK", "Thêm chức năng thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
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
                    formInfo.ID = Convert.ToInt32(txt_data_id.Text);
                    HTFORMController.Instance().Update(formInfo);
                    _OBJECT_ID = formInfo.ID;
                    //------ Add log -------
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "FORM_UPDATE", "OK", "Cập nhật chức năng thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
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
