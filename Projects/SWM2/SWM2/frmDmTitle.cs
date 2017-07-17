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
    }
}
