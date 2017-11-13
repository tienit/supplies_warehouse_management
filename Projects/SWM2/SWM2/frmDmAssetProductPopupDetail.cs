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
    public partial class frmDmAssetProductPopupDetail : Form
    {
        //table main
        private DataTable Main_Datatable = DMASSETPRODUCTSController.Instance().GetTop0Row();

        public frmDmAssetProductPopupDetail()
        {
            InitializeComponent();
        }

        private void frmDmAssetProductPopupDetail_Load(object sender, EventArgs e)
        {
            this.Main_Datatable.Columns.Add("QUANTITY_IN");
            this.Main_Datatable.Columns.Add("TOTAL");
            this.Main_Datatable.Rows.Add(Main_Datatable.NewRow());
            grc_Main.DataSource = this.Main_Datatable;

            //repositoryItemGridLookUpEdit1.DataSource = DMASSETPRODUCTSController.Instance().GetAll_DS().Tables[0];
            lookupProduct.DataSource = DMASSETPRODUCTSController.Instance().GetAll_DS().Tables[0];
        }

        private void lookupProduct_EditValueChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
            //    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;

            //    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_CODE", row["ASSET_CODE"]);
            //    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "QUANTITY", row["QUANTITY"]);
            //    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "UNIT_NAME", row["UNIT_NAME"]);
            //    grv_Main.FocusedColumn = grv_Main.Columns["QUANTITY_IN"];
            //    grv_Main.ShowEditor();
            //    //MessageBox.Show(value.ToString());
            //}
            //catch //(Exception)
            //{

            //    // throw;
            //}

        }

        private void grv_Main_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "QUANTITY_IN")
            {
                grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "TOTAL", string.Format("{0}", Convert.ToDecimal(grv_Main.GetRowCellValue(e.RowHandle, "QUANTITY_IN")) + Convert.ToDecimal(grv_Main.GetRowCellValue(e.RowHandle, "QUANTITY"))));
            }

            if (e.Column.FieldName == "ASSET_CODE" && grv_Main.GetRowCellValue(e.RowHandle, "ASSET_CODE").ToString().Length >= 3)
            {
                List<DMASSETPRODUCTSInfo> product = DMASSETPRODUCTSController.Instance().GetProductByCode(grv_Main.GetRowCellValue(e.RowHandle, "ASSET_CODE").ToString().Trim());
                if (product.Count > 0)
                {

                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ID", product[0].ID);
                    //grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_CODE", product[0].ASSET_CODE);
                    lookupProduct.ImmediatePopup = false;
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_NAME", product[0].ASSET_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_ONAME", product[0].ASSET_ONAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_DESCRIPTION", product[0].ASSET_DESCRIPTION);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "MANUFACTURER_NAME", product[0].MANUFACTURER_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "MANUFACTURER_ID", product[0].MANUFACTURER_ID);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "UNIT_NAME", product[0].UNIT_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "UNIT_ID", product[0].UNIT_ID);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "PRICE", product[0].PRICE);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "CATEGORY_ID", product[0].CATEGORY_ID);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "CATEGORY_NAME", product[0].CATEGORY_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "EXPIRED_DATE", product[0].EXPIRED_DATE);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "STARTED_DATE", product[0].STARTED_DATE);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "CREATED_DATE", product[0].CREATED_DATE);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "USER_ID", product[0].USER_ID);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "USER_NAME", product[0].USER_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "QUANTITY", product[0].QUANTITY);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "LAST_IN", product[0].LAST_IN);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "LAST_OUT", product[0].LAST_OUT);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_LEVEL_ID", product[0].ASSET_LEVEL_ID);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "ASSET_LEVEL_NAME", product[0].ASSET_LEVEL_NAME);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "COUNTRY", product[0].COUNTRY);
                    grv_Main.SetRowCellValue(grv_Main.FocusedRowHandle, "WEIGHT", product[0].WEIGHT);
                }

                if (e.Column.FieldName == "ASSET_NAME")
                {

                }
            }

            AutoInsertBottomNewRow();
        }

        private void AutoInsertBottomNewRow()
        {
            DataRow row = this.Main_Datatable.Rows[this.Main_Datatable.Rows.Count - 1];
            for (int i = 0; i < this.Main_Datatable.Columns.Count; i++)
            {
                if (row[i].ToString() != "")
                {
                    this.Main_Datatable.Rows.Add(Main_Datatable.NewRow());
                    return;
                }                
            }
        }

        private void grv_Main_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //int rowIndex = e.ListSourceRowIndex;
            //decimal quantity = Convert.ToDecimal(grv_Main.GetListSourceRowCellValue(rowIndex,"QUANTITY"));
            //decimal quantity_in = Convert.ToDecimal(grv_Main.GetListSourceRowCellValue(rowIndex, "QUANTITY_IN"));
            //if (e.Column.FieldName == "TOTAL") return;
            //if (e.IsGetData)
            //    e.Value = quantity + quantity_in;

        }

        private void grv_Main_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }
    }
}
