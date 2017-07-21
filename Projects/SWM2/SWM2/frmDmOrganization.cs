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
using VKTIM.Component.Infos;

namespace VKTIM
{
    public partial class frmDmOrganization : CommonFormAdmin
    {
        public frmDmOrganization()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_ORGANIZATION";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_TITLE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_CODE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_DESCRIPTION", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SPECIAL_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_LEVEL", GIRD_COLUMN_TYPE.TextBox));
           
        }

        protected override void Do_Add()
        {
            frmDmOrganizationPopup m_Popup = new frmDmOrganizationPopup();
            m_Popup.Text = "Thêm đơn vị";
            m_Popup.ACTION_TYPE = ACTION_TYPE.AddNew;
            if (m_Popup.ShowDialog() == DialogResult.OK)
            {
                Load_Data();
            }
        }

        protected override void Do_Update()
        {
            if (GRID_DATA.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = GRID_DATA.SelectedRows[0];
                frmDmOrganizationPopup m_Popup = new frmDmOrganizationPopup();
                m_Popup.Text = "Cập nhật đơn vị";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_OrganizationTitle.Text = (dr.Cells["col_ORGANIZATION_TITLE"].Value.ToString() != null) ? dr.Cells["col_ORGANIZATION_TITLE"].Value.ToString() : ""; 
                m_Popup.txt_data_OrganizationName.Text = (dr.Cells["col_ORGANIZATION_NAME"].Value.ToString() != null) ? dr.Cells["col_ORGANIZATION_NAME"].Value.ToString() : "";
                m_Popup.txt_data_Code.Text = (dr.Cells["col_SPECIAL_ID"].Value.ToString() != null) ? dr.Cells["col_SPECIAL_ID"].Value.ToString() : "";
                m_Popup.txt_data_OrganizationDescription.Text = (dr.Cells["col_ORGANIZATION_DESCRIPTION"].Value.ToString() != null) ? dr.Cells["col_ORGANIZATION_DESCRIPTION"].Value.ToString() : "";
                m_Popup.txt_data_SpecialID.Text = (dr.Cells["col_SPECIAL_ID"].Value.ToString() != null) ? dr.Cells["col_SPECIAL_ID"].Value.ToString() : "";
                m_Popup.txt_data_OrganizationLevel.Text = (dr.Cells["col_ORGANIZATION_LEVEL"].Value.ToString() != null) ? dr.Cells["col_ORGANIZATION_LEVEL"].Value.ToString() : "";

                if (m_Popup.ShowDialog() == DialogResult.OK)
                {
                    Load_Data();
                }
            }
        }

        protected override void Do_Delete()
        {
            if (GRID_DATA.SelectedRows.Count > 0)
            {
                if (GBTSCCommon.Message_Confirm(GBTSCConstants.MSG_DELETE_CONFIRM, GBTSCConstants.MSG_CAPTION_DELETE) == DialogResult.Yes)
                {
                    int objID = Convert.ToInt32(GRID_DATA.SelectedRows[0].Cells["col_ID"].Value);

                    // Check the conditions before deleting

                    //Delete
                    DMORGANIZATIONController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            DataTable dt = DMORGANIZATIONController.Instance().Search_DS(KEY_WORD);
            GRID_DATA.DataSource = dt;
            DATA_COUNT = dt.Rows.Count.ToString();
        }

        // Override if need
        protected override void Do_Export_Excel()
        {
            base.Do_Export_Excel();
        }

        // Override if need
        protected override void Do_Print()
        {
            base.Do_Print();
        }
    }
}
