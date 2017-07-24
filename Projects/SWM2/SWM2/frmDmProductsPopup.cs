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
    public partial class frmDmProductsPopup : CommonForm
    {
        private ACTION_TYPE _ACTION_TYPE;

        public ACTION_TYPE ACTION_TYPE { get => _ACTION_TYPE; set => _ACTION_TYPE = value; }

        private int _OBJECT_ID;

        public int OBJECT_ID { get => _OBJECT_ID; set => _OBJECT_ID = value; }

        public frmDmProductsPopup()
        {
            InitializeComponent();
        }

        private void frmDmProductsPopup_Load(object sender, EventArgs e)
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool bCheck = GBTSCCommon.CheckValidForm(this);
            if (!bCheck)
            {
                return;
            }

            DMPRODUCTSInfo unitInfo = new DMPRODUCTSInfo();
            unitInfo.UNIT_NAME = txt_data_name.Text;
            unitInfo.PRODUCTS_NAME = txt_data_name.Text;
            unitInfo.PRODUCTS_NAME_OTHER = txt_data_othername.Text;
            unitInfo.PRODUCTS_DESCRIPTION = txt_data_description.Text;
            unitInfo.PRODUCTS_SHORT_DESCRIPTION = txt_data_description.Text;
            unitInfo.ORIGIN_ID = int.Parse( txt_data_orginid.Text);
            unitInfo.ORIGIN_NAME = txt_data_orginname.Text;
            unitInfo.SUPPLIER_ID = int.Parse(txt_data_supplierid.Text);
            unitInfo.SUPPLIER_NAME = txt_data_suppliername.Text;
            unitInfo.PRODUCTCATEGORY_ID = int.Parse(txt_data_categoryid.Text);
            unitInfo.PRODUCTCATEGORY_NAME = txt_data_categoryname.Text;
            unitInfo.PRICE_DEFAULT = bool.Parse(txt_data_pricedefault.Text);
            unitInfo.PRODUCTS_CODE = txt_data_code.Text;

            if (_ACTION_TYPE == ACTION_TYPE.AddNew)
            {
                try
                {
                    unitInfo = DMPRODUCTSController.Instance().Insert(unitInfo);
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
                    DMPRODUCTSController.Instance().Update(unitInfo);
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
