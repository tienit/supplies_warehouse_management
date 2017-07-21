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
    public partial class frmDmEmployer : CommonFormAdmin
    {
        public frmDmEmployer()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "DM_EMPLOYER";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("CODE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("EMPLOYER_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("EMPLOYER_SEX", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("BIRTHDAY", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("TINH_LOCATION_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("TINH_LOCATION_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("HUYEN_LOCATION_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("HUYEN_LOCATION_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("XA_LOCATION_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("XA_LOCATION_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("RANK_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("TITLE_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ORGANIZATION_ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PHONE1", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("PHONE2", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("EMAIL", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("AVATAR", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ADDRESS", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("RETRIED", GIRD_COLUMN_TYPE.TextBox));
        }

        protected override void Do_Add()
        {
            frmDmEmployerPopup m_Popup = new frmDmEmployerPopup();
            m_Popup.Text = "Thêm cán bộ";
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
                frmDmEmployerPopup m_Popup = new frmDmEmployerPopup();
                m_Popup.Text = "Cập nhật cán bộ";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_code.Text = (dr.Cells["col_CODE"].Value != null) ? dr.Cells["col_CODE"].Value.ToString() : "";
                m_Popup.txt_data_employername.Text = (dr.Cells["col_EMPLOYER_NAME"].Value != null) ? dr.Cells["col_EMPLOYER_NAME"].Value.ToString() : "";
                m_Popup.txt_data_employersex.Text = (dr.Cells["col_EMPLOYER_SEX"].Value != null) ? dr.Cells["col_EMPLOYER_SEX"].Value.ToString() : "";
                m_Popup.txt_data_birthday.Text = (dr.Cells["col_BIRTHDAY"].Value != null) ? dr.Cells["col_BIRTHDAY"].Value.ToString() : "";
                m_Popup.txt_data_tinh.Text = (dr.Cells["col_TINH_LOCATION_NAME"].Value != null) ? dr.Cells["col_TINH_LOCATION_NAME"].Value.ToString() : "";
                m_Popup.txt_data_huyen.Text = (dr.Cells["col_HUYEN_LOCATION_NAME"].Value != null) ? dr.Cells["col_HUYEN_LOCATION_NAME"].Value.ToString() : "";
                m_Popup.txt_data_xa.Text = (dr.Cells["col_XA_LOCATION_NAME"].Value != null) ? dr.Cells["col_XA_LOCATION_NAME"].Value.ToString() : "";
                m_Popup.txt_data_rank.Text = (dr.Cells["col_RANK_ID"].Value != null) ? dr.Cells["col_RANK_ID"].Value.ToString() : "";
                m_Popup.txt_data_title.Text = (dr.Cells["col_TITLE_ID"].Value != null) ? dr.Cells["col_TITLE_ID"].Value.ToString() : "";
                m_Popup.txt_data_organization.Text = (dr.Cells["col_ORGANIZATION_ID"].Value != null) ? dr.Cells["col_ORGANIZATION_ID"].Value.ToString() : "";
                m_Popup.txt_data_phone1.Text = (dr.Cells["col_PHONE1"].Value != null) ? dr.Cells["col_PHONE1"].Value.ToString() : "";
                m_Popup.txt_data_phone2.Text = (dr.Cells["col_PHONE2"].Value != null) ? dr.Cells["col_PHONE2"].Value.ToString() : "";
                m_Popup.txt_data_email.Text = (dr.Cells["col_EMAIL"].Value != null) ? dr.Cells["col_EMAIL"].Value.ToString() : "";
                m_Popup.txt_data_avatar.Text = (dr.Cells["col_AVATAR"].Value != null) ? dr.Cells["col_AVATAR"].Value.ToString() : "";
                m_Popup.txt_data_address.Text = (dr.Cells["col_ADDRESS"].Value != null) ? dr.Cells["col_ADDRESS"].Value.ToString() : "";
                m_Popup.txt_data_retried.Text = (dr.Cells["col_RETRIED"].Value != null) ? dr.Cells["col_RETRIED"].Value.ToString() : "";

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
                    DMEMPLOYERController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            DataTable dt = DMEMPLOYERController.Instance().Search_DS(KEY_WORD);
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
