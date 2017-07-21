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
    }
}
