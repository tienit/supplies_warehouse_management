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
    public partial class frmHtForm : CommonFormAdmin
    {
        public frmHtForm()
        {
            InitializeComponent();
        }

        protected override void Init_Components()
        {
            _TABLE_NAME = "HT_FORM";
            _ARR_FILE_NAME = new List<GridLayoutInfo>();
            _ARR_FILE_NAME.Add(new GridLayoutInfo("ID", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("FORM_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("FORM_TITLE", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("FORM_TITLE_EN", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("MENU_NAME", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("IS_SHOW_DIALOG", GIRD_COLUMN_TYPE.CheckBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("SHORTCUT_KEY", GIRD_COLUMN_TYPE.TextBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("IS_USED", GIRD_COLUMN_TYPE.CheckBox));
            _ARR_FILE_NAME.Add(new GridLayoutInfo("FORM_ORDER", GIRD_COLUMN_TYPE.TextBox));
        }

        protected override void Do_Add()
        {
            frmHtFormPopup m_Popup = new frmHtFormPopup();
            m_Popup.Text = "Thêm chức năng";
            m_Popup.ACTION_TYPE = ACTION_TYPE.AddNew;
            m_Popup.cmb_data_shortcut_key.DataSource = Enum.GetNames(typeof(Keys));
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
                frmHtFormPopup m_Popup = new frmHtFormPopup();
                m_Popup.Text = "Cập nhật chức năng";
                m_Popup.ACTION_TYPE = ACTION_TYPE.Update;
                m_Popup.txt_data_id.Text = dr.Cells["col_ID"].Value.ToString();
                m_Popup.txt_data_name.Text = (string)dr.Cells["col_FORM_NAME"].Value;
                m_Popup.txt_data_title.Text = (string)dr.Cells["col_FORM_TITLE"].Value;
                m_Popup.txt_data_title_en.Text = (string)dr.Cells["col_FORM_TITLE_EN"].Value;
                m_Popup.txt_data_menu_name.Text = (string)dr.Cells["col_MENU_NAME"].Value;
                m_Popup.chk_data_show_dialog.Checked = Convert.ToBoolean(dr.Cells["col_IS_SHOW_DIALOG"].Value);
                m_Popup.cmb_data_shortcut_key.DataSource = Enum.GetNames(typeof(Keys));
                SetKeysDataForControl(m_Popup.chk_data_ctrl, m_Popup.chk_data_shift, m_Popup.chk_data_alt, m_Popup.cmb_data_shortcut_key, (string)dr.Cells["col_SHORTCUT_KEY"].Value);
                m_Popup.chk_data_used.Checked = Convert.ToBoolean(dr.Cells["col_IS_USED"].Value);
                m_Popup.nud_data_order.Value = Convert.ToDecimal(dr.Cells["col_FORM_ORDER"].Value);

                if (m_Popup.ShowDialog() == DialogResult.OK)
                {
                    Load_Data();
                }
            }
        }

        private void SetKeysDataForControl(CheckBox chkCtrl, CheckBox chkShift, CheckBox chkAlt, ComboBox cmbKeys, string data)
        {
            chkCtrl.Checked = false;
            chkShift.Checked = false;
            chkAlt.Checked = false;
            if (data.Equals(""))
            {
                cmbKeys.SelectedIndex = 0;
            }
            else
            {
                string[] arrKeys = data.Split(Convert.ToChar("+"));
                if (arrKeys.Length > 0)
                {
                    if (arrKeys.Length == 1)
                    {
                        cmbKeys.SelectedItem = arrKeys[0];
                    }
                    else if (arrKeys.Length == 2)
                    {
                        cmbKeys.SelectedItem = arrKeys[1];
                        if (arrKeys[0].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }
                    }
                    else if (arrKeys.Length == 3)
                    {
                        cmbKeys.SelectedItem = arrKeys[2];
                        if (arrKeys[0].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }

                        if (arrKeys[1].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[1].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[1].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }
                    }
                    else if (arrKeys.Length == 4)
                    {
                        cmbKeys.SelectedItem = arrKeys[3];
                        if (arrKeys[0].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[0].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }

                        if (arrKeys[1].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[1].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[1].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }

                        if (arrKeys[2].Equals("Control"))
                        {
                            chkCtrl.Checked = true;
                        }
                        else if (arrKeys[2].Equals("Shift"))
                        {
                            chkShift.Checked = true;
                        }
                        else if (arrKeys[2].Equals("Alt"))
                        {
                            chkAlt.Checked = true;
                        }
                    }
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
                    HTFORMController.Instance().Delete(objID);
                }
            }
        }

        protected override void Do_Search()
        {
            // Replace DMUNITController by corresponding Controller
            DataTable dt = HTFORMController.Instance().Search_DS(KEY_WORD);
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
