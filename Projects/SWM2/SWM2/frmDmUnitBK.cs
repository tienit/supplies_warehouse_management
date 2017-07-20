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
    public partial class frmDmUnitBK : CommonForm
    {
        public frmDmUnitBK()
        {
            InitializeComponent();
        }

        private void frmDmUnit_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Data();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Load_Data()
        {
            DataTable dtSrc = DMUNITController.Instance().GetAll_DS().Tables[0];
            dgv_Data.DataSource = dtSrc;
            lbl_data_count.Text = dtSrc.Rows.Count.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                frmDmUnitPopup m_Popup = new frmDmUnitPopup();
                m_Popup.Text = "Thêm đơn vị";
                m_Popup.ACTION_TYPE = ACTION_TYPE.AddNew;
                if (m_Popup.ShowDialog() == DialogResult.OK)
                {
                    Load_Data();
                }
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = dgv_Data.SelectedRows[0];
                    frmDmUnitPopup m_Popup = new frmDmUnitPopup();
                    m_Popup.Text = "Cập nhật đơn vị";
                    m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                    m_Popup.txt_data_id.Text = dr.Cells["colID"].Value.ToString();
                    m_Popup.txt_data_name.Text = (string)dr.Cells["colName"].Value;
                    m_Popup.txt_data_shortname.Text = (string)dr.Cells["colShortName"].Value;
                    m_Popup.txt_data_description.Text = (dr.Cells["colDescription"].Value != null) ? dr.Cells["colDescription"].Value.ToString() : "";
                    if (m_Popup.ShowDialog() == DialogResult.OK)
                    {
                        Load_Data();
                    }
                }
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data.SelectedRows.Count > 0)
                {
                    if (GBTSCCommon.Message_Confirm(GBTSCConstants.MSG_DELETE_CONFIRM, GBTSCConstants.MSG_CAPTION_DELETE) == DialogResult.Yes)
                    {
                        int objID = Convert.ToInt32(dgv_Data.SelectedRows[0].Cells["colID"].Value);

                        // Check the conditions before deleting

                        //Delete
                        DMUNITController.Instance().Delete(objID);
                    }
                }
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DMUNITController.Instance().Search_DS(txt_data_keyword.Text);
                dgv_Data.DataSource = dt;
                lbl_data_count.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }
    }
}
