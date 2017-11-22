using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;

namespace VKTIM
{
    public partial class frmDmDrug : Form
    {
        public frmDmDrug()
        {
            InitializeComponent();
        }

        private void frmDmDrug_Load(object sender, EventArgs e)
        {
            DataTable dt = DMDRUGController.Instance().GetAll_DS().Tables[0];
            dt.Columns.Add("TOTAL");
            grc_Main.DataSource = dt;
        }

        private void grv_Main_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

                if (e.Column.FieldName == "TOTAL")
                {
                    double price = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["UNIT_PRICE"]));
                    double quantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["QUANTITY"]));
                    e.DisplayText = string.Format("{0:#,##0}", price * quantity);
                }
        }

        private void grv_Main_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

        }

        private void bar_btn_AddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void grv_Main_DoubleClick(object sender, EventArgs e)
        {
            frmDmDrugPopup f = new frmDmDrugPopup(Convert.ToInt32( grv_Main.GetRowCellValue(grv_Main.FocusedRowHandle, grv_Main.Columns["ID"])));
            f.Show();
        }
    }
}
