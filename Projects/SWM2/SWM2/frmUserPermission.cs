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
    public partial class frmUserPermission : CommonForm
    {
        public frmUserPermission()
        {
            InitializeComponent();
        }

        private void frmUserPermission_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Forms();
                Load_Roles();
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Load_Roles()
        {
            tv_data_role.Nodes.Clear();
            DataTable dt = HTROLEController.Instance().GetAll_DS().Tables[0];
            if (dt.Rows.Count > 0)
            {
                TreeNode temp;
                foreach (DataRow dr in dt.Rows)
                {
                    temp = new TreeNode(dr["ROLE_NAME"].ToString());
                    temp.Tag = dr["ID"];
                    temp.ToolTipText = dr["ROLE_DESCRIPTION"].ToString();
                    tv_data_role.Nodes.Add(temp);
                }
                tv_data_role.Nodes[0].Checked = true;
                tv_data_role.Nodes[0].BackColor = Color.Gray;
                gb_dis_role.Tag = tv_data_role.Nodes[0].Tag;
                tv_data_role.SelectedNode = tv_data_role.Nodes[0];
            }
        }

        private void Load_Forms()
        {
            DataTable dt = HTFORMController.Instance().GetUsed_DS();
            dgv_data_form.DataSource = dt;
            lbl_data_count.Tag = dt.Rows.Count;
        }

        private void tv_data_role_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                foreach (TreeNode n in tv_data_role.Nodes)
                {
                    n.BackColor = tv_data_role.BackColor;
                }
                e.Node.BackColor = Color.Gray;
                
                gb_dis_role.Tag = e.Node.Tag;
                gb_dis_role.AccessibleDescription = e.Node.Text;
                
                //Load Permission
                LoadPermission(Convert.ToInt32(e.Node.Tag), e.Node.Text);
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void SetCheckByCellValue(string colNames, string cellValue)
        {
            Bitmap bmpSelect = new Bitmap(Properties.Resources.e_icon_select_24);
            foreach (DataGridViewRow dr in dgv_data_form.Rows)
            {
                if (dr.Cells[colNames].Value.ToString().Equals(cellValue))
                {
                    dr.Cells["colImg"].Value = bmpSelect;
                    break;
                }
            }
        }

        private void LoadPermission(int roleID, string roleName)
        {
            UnSelectAll();

            dgv_data_form.ReadOnly = false;
            btn_Refresh.Enabled = true;
            btn_SelectAll.Enabled = true;
            btn_UnSelectAll.Enabled = true;
            btn_Save.Enabled = true;

            List<HTFORMInfo> lstForm = HTFORMController.Instance().GetByRole(roleID);
            lbl_data_count.Text = String.Format("{0}/{1}", lstForm.Count.ToString(), lbl_data_count.Tag.ToString());
            if (lstForm.Count > 0)
            {
                foreach (HTFORMInfo fInfo in lstForm)
                {
                    SetCheckByCellValue("col_ID", fInfo.ID.ToString());
                }
            }
            else
            {
                UnSelectAll();
            }
        }

        private void SelectAll()
        {
            Bitmap bmpSelect = new Bitmap(Properties.Resources.e_icon_select_24);
            foreach (DataGridViewRow dr in dgv_data_form.Rows)
            {
                dr.Cells["colImg"].Value = bmpSelect;
            }
        }

        private void UnSelectAll()
        {
            Bitmap bmpUnselect = new Bitmap(Properties.Resources.e_icon_unselect_24);
            foreach (DataGridViewRow dr in dgv_data_form.Rows)
            {
                dr.Cells["colImg"].Value = bmpUnselect;
            }
        }

        private bool SavePermission()
        {
            try
            {
                Bitmap bmpSelect = new Bitmap(Properties.Resources.e_icon_select_24);
                int roleID = Convert.ToInt32(gb_dis_role.Tag);
                HTROLEFORMController.Instance().DeleteByRole(roleID);
                HTROLEFORMInfo rfInfo;

                foreach (DataGridViewRow dr in dgv_data_form.Rows)
                {
                    var cellValue = dr.Cells["colImg"].Value as Bitmap;
                    if (GBTSCCommon.CompareBitmap(cellValue,bmpSelect) == GBTSCCommon.CompareResult.ciCompareOk)
                    {
                        rfInfo = new HTROLEFORMInfo();
                        rfInfo.FORM_ID = Convert.ToInt32(dr.Cells["col_ID"].Value);
                        rfInfo.ROLE_ID = roleID;
                        HTROLEFORMController.Instance().Insert(rfInfo);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPermission(Convert.ToInt32(gb_dis_role.Tag), gb_dis_role.AccessibleDescription);
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void btn_UnSelectAll_Click(object sender, EventArgs e)
        {
            UnSelectAll();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (SavePermission())
                {
                    GBTSCCommon.Message_Info("Thiết lập phân quyền đã được lưu thành công.", "GRANT PERMISSION", GBTSCCommon.MessageType.Message_OK);
                }
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void dgv_data_form_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_data_form.Columns[e.ColumnIndex].Name.Equals("colImg"))
                {
                    //MessageBox.Show("Hello");
                    var imageCell = dgv_data_form.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                    var cellValue = imageCell.Value as Bitmap;
                    Bitmap bmpSelect = new Bitmap(Properties.Resources.e_icon_select_24);
                    Bitmap bmpUnselect = new Bitmap(Properties.Resources.e_icon_unselect_24);
                    if (GBTSCCommon.CompareBitmap(cellValue, bmpSelect) == GBTSCCommon.CompareResult.ciCompareOk)
                    {
                        imageCell.Value = bmpUnselect;
                    }
                    else if (GBTSCCommon.CompareBitmap(cellValue, bmpUnselect) == GBTSCCommon.CompareResult.ciCompareOk)
                    {
                        imageCell.Value = bmpSelect;
                    }
                }
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }
    }
}
