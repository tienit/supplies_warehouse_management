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
    public partial class frmDmSupplier : CommonFormAdmin
    {
        public frmDmSupplier()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_SUPPLIER";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_DESCRIPTION", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_SHORTNAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_ADDRESS", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_DIRECTOR", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_MST", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PARENT_ID", GIRD_COLUMN_TYPE.TextBox));
        }

        protected override void Do_Add()
        {
            frmDmSupplierPopup m_Popup = new frmDmSupplierPopup();
            m_Popup.Text = "Thêm đối tác";
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
                frmDmSupplierPopup m_Popup = new frmDmSupplierPopup();
                m_Popup.Text = "Cập nhật đối tác";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_name.Text = (dr.Cells["col_SUPPLIER_NAME"].Value != null ) ? dr.Cells["col_SUPPLIER_NAME"].Value.ToString() : "";
                m_Popup.txt_data_shortname.Text = (dr.Cells["col_SUPPLIER_SHORTNAME"].Value != null) ? dr.Cells["col_SUPPLIER_SHORTNAME"].Value.ToString() : "";
                m_Popup.txt_data_description.Text = (dr.Cells["col_SUPPLIER_DESCRIPTION"].Value != null) ? dr.Cells["col_SUPPLIER_DESCRIPTION"].Value.ToString() : "";
                m_Popup.txt_data_ParentID.Text = (dr.Cells["col_PARENT_ID"].Value != null) ? dr.Cells["col_PARENT_ID"].Value.ToString() : "";
                m_Popup.txt_data_Director.Text = (dr.Cells["col_SUPPLIER_DIRECTOR"].Value != null) ? dr.Cells["col_SUPPLIER_DIRECTOR"].Value.ToString() : "";
                m_Popup.txt_data_MST.Text = (dr.Cells["col_SUPPLIER_MST"].Value != null) ? dr.Cells["col_SUPPLIER_MST"].Value.ToString() : "";
                m_Popup.txt_data_Address.Text = (dr.Cells["col_SUPPLIER_ADDRESS"].Value != null) ? dr.Cells["col_SUPPLIER_ADDRESS"].Value.ToString() : "";
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
                    DMSUPPLIERController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            // Replace DMUNITController by corresponding Controller
            DataTable dt = DMSUPPLIERController.Instance().Search_DS(KEY_WORD);
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
