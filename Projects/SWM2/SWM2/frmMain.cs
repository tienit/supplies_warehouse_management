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
    public partial class frmMain : CommonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //textBox1.Text = Crytopo.Encrypt_Rfc2898("123456");
            GBTSCConstants.CURRENT_USER = HTUSERController.Instance().GetById(1);
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            frmDmUnit m_Frm = new frmDmUnit();
            m_Frm.ShowDialog();
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            frmDmTitle m_Frm = new frmDmTitle();
            m_Frm.ShowDialog();
        }

        private void btnEmployer_Click(object sender, EventArgs e)
        {
            frmDmEmployer m_Frm = new frmDmEmployer();
            m_Frm.ShowDialog();
              
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            frmDmLocation m_Frm = new frmDmLocation();
            m_Frm.ShowDialog();
        }

        private void btnOrganization_Click(object sender, EventArgs e)
        {
            frmDmOrganization m_Frm = new frmDmOrganization();
            m_Frm.ShowDialog();
        }

        private void btnOuputType_Click(object sender, EventArgs e)
        {
            frmDmOutputType m_Frm = new frmDmOutputType();
            m_Frm.ShowDialog();
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            frmDmOrigin m_Frm = new frmDmOrigin();
            m_Frm.ShowDialog();
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            frmDmParameter m_Frm = new frmDmParameter();
            m_Frm.ShowDialog();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            frmDmPrice m_Frm = new frmDmPrice();
            m_Frm.ShowDialog();
        }

        private void btnProductCategory_Click(object sender, EventArgs e)
        {
            frmDmProductCategory m_Frm = new frmDmProductCategory();
            m_Frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmDmProducts m_Frm = new frmDmProducts();
            m_Frm.ShowDialog();
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            frmDmRank m_Frm = new frmDmRank();
            m_Frm.ShowDialog();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            frmDmSpecial m_Frm = new frmDmSpecial();
            m_Frm.ShowDialog();
        }
    }
}
