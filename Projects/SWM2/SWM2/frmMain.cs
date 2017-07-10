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

        
    }
}
