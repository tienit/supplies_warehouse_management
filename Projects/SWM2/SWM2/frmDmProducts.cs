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
    public partial class frmDmProducts : CommonFormAdmin
    {
        public frmDmProducts()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_PRODUCTS";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTS_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTS_NAME_OTHER", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTS_CODE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTS_DESCRIPTION", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTS_SHORT_DESCRIPTION", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORIGIN_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORIGIN_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("UNIT_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("UNIT_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SUPPLIER_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTCATEGORY_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRODUCTCATEGORY_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PRICE_DEFAULT", GIRD_COLUMN_TYPE.TextBox));
 
        }

        protected override void Do_Add()
        {
            frmDmProductsPopup m_Popup = new frmDmProductsPopup();
            m_Popup.Text = "Thêm sản phẩm";
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
                frmDmProductsPopup m_Popup = new frmDmProductsPopup();
                m_Popup.Text = "Cập nhật sản phẩm";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_name.Text = (dr.Cells["col_PRODUCTS_NAME"].Value != null) ? dr.Cells["col_PRODUCTS_NAME"].Value.ToString() : "";
                m_Popup.txt_data_othername.Text = (dr.Cells["col_PRODUCTS_NAME_OTHER"].Value != null) ? dr.Cells["col_PRODUCTS_NAME_OTHER"].Value.ToString() : "";
                m_Popup.txt_data_code.Text = (dr.Cells["col_PRODUCTS_CODE"].Value != null) ? dr.Cells["col_PRODUCTS_CODE"].Value.ToString() : "";
                m_Popup.txt_data_description.Text = (dr.Cells["col_PRODUCTS_DESCRIPTION"].Value != null) ? dr.Cells["col_PRODUCTS_DESCRIPTION"].Value.ToString() : "";
                m_Popup.txt_data_shortdescription.Text = (dr.Cells["col_PRODUCTS_SHORT_DESCRIPTION"].Value != null) ? dr.Cells["col_PRODUCTS_SHORT_DESCRIPTION"].Value.ToString() : "";
                m_Popup.txt_data_orginid.Text = (dr.Cells["col_ORIGIN_ID"].Value != null) ? dr.Cells["col_ORIGIN_ID"].Value.ToString() : "";
                m_Popup.txt_data_orginname.Text = (dr.Cells["col_ORIGIN_NAME"].Value != null) ? dr.Cells["col_ORIGIN_NAME"].Value.ToString() : "";
                m_Popup.txt_data_unitid.Text = (dr.Cells["col_UNIT_ID"].Value != null) ? dr.Cells["col_UNIT_ID"].Value.ToString() : "";
                m_Popup.txt_data_unitname.Text = (dr.Cells["col_UNIT_NAME"].Value != null) ? dr.Cells["col_UNIT_NAME"].Value.ToString() : "";
                m_Popup.txt_data_supplierid.Text = (dr.Cells["col_SUPPLIER_ID"].Value != null) ? dr.Cells["col_SUPPLIER_ID"].Value.ToString() : "";
                m_Popup.txt_data_suppliername.Text = (dr.Cells["col_SUPPLIER_NAME"].Value != null) ? dr.Cells["col_SUPPLIER_NAME"].Value.ToString() : "";
                m_Popup.txt_data_priceid.Text = (dr.Cells["col_PRICE_ID"].Value != null) ? dr.Cells["col_PRICE_ID"].Value.ToString() : "";
                m_Popup.txt_data_pricename.Text = (dr.Cells["col_PRICE_NAME"].Value != null) ? dr.Cells["col_PRICE_NAME"].Value.ToString() : "";
                m_Popup.txt_data_categoryid.Text = (dr.Cells["col_PRODUCTCATEGORY_ID"].Value != null) ? dr.Cells["col_PRODUCTCATEGORY_ID"].Value.ToString() : "";
                m_Popup.txt_data_categoryname.Text = (dr.Cells["col_PRODUCTCATEGORY_NAME"].Value != null) ? dr.Cells["col_PRODUCTCATEGORY_NAME"].Value.ToString() : "";
                m_Popup.txt_data_pricedefault.Text = (dr.Cells["col_PRICE_DEFAULT"].Value != null) ? dr.Cells["col_PRICE_DEFAULT"].Value.ToString() : "";

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
                    DMPRODUCTSController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            // Replace DMUNITController by corresponding Controller
            DataTable dt = DMPRODUCTSController.Instance().Search_DS(KEY_WORD);
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
