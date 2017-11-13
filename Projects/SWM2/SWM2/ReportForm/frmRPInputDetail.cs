using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmRPInputDetail : Form
    {
        public frmRPInputDetail()
        {
            InitializeComponent();
        }

        private void frmRPInputDetail_Load(object sender, EventArgs e)
        {
            dateEnd.EditValue = DateTime.Now;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (dateStart.EditValue != null)
            {
                grc_Main.DataSource = null;
                grc_Main.DataSource = DTINPUTDETAILController.Instance().SearchInventory(dateStart.DateTime.ToShortDateString(), dateEnd.DateTime.ToShortDateString());

            }

            GridView gridView = grc_Main.FocusedView as GridView;
            gridView.SortInfo.ClearAndAddRange(new GridColumnSortInfo[] {
                new GridColumnSortInfo(gridView.Columns["DATE_CREATED"], DevExpress.Data.ColumnSortOrder.Ascending)
                }, 2);

      

        }
    }
}
