using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace VKTIM
{
    public partial class frmAbout : CommonForm
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 72);
            this.lbl_dis_version.Text += " " + Application.ProductVersion;
        }
    }
}
