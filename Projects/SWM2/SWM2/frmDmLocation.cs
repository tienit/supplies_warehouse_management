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
    public partial class frmDmLocation : CommonFormAdmin
    {
        public frmDmLocation()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_LOCATION";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("LOCATION_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("LOCATION_ORDER", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("LOCATION_PARENT_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("LOCATION_LEVEL", GIRD_COLUMN_TYPE.TextBox));
        }

        protected override void Do_Add()
        {
            frmDmLocationPopup m_Popup = new frmDmLocationPopup();
            m_Popup.Text = "Thêm địa điểm";
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
                frmDmLocationPopup m_Popup = new frmDmLocationPopup();
                m_Popup.Text = "Cập nhật địa điểm";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();                
                m_Popup.txt_data_locationname.Text = (string)dr.Cells["col_LOCATION_NAME"].Value;
                m_Popup.txt_data_order.Text = (dr.Cells["col_LOCATION_ORDER"].Value != null) ? dr.Cells["col_LOCATION_ORDER"].Value.ToString() : "";
                m_Popup.txt_data_LocationParrentID.Text = (dr.Cells["col_LOCATION_PARENT_ID"].Value != null) ? dr.Cells["col_LOCATION_PARENT_ID"].Value.ToString() : "";
                m_Popup.txt_data_LocationLevel.Text = (dr.Cells["col_LOCATION_LEVEL"].Value != null) ? dr.Cells["col_LOCATION_LEVEL"].Value.ToString() : "";
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
                    DMLOCATIONController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            DataTable dt = DMLOCATIONController.Instance().Search_DS(KEY_WORD);
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
