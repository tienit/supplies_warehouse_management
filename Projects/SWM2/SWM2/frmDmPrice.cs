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
    public partial class frmDmPrice : CommonFormAdmin
    {
        public frmDmPrice()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_PRICE";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_SYMBOL", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_CODE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_MIN_VALUE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("IS_DEFAULT", GIRD_COLUMN_TYPE.CheckBox));
        }

        protected override void Do_Add()
        {
            frmDmPricePopup m_Popup = new frmDmPricePopup();
            m_Popup.Text = "Thêm giá";
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
                frmDmPricePopup m_Popup = new frmDmPricePopup();
                m_Popup.Text = "Cập nhật giá";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_name.Text = (dr.Cells["col_PRICE_NAME"].Value != null ) ? dr.Cells["col_PRICE_NAME"].Value.ToString() : "";
                m_Popup.txt_data_symbol.Text = (dr.Cells["col_PRICE_SYMBOL"].Value != null) ? dr.Cells["col_PRICE_SYMBOL"].Value.ToString() : "";
                m_Popup.txt_data_code.Text = (dr.Cells["col_PRICE_CODE"].Value != null) ? dr.Cells["col_PRICE_CODE"].Value.ToString() : "";
                m_Popup.txt_data_minvalue.Text = (dr.Cells["col_PRICE_MIN_VALUE"].Value != null) ? dr.Cells["col_PRICE_MIN_VALUE"].Value.ToString() : "";
                m_Popup.chk_data_isdefault.Checked = Convert.ToBoolean(dr.Cells["IS_DEFAULT"].Value);

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
                    DMPRICEController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            // Replace DMUNITController by corresponding Controller
            DataTable dt = DMUNITController.Instance().Search_DS(KEY_WORD);
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
