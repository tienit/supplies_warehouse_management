using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;
using VKTIM.Common;

namespace VKTIM
{
    public partial class frmDtInputDrug : Form
    {
        public frmDtInputDrug()
        {
            InitializeComponent();
        }

        private void frmDtInputDrug_Load(object sender, EventArgs e)
        {
            grc_Main.DataSource = DTDRUGINPUTController.Instance().GetAll_DS().Tables[0];
        }

        private void grv_Main_DoubleClick(object sender, EventArgs e)
        {
            DTDRUGINPUTInfo selectDrugInput = DTDRUGINPUTController.Instance().GetById(Convert.ToInt32(grv_Main.GetRowCellValue(grv_Main.FocusedRowHandle, grv_Main.Columns["ID"])));

            frmDtInputDrugList f = new frmDtInputDrugList(selectDrugInput.ID);
            f.Show();
        }
    }
}
