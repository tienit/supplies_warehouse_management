using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;
using tienit.core;
using VKTIM.Common;

namespace VKTIM
{
    public partial class frmDtInputDrugList : Form
    {
        //
        private DTDRUGINPUTInfo MAIN_DRUG_INPUT = new DTDRUGINPUTInfo();
        private DataTable DRUG_INPUT_LIST = new DataTable();

        public frmDtInputDrugList()
        {
            InitializeComponent();
            DRUG_INPUT_LIST = DTDRUGINPUTLISTController.Instance().GetTop0Row();
        }
        public frmDtInputDrugList(int DrugInputID)
        {
            InitializeComponent();
            this.MAIN_DRUG_INPUT = DTDRUGINPUTController.Instance().GetById(DrugInputID);
            DRUG_INPUT_LIST = DTDRUGINPUTLISTController.Instance().GetDrugListByInputID(DrugInputID);
        }
        private void frmDtInputDrugList_Load(object sender, EventArgs e)
        {
            grc_Main.DataSource = DRUG_INPUT_LIST;
            grc_MainExtra.DataSource = DRUG_INPUT_LIST;

            //warehouse combobox
            foreach (DMWAREHOUSEInfo item in DMWAREHOUSEController.Instance().GetAll())
            {
                cbb_DRUG_WAREHOUSE_NAME.Properties.Items.Add(item.WAREHOUSE_NAME);
            }
            //search combobox 
            foreach (string item in DMDRUGController.Instance().GetDmDrugColumnName())
            {
                cbb_SearchField.Properties.Items.Add(item);
            }
            // ORGANIZATION combobox
            foreach (DMORGANIZATIONInfo  item in DMORGANIZATIONController.Instance().GetAll())
            {
                cbb_ORGANIZATION_NAME.Properties.Items.Add(item.ORGANIZATION_NAME);
            }

            foreach (DTFUNDSInfo item in DTFUNDSController.Instance().GetAll())
            {
                cbb_FUNDS_NAME.Properties.Items.Add(item.FUNDS_NAME);
            }

            //update form
            if (this.MAIN_DRUG_INPUT.ID > 0)
            {
                dte_CREATED_DATE.Text = MAIN_DRUG_INPUT.CREATED_DATE.ToShortDateString();
                txt_DRUG_INPUT_CODE.Text = MAIN_DRUG_INPUT.DRUG_INPUT_CODE;
                cbb_DRUG_WAREHOUSE_NAME.Text = MAIN_DRUG_INPUT.DRUG_WAREHOUSE_NAME;
                txt_FUNDS_ID.Text = MAIN_DRUG_INPUT.FUNDS_ID.ToString();
                cbb_FUNDS_NAME.Text = MAIN_DRUG_INPUT.FUNDS_NAME;
                txt_INPUT_NAME.Text = MAIN_DRUG_INPUT.INPUT_NAME;
                txt_ORGANIZATION_ID.Text = MAIN_DRUG_INPUT.ORGANIZATION_ID.ToString();
                cbb_ORGANIZATION_NAME.Text = MAIN_DRUG_INPUT.ORGANIZATION_NAME;
                txt_TOTAL.Text = MAIN_DRUG_INPUT.TOTAL.ToString();

                DRUG_INPUT_LIST = DTDRUGINPUTLISTController.Instance().GetDrugListByInputID(MAIN_DRUG_INPUT.ID);
                grc_Main.DataSource = DRUG_INPUT_LIST;
                txt_TOTAL.Text = MAIN_DRUG_INPUT.TOTAL.ToString();

                cbb_SearchField.SelectedIndex = 1;//DRUG_NAME
            }
            else//new form
            {
                txt_DRUG_INPUT_CODE.Text = Convert.ToString(DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond);
                cbb_SearchField.SelectedIndex = 1;//DRUG_NAME
                cbb_DRUG_WAREHOUSE_NAME.SelectedIndex = 0;//firt warehouse
                cbb_ORGANIZATION_NAME.SelectedIndex = 0;
                cbb_FUNDS_NAME.SelectedIndex = 0;
                dte_CREATED_DATE.Text = DateTime.Now.ToShortDateString();
            }




        }

        private void txt_SearchKeyword_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_SearchKeyword.Text.Trim() != "" && txt_SearchKeyword.Text.Length > 1)
                grc_Search.DataSource = DMDRUGController.Instance().SearchWithParameterCustomColumn(cbb_SearchField.SelectedItem.ToString(),txt_SearchKeyword.Text);
        }

        private void grv_Search_DoubleClick(object sender, EventArgs e)
        {
            DataRow currenRow = grv_Search.GetDataRow(grv_Search.FocusedRowHandle);
            int forucssedMainRowHanle = grv_Main.LocateByValue("DRUG_CODE", currenRow["DRUG_CODE"]);

            if (!(forucssedMainRowHanle >= 0))//pass duplicate drug
            {
                DRUG_INPUT_LIST.ImportRow(currenRow);
                grc_MainExtra.DataSource = DRUG_INPUT_LIST;
            }

            grv_Main.FocusedRowHandle = grv_Main.LocateByValue("DRUG_CODE", currenRow["DRUG_CODE"]);
            grv_Main.FocusedColumn = grv_Main.Columns["INPUT_VALUE"];
            grv_Main.ShowEditor();

        }

        private void grv_Main_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TOTAL_VALUE")
            {
                try//cell value maybe null
                {
                    double quantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["QUANTITY"]));
                    double inputQuantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["INPUT_VALUE"]));
                    double total_value = quantity + inputQuantity;
                    DRUG_INPUT_LIST.Rows[e.ListSourceRowIndex]["TOTAL_VALUE"] = total_value;
                    e.DisplayText = string.Format("{0:#,##0}", total_value);            

                }
                catch// (Exception)
                {

                    //  throw;
                }

            }

            if (e.Column.FieldName == "INPUT_VALUE")
            {
                try
                {
                    e.DisplayText = string.Format("{0:#,##0}", Convert.ToDouble(e.Value));
                }
                catch// (Exception)
                {

                    // throw;
                }

            }
        }

        private void grv_MainExtra_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TOTAL_VALUE")
            {
                try//cell value maybe null
                {
                    double quantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["QUANTITY"]));
                    double inputQuantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["INPUT_VALUE"]));
                    double total_value = quantity + inputQuantity;
                    e.DisplayText = string.Format("{0:#,##0}", total_value);
                }
                catch// (Exception)
                {

                    //  throw;
                }

            }
            if (e.Column.FieldName == "TOTAL_INPUT")
            {
                try//cell value maybe null
                {
                    double price = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["UNIT_PRICE"]));
                    double inputQuantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["INPUT_VALUE"]));
                    double total_input = price * inputQuantity;
                    DRUG_INPUT_LIST.Rows[e.ListSourceRowIndex]["TOTAL_INPUT"] = total_input;
                    e.DisplayText = string.Format("{0:#,##0}", total_input);
                    
                    txt_TOTAL.Text = string.Format("{0:#,##0}", Convert.ToDouble(grv_MainExtra.Columns["TOTAL_INPUT"].SummaryItem.SummaryValue));
                }
                catch// (Exception)
                {

                    //  throw;
                }

            }

            if (e.Column.FieldName == "TOTAL_AFTER")
            {
                try//cell value maybe null
                {
                    double price = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["UNIT_PRICE"]));

                    double quantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["QUANTITY"]));
                    double inputQuantity = Convert.ToDouble(grv_Main.GetRowCellValue(e.ListSourceRowIndex, grv_Main.Columns["INPUT_VALUE"]));
                    double total_after = price * (quantity + inputQuantity);
                    DRUG_INPUT_LIST.Rows[e.ListSourceRowIndex]["TOTAL_AFTER"] = total_after;
                    e.DisplayText = string.Format("{0:#,##0}", total_after);
                    
                }
                catch// (Exception)
                {

                    //  throw;
                }

            }

            if (e.Column.FieldName == "INPUT_VALUE")
            {
                try
                {
                    e.DisplayText = string.Format("{0:#,##0}", Convert.ToDouble(e.Value));
                }
                catch //(Exception)
                {

                    //throw;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //DRUG INPUT STICK
            //
            //
            MAIN_DRUG_INPUT.CREATED_DATE = GBTSCCommon.ObjectToDate( dte_CREATED_DATE.Text);
            MAIN_DRUG_INPUT.DRUG_INPUT_CODE = txt_DRUG_INPUT_CODE.Text;
            MAIN_DRUG_INPUT.DRUG_WAREHOUSE_NAME = cbb_DRUG_WAREHOUSE_NAME.Text;
            MAIN_DRUG_INPUT.FUNDS_NAME = cbb_FUNDS_NAME.Text;
            MAIN_DRUG_INPUT.INPUT_NAME = txt_INPUT_NAME.Text;
            MAIN_DRUG_INPUT.ORGANIZATION_NAME = cbb_ORGANIZATION_NAME.Text;
            MAIN_DRUG_INPUT.TOTAL = GBTSCCommon.OjectToDouble(txt_TOTAL.Text);
            //MAIN_DRUG_INPUT.USER_NAME = GBTSCConstants.CURRENT_USER.USER_NAME;

            //input object
            if (MAIN_DRUG_INPUT.ID > 0)//update
            {
                int i_up = DTDRUGINPUTController.Instance().Update(MAIN_DRUG_INPUT);
            }
            else
            {
                MAIN_DRUG_INPUT = DTDRUGINPUTController.Instance().Insert(MAIN_DRUG_INPUT);
            }

            //
            //DRUG LIST of DRUG STICK
            //
            foreach (DataRow row in DRUG_INPUT_LIST.Rows)
            {
                DTDRUGINPUTLISTInfo drugItem = new DTDRUGINPUTLISTInfo();
                //drugItem.CATEGORY_NAME = row["CATEGORY_NAME"].ToString();
                //drugItem.COMPANY = row["COMPANY"].ToString();
                //drugItem.COUNTRY = row["COUNTRY"].ToString();
                //drugItem.CREATED_DATE = GBTSCCommon.ObjectToDate(row["CREATED_DATE"].ToString());
                drugItem.DRUG_CODE = row["DRUG_CODE"].ToString();
                //drugItem.DRUG_DESCRIPTION = row["DRUG_DESCRIPTION"].ToString();
                drugItem.DRUG_ID = GBTSCCommon.OjectToInteger32(row["DRUG_ID"].ToString());
                drugItem.DRUG_INPUT_ID = MAIN_DRUG_INPUT.ID;
                drugItem.DRUG_NAME = row["DRUG_NAME"].ToString();
                //drugItem.EXPERIED_DATE = GBTSCCommon.ObjectToDate(row["EXPERIED_DATE"].ToString());
                //drugItem.IMAGE = row["IMAGE"].ToString();
                drugItem.INPUT_VALUE = GBTSCCommon.OjectToDouble(row["INPUT_VALUE"].ToString());
                //drugItem.PRODUCT_DATE = GBTSCCommon.ObjectToDate(row["PRODUCT_DATE"].ToString());
                drugItem.QUANTITY = GBTSCCommon.OjectToDouble(row["QUANTITY"].ToString());
                //drugItem.SORT = GBTSCCommon.OjectToInteger32(row["SORT"].ToString());
                //drugItem.STATUS = Convert.ToBoolean(row[""].ToString());
                drugItem.TOTAL_VALUE = GBTSCCommon.OjectToDouble(row["TOTAL_VALUE"].ToString());
                drugItem.UNIT_NAME = row["UNIT_NAME"].ToString();
                drugItem.UNIT_PRICE = GBTSCCommon.OjectToDouble(row["UNIT_PRICE"].ToString());
                drugItem.ID = GBTSCCommon.OjectToInteger32(row["ID"].ToString());
                drugItem.TOTAL_INPUT = GBTSCCommon.OjectToDouble(row["TOTAL_INPUT"].ToString());
                drugItem.TOTAL_AFTER = GBTSCCommon.OjectToDouble(row["TOTAL_AFTER"].ToString());

                if (drugItem.ID > 0)
                {                    
                    //update quantity to store
                    drugItem.SAVE_STORE_SUCCESS = SaveQuantityToStore(drugItem);
                    DTDRUGINPUTLISTController.Instance().Update(drugItem);//update db
                    this.Close();
                }
                else
                {
                    //update quantity to store
                    drugItem.SAVE_STORE_SUCCESS = SaveQuantityToStore(drugItem);
                    DTDRUGINPUTLISTController.Instance().Insert(drugItem);//insert db
                    this.Close();
                }
            }
        }

        private bool SaveQuantityToStore(DTDRUGINPUTLISTInfo drugItem)
        {
            //Quantity From Store
            DMDRUGInfo drugStore = DMDRUGController.Instance().GetById(drugItem.DRUG_ID);

            //Compare From Store With drugItem
            if (drugItem.QUANTITY == drugStore.QUANTITY)//synchronized
            {
                //Update Store
                DMDRUGController.Instance().SaveStore(drugItem.DRUG_ID, drugItem.QUANTITY + drugItem.INPUT_VALUE);
                return true;
            }
            else//fail
            { 
                MessageBox.Show(string.Format("Giá trị tồn kho {0} không đồng bộ! Store={1};New={2}", drugItem.DRUG_NAME, drugStore.QUANTITY, drugItem.QUANTITY));
            }
            return false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
