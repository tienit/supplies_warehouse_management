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
    public partial class frmDmTitle : CommonForm
    {
        public frmDmTitle()
        {
            InitializeComponent();
        }

        private void frmDmTitle_Load(object sender, EventArgs e)
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
            DataTable dtSrc = DMTITLEController.Instance().GetAll_DS().Tables[0];
            dgv_Data.DataSource = dtSrc;
            lbl_data_count.Text = dtSrc.Rows.Count.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        /// <summary>
        /// Tìm kiếm sản phẩm
        /// </summary>
        private void SearchData()
        {
            try
            {
                DataTable dt = DMTITLEController.Instance().Search_DS(txt_data_keyword.Text);
                dgv_Data.DataSource = dt;
                lbl_data_count.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void txt_data_keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }
    }
}
