﻿using System;
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
    public partial class frmDmOrganizationPopup : CommonForm
    {
        private ACTION_TYPE _ACTION_TYPE;

        public ACTION_TYPE ACTION_TYPE { get => _ACTION_TYPE; set => _ACTION_TYPE = value; }

        private int _OBJECT_ID;

        public int OBJECT_ID { get => _OBJECT_ID; set => _OBJECT_ID = value; }

        public frmDmOrganizationPopup()
        {
            InitializeComponent();
        }

        private void frmDmOrganizationPopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (_ACTION_TYPE == ACTION_TYPE.AddNew)
                {
                    txt_data_OrganizationTitle.Focus();
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

            DMORGANIZATIONInfo unitInfo = new DMORGANIZATIONInfo();
            unitInfo.ORGANIZATION_TITLE = txt_data_OrganizationTitle.Text;
            unitInfo.ORGANIZATION_NAME = txt_data_OrganizationName.Text;
            unitInfo.ORGANIZATION_DESCRIPTION = txt_data_OrganizationDescription.Text;
            unitInfo.ORGANIZATION_CODE = txt_data_Code.Text;
            unitInfo.SPECIAL_ID = int.Parse(txt_data_SpecialID.Text);
            unitInfo.ORGANIZATION_LEVEL = int.Parse(txt_data_OrganizationLevel.Text);

            if (_ACTION_TYPE == ACTION_TYPE.AddNew)
            {
                try
                {
                    unitInfo = DMORGANIZATIONController.Instance().Insert(unitInfo);
                    if (unitInfo != null)
                    {
                        _OBJECT_ID = unitInfo.ID;
                        //------ Add log -------
                        DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "UNIT_ADD", "OK", "Thêm đơn vị thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
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
                    DMORGANIZATIONController.Instance().Update(unitInfo);
                    _OBJECT_ID = unitInfo.ID;
                    //------ Add log -------
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "UNIT_UPDATE", "OK", "Cập nhật đơn vị thành công.", GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
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
