using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tienit.core;
using VKTIM.Component;

namespace VKTIM
{
    public partial class frmDmInputBill : Form
    {
        public frmDmInputBill()
        {
            InitializeComponent();
        }

        private void frmDmInputBill_Load(object sender, EventArgs e)
        {
            //grcMain.DataSource = DTINPUTController.Instance().GetAll_DS().Tables[0];
            grcMain.DataSource = DTINPUTController.Instance().GetAll();
        }

        private void grvMain_DoubleClick(object sender, EventArgs e)
        {
            DTINPUTInfo inputRow = (DTINPUTInfo)grvMain.GetRow(grvMain.FocusedRowHandle);

            frmGridControlCopyPaste f = new frmGridControlCopyPaste(inputRow);
            f.Show();
        }
    }
}
