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
    public partial class frmUsers : CommonForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Roles_CMB();
                Load_Roles();

            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Load_Roles_CMB()
        {
            DataTable dt = HTROLEController.Instance().GetAll_DS().Tables[0];
            cmb_data_user_roles.DisplayMember = "ROLE_NAME";
            cmb_data_user_roles.ValueMember = "ID";
            cmb_data_user_roles.DataSource = dt;
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

        private void tv_data_role_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                foreach (TreeNode n in tv_data_role.Nodes)
                {
                    n.BackColor = tv_data_role.BackColor;
                }
                e.Node.BackColor = Color.Gray;
                Load_Users(Convert.ToInt32(e.Node.Tag));
                gb_dis_role.Tag = e.Node.Tag;
                //Fill information to controls
                txt_data_role_id.Text = e.Node.Tag.ToString();
                HTROLEInfo roleInfo = HTROLEController.Instance().GetById(Convert.ToInt32(txt_data_role_id.Text));
                txt_data_role_name.Text = roleInfo.ROLE_NAME;
                txt_data_role_description.Text = roleInfo.ROLE_DESCRIPTION;
                chk_data_role_is_default.Checked = roleInfo.IS_DEFAULT;
                //btn_Update_Role.Enabled = roleInfo.ROLE_NAME == "ADMIN" ? false : true;
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Load_Users(int roleID)
        {
            DataTable dt = HTUSERController.Instance().GetByRole_DS(roleID);
            dgv_data_users.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                txt_data_user_id.Text = dgv_data_users.Rows[0].Cells["col_ID"].Value.ToString();
                txt_data_user_name.Text = (string)dgv_data_users.Rows[0].Cells["col_USER_NAME"].Value;
                txt_data_user_pass.Text = Crytopo.Decrypt_Rfc2898((string)dgv_data_users.Rows[0].Cells["col_PASSWORD"].Value);
                chk_data_user_is_blocked.Checked = Convert.ToBoolean(dgv_data_users.Rows[0].Cells["col_IS_BLOCKED"].Value);
                txt_data_user_remark.Text = dgv_data_users.Rows[0].Cells["col_REMARKS"].Value.ToString();
                cmb_data_user_roles.SelectedValue = dgv_data_users.Rows[0].Cells["col_ROLE_ID"].Value;
                btn_Update_User.Enabled = true;
                btn_Delete_User.Enabled = true;
            }
            else
            {
                txt_data_user_id.Text = "";
                txt_data_user_name.Text = "";
                txt_data_user_pass.Text = "";
                txt_data_user_remark.Text = "";
                btn_Update_User.Enabled = false;
                btn_Delete_User.Enabled = false;
            }
        }

        private void dgv_data_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_data_user_id.Text = dgv_data_users.Rows[e.RowIndex].Cells["col_ID"].Value.ToString();
                txt_data_user_name.Text = (string)dgv_data_users.Rows[e.RowIndex].Cells["col_USER_NAME"].Value;
                txt_data_user_pass.Text = Crytopo.Decrypt_Rfc2898((string)dgv_data_users.Rows[e.RowIndex].Cells["col_PASSWORD"].Value);
                chk_data_user_is_blocked.Checked = Convert.ToBoolean(dgv_data_users.Rows[e.RowIndex].Cells["col_IS_BLOCKED"].Value);
                txt_data_user_remark.Text = dgv_data_users.Rows[e.RowIndex].Cells["col_REMARKS"].Value.ToString();
                cmb_data_user_roles.SelectedValue = dgv_data_users.Rows[e.RowIndex].Cells["col_ROLE_ID"].Value;
            }
        }

        private void btn_Add_Role_Click(object sender, EventArgs e)
        {
            try
            {
                bool bCheck = true;
                if (txt_data_role_name.Text == null || txt_data_role_name.Text.Equals(""))
                {
                    lbl_dis_role_name.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (bCheck == false)
                {
                    return;
                }
                if (HTROLEController.Instance().CheckExisted(txt_data_role_name.Text))
                {
                    GBTSCCommon.Message_Info("Tên Vai trò đã tồn tại", "NAME EXISTED", GBTSCCommon.MessageType.Message_NG);
                    return;
                }

                HTROLEInfo roleInfo = new HTROLEInfo();
                roleInfo.ROLE_NAME = txt_data_role_name.Text;
                roleInfo.ROLE_DESCRIPTION = txt_data_role_description.Text;
                roleInfo.IS_DEFAULT = chk_data_role_is_default.Checked;

                if (HTROLEController.Instance().Insert(roleInfo) != null)
                {
                    //Reload
                    Load_Roles_CMB();
                    Load_Roles();
                }
                else
                {
                    GBTSCCommon.Message_Info(GBTSCConstants.MSG_ADD_FAILED, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Update_Role_Click(object sender, EventArgs e)
        {
            try
            {
                bool bCheck = true;
                if (txt_data_role_name.Text == null || txt_data_role_name.Text.Equals(""))
                {
                    lbl_dis_role_name.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (bCheck == false)
                {
                    return;
                }

                HTROLEInfo roleInfo = HTROLEController.Instance().GetById(Convert.ToInt32(txt_data_role_id.Text));
                if (!roleInfo.ROLE_NAME.Equals(txt_data_role_name.Text.Trim()))
                {
                    if (HTROLEController.Instance().CheckExisted(txt_data_role_name.Text))
                    {
                        GBTSCCommon.Message_Info("Tên Vai trò đã tồn tại", "NAME EXISTED", GBTSCCommon.MessageType.Message_NG);
                        return;
                    }
                }
                
                roleInfo.ROLE_NAME = txt_data_role_name.Text;
                roleInfo.ROLE_DESCRIPTION = txt_data_role_description.Text;
                roleInfo.IS_DEFAULT = chk_data_role_is_default.Checked;

                //Update
                HTROLEController.Instance().Update(roleInfo);

                //Reload
                Load_Roles_CMB();
                Load_Roles();
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            try
            {
                bool bCheck = true;
                if (txt_data_user_name.Text == null || txt_data_user_name.Text.Equals(""))
                {
                    lbl_dis_user_name.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (txt_data_user_pass.Text == null || txt_data_user_pass.Text.Equals(""))
                {
                    lbl_dis_user_pass.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (bCheck == false)
                {
                    return;
                }

                HTUSERInfo uInfo = new HTUSERInfo();
                uInfo.USER_NAME = txt_data_user_name.Text.Trim();
                uInfo.PASSWORD = Crytopo.Encrypt_Rfc2898(txt_data_user_pass.Text.Trim());
                uInfo.NUMBER_LOGIN = 0; //Initialize
                uInfo.IS_BLOCKED = chk_data_user_is_blocked.Checked;
                uInfo.REMARKS = txt_data_user_remark.Text;
                //uInfo.LAST_LOGIN = DateTime.MinValue;
                //uInfo.IP_LOGIN = String.Empty;

                uInfo = HTUSERController.Instance().Insert(uInfo);
                if (uInfo != null)
                {
                    //Add role
                    HTROLEUSERInfo ruInfo = new HTROLEUSERInfo();
                    ruInfo.ROLE_ID = Convert.ToInt32(cmb_data_user_roles.SelectedValue);
                    ruInfo.USER_ID = uInfo.ID;
                    HTROLEUSERController.Instance().Insert(ruInfo);

                    //Reload
                    Load_Users(Convert.ToInt32(gb_dis_role.Tag));
                }
                else
                {
                    GBTSCCommon.Message_Info(GBTSCConstants.MSG_ADD_FAILED, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            try
            {
                bool bCheck = true;
                if (txt_data_user_name.Text == null || txt_data_user_name.Text.Equals(""))
                {
                    lbl_dis_user_name.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (txt_data_user_pass.Text == null || txt_data_user_pass.Text.Equals(""))
                {
                    lbl_dis_user_pass.ForeColor = Color.Red;
                    bCheck = false;
                }
                if (bCheck == false)
                {
                    return;
                }
                HTUSERInfo uInfo = HTUSERController.Instance().GetById(Convert.ToInt32(txt_data_user_id.Text));
                uInfo.USER_NAME = txt_data_user_name.Text.Trim();
                uInfo.PASSWORD = Crytopo.Encrypt_Rfc2898(txt_data_user_pass.Text.Trim());
                uInfo.IS_BLOCKED = chk_data_user_is_blocked.Checked;
                uInfo.REMARKS = txt_data_user_remark.Text;

                //Update ROLE_USER
                HTROLEUSERController.Instance().DeleteByUser(uInfo.ID);
                HTROLEUSERInfo ruInfo = new HTROLEUSERInfo();
                ruInfo.ROLE_ID = Convert.ToInt32(cmb_data_user_roles.SelectedValue);
                ruInfo.USER_ID = uInfo.ID;
                HTROLEUSERController.Instance().Insert(ruInfo);

                //Update user
                HTUSERController.Instance().Update(uInfo);

                //Reload
                Load_Users(Convert.ToInt32(gb_dis_role.Tag));
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            try
            {
                int uID = 0;
                try
                {
                    uID = Convert.ToInt32(txt_data_user_id.Text);
                }
                catch
                {
                }
                if (uID == 0)
                {
                    GBTSCCommon.Message_Info("Chưa chọn tài khoản nào", "DELETE USER", GBTSCCommon.MessageType.Message_NG);
                    return;
                }
                if (GBTSCCommon.Message_Confirm(GBTSCConstants.MSG_DELETE_CONFIRM, GBTSCConstants.MSG_CAPTION_DELETE) == DialogResult.Yes)
                {
                    //Check condition
                    HTUSERController.Instance().Delete(uID);
                    Load_Users(Convert.ToInt32(gb_dis_role.Tag));
                }
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }
    }
}
