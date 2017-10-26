using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using VKTIM.Component;
using tienit.core;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraGrid.Views.Grid;
using VKTIM.Common;
using VKTIM.Reports;
using DevExpress.XtraReports.UI;

namespace VKTIM
{
    public partial class frmGridControlCopyPaste : Form
    {
        #region Variable
        private DataTable MainDatasrouce = DTINPUTDETAILController.Instance().GetTop0Row().Tables[0];

        private DTINPUTInfo inputMain = new DTINPUTInfo();

        #endregion

        public frmGridControlCopyPaste()
        {
            InitializeComponent();
        }



        public frmGridControlCopyPaste(DTINPUTInfo inputInfo)
        {
            this.inputMain = inputInfo;
            InitializeComponent();            
        }

        private void frmGridControlCopyPaste_Load(object sender, EventArgs e)
        {
            searchLookUpEdit1.Properties.DataSource = DMPRODUCTSController.Instance().GetAll_ForSearchItem();
    
            //Tạo 50 dòng trống trên grid
            for (int i = 1; i <= 50; i++)
            {
                DataRow r = MainDatasrouce.NewRow();
                r["Sort"] = i.ToString();
                MainDatasrouce.Rows.Add(r);

            }

            


             //left info
             //vGridControl1.DataSource = DTINPUTController.Instance().GetInputInfo(1).Tables[0];
            DataTable vgridData = DTINPUTController.Instance().GetTop0Row();
            DataRow vr = vgridData.NewRow();
            this.inputMain = DTINPUTController.Instance().GetById(this.inputMain.ID);//gọi lại lần nữa để lấy data mới nhất từ csdl

            if (this.inputMain != null)
            {
                vr["ID"] = this.inputMain.ID;
                vr["DATE_CREATED"] = String.Format("{0}", this.inputMain.DATE_CREATED);
                vr["INPUT_NAME"] = this.inputMain.INPUT_NAME;
                vr["INPUT_CODE"] = this.inputMain.INPUT_CODE;
                vr["WAREHOUSE_ID"] = this.inputMain.WAREHOUSE_ID;
                vr["WAREHOUSE_NAME"] = this.inputMain.WAREHOUSE_NAME;
                vr["EXPIRED_DATE"] = String.Format("{0}", this.inputMain.EXPIRED_DATE); 
                vr["IS_ASSET"] = this.inputMain.IS_ASSET;
                vr["USER_ID"] = this.inputMain.USER_ID;
                vr["USER_NAME"] = this.inputMain.USER_NAME;
                vr["IDNUMBER"] = this.inputMain.IDNUMBER;
                vr["IDBOOK"] = this.inputMain.IDBOOK;
                vr["CAUSE_DESCRIPTION"] = this.inputMain.CAUSE_DESCRIPTION;
                vr["FUNDS_ID"] = this.inputMain.FUNDS_ID;
                vr["FUNDS_NAME"] = this.inputMain.FUNDS_NAME;
                vr["TOTAL_VALUE"] = this.inputMain.TOTAL_VALUE;
                vr["ORGANIZATION_NAME"] = this.inputMain.ORGANIZATION_NAME;
                vr["ORGANIZATION_ID"] = this.inputMain.ORGANIZATION_ID;
            }
            else
            {
                vr["DATE_CREATED"] = DateTime.Now;
                vr["USER_NAME"] = GBTSCConstants.CURRENT_USER.USER_NAME;
                vr["ID"] = GBTSCConstants.CURRENT_USER.ID;
                vr["EXPIRED_DATE"] = DateTime.Now.AddDays(10);

            }

            vgridData.Rows.Add(vr);
            vGridControl1.DataSource = vgridData;

            DataTable funds = DTFUNDSController.Instance().GetAll_DS().Tables[0];
            for (int f = 0; f < funds.Rows.Count; f++)
            {
                repositoryItemComboBox2.Items.Add(funds.Rows[f]["FUNDS_NAME"]);
            }

            DataTable warehouse = DMWAREHOUSEController.Instance().GetAll_DS().Tables[0];
            for (int w = 0; w < warehouse.Rows.Count; w++)
            {
                repositoryItemComboBox4.Items.Add(warehouse.Rows[w]["WAREHOUSE_NAME"]);
            }

            DataTable organi = DMORGANIZATIONController.Instance().GetAll_DS().Tables[0];
            for (int o = 0; o < organi.Rows.Count; o++)
            {
                repositoryItemComboBox3.Items.Add(organi.Rows[o]["ORGANIZATION_NAME"]);
            }

            if (this.inputMain != null)
            {
                this.MainDatasrouce = DTINPUTDETAILController.Instance().GetAllByInputID(inputMain.ID);                
            }


            grc_Main.DataSource = MainDatasrouce;

        }

        private void grc_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                PasteData(Clipboard.GetText());
            }
            else if (e.KeyCode == Keys.Delete)
            {
                Delete_CellValue(grv_Main.GetSelectedCells());
            }
        }


        //Xóa cell
        private void Delete_CellValue(DevExpress.XtraGrid.Views.Base.GridCell[] cells)
        {
            splashScreenManager1.ShowWaitForm();
            foreach (DevExpress.XtraGrid.Views.Base.GridCell item in cells)
            {
                try
                {
                    grv_Main.SetRowCellValue(item.RowHandle, grv_Main.Columns[item.Column.ColumnHandle], "");
                }
                catch// (Exception)
                {
                    splashScreenManager1.CloseWaitForm();
                 //   throw;
                }
                
            }
            splashScreenManager1.CloseWaitForm();

        }

        private void PasteData(string pClipboard)
        {
            //Lấy danh sách row có trong clipboard đưa vào biến lines
            string[] lines = pClipboard.Replace("\n", "").Split('\r');

            try
            {
                DevExpress.XtraGrid.Views.Base.GridCell[] selectedCellsInGrid = grv_Main.GetSelectedCells();

                // vị trí cell đầu tiên selected trên grid
                int FIRST_ROW_SELECTED = 0;
                int FIRST_COL_SELECTED = 0;

                if (selectedCellsInGrid.Length > 0)
                {
                    FIRST_COL_SELECTED = selectedCellsInGrid[0].Column.ColumnHandle;
                    FIRST_ROW_SELECTED = selectedCellsInGrid[0].RowHandle;
                }
                else
                {
                    FIRST_COL_SELECTED = 1;
                    FIRST_ROW_SELECTED = 0;
                }
                if (FIRST_COL_SELECTED == 0)
                {
                    FIRST_COL_SELECTED = 1;// loại nếu chọn cột ID thì nhảy sang cột tên sản phẩm vì cột ID không cần paste dữ liệu
                }

                // số dòng, cột tối đa trên grid
                int MAX_COL_ON_GRID = grv_Main.VisibleColumns.Count;
                int MAX_ROW_ON_GRID = grv_Main.DataRowCount;

                // số dòng trong clipboard
                int MAX_ROW_CLIPBOARD = lines.Length;
                // số cột trong clipboard
                int MAX_COL_CLIPBOARD = GetColumnNumberInClipboard(lines);
                //int MAX_COL_CLIPBOARD = lines[0].Split('\t').Length;

                // số dòng được chọn trên grid
                int SELECTED_ROWS = grv_Main.SelectedRowsCount;
                if (SELECTED_ROWS == 0)
                {
                    SELECTED_ROWS = 1;//né lỗi không selected cell nào
                }

                // số cột được chọn trên grid
                int SELECTED_COLS;
                if (selectedCellsInGrid.Length > 0)//né lỗi không selected cell nào
                {
                    SELECTED_COLS = selectedCellsInGrid[selectedCellsInGrid.Length - 1].Column.ColumnHandle - FIRST_COL_SELECTED;
                }
                else
                {
                    SELECTED_COLS = 1;
                }

                // số dòng, cột tối đa được phép dán trên grid
                int MAX_COL_PASTE = 0;
                int MAX_ROW_PASTE = 0;

                //Các trường hợp xảy ra
                //Gọi số cột được chọn trên Grid là: SELECTED_COLS
                //Gọi số dòng được chọn trên Grid là: SELECTED_ROWS

                //Gọi số cột được trong clipboard là: MAX_COL_CLIPBOARD
                //Gọi số dòng được trong clipboard là: MAX_ROW_CLIPBOARD

                //Gọi số cột được phép paste vào grid là: MAX_COL_PASTE
                //Gọi số dòng được phép paste vào grid là: MAX_ROW_PASTE            

                //Xét trường hợp số dòng chọn lớn hơn 1
                if (SELECTED_ROWS > 1  && SELECTED_ROWS >= MAX_ROW_CLIPBOARD) 
                {
                    MAX_ROW_PASTE = MAX_ROW_CLIPBOARD;
                }
                else if (SELECTED_ROWS > 1 && SELECTED_ROWS < MAX_ROW_CLIPBOARD)
                {
                    MAX_ROW_PASTE = SELECTED_ROWS;
                }


                //Xét trường hợp chọn số cột
                if (SELECTED_COLS >= MAX_COL_CLIPBOARD && SELECTED_COLS > 1)
                {
                    MAX_COL_PASTE = MAX_COL_CLIPBOARD;
                }
                else if (SELECTED_COLS < MAX_COL_CLIPBOARD && SELECTED_COLS > 1)
                {
                    MAX_COL_PASTE = SELECTED_COLS;
                }
                else if (SELECTED_COLS <= 1 & SELECTED_ROWS == 1)
                {
                    MAX_COL_PASTE = MAX_COL_ON_GRID - FIRST_COL_SELECTED;
                }
                else if (SELECTED_COLS <= 1 & SELECTED_ROWS > 1)
                {
                    MAX_COL_PASTE = 0;
                }

                //Xét trường hợp số dòng chọn nhỏ hơn <= 1
                if (SELECTED_ROWS <= 1 && SELECTED_COLS <= 1)
                {
                    //THIEU THEM DONG
                    MAX_ROW_PASTE = MAX_ROW_CLIPBOARD;//SE BI NGOAI LE NEU SO DONG TREN GRID NHO HON SO DONG TREN CLIPBOARD
                }
                else if (SELECTED_ROWS <= 1 && SELECTED_COLS > 1)
                {
                    MAX_ROW_PASTE = SELECTED_ROWS;
                }


                splashScreenManager1.ShowWaitForm();
                //Duyệt danh sách các row trong clipboard đưa vào grid
                for (int line = 0; line < MAX_ROW_PASTE; line++)
                {
                    if (lines[line] != "")
                    {
                        string[] cells = lines[line].Split('\t');

                        for (int cell = 0; cell < cells.Length; cell++)
                        {
                            if (cell <= MAX_COL_PASTE && cell < cells.Length)
                            {
                                string cell_value = cells[cell].Trim().Replace(".","").Replace(",","") ;
                                grv_Main.SetRowCellValue(FIRST_ROW_SELECTED + line, grv_Main.Columns[FIRST_COL_SELECTED + cell], cell_value);
                            }
                        }
                    }
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);

                //splashScreenManager1.CloseWaitForm();
            }
        }

        //Kiểm tra row empty
        private bool EmptyFeild(int rowHandle, int FirstColHandle)
        {
            for (int colHandle = FirstColHandle; colHandle < grv_Main.VisibleColumns.Count; colHandle++)
            {
                try
                {
                    if (grv_Main.GetRowCellValue(rowHandle, grv_Main.Columns[colHandle]).ToString() != "")
                    {
                        return false;
                    }
                }
                catch// (Exception)
                {

                }
            }

            return true;
        }

        //Đếm số cột trong clipboard
        private int GetColumnNumberInClipboard(string[] lines)
        {
            int max = 0;

            for (int i = 0; i < lines.Length - 1; i++)
            {
                int lineLength = lines[i].Split('\t').Length;
                if (max < lineLength)
                {
                    max = lineLength;
                }
            }
            return max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            DevExpress.XtraGrid.GridControl g = new DevExpress.XtraGrid.GridControl();
            g.Dock = DockStyle.Fill;
            g.DataSource = MainDatasrouce;
            f.Controls.Add(g);
            f.Show();
        }

        private void grc_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//hủy action paste mặc định của grid
        }

        private void del_rowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grv_Main.BeginUpdate();
            try
            {
                grv_Main.DeleteSelectedRows();
            }
            finally
            {
                grv_Main.EndUpdate();
            }
        }



        private void selectColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int rowHandle = 0; rowHandle < grv_Main.RowCount; rowHandle++)
            {
                grv_Main.SelectCell(rowHandle, grv_Main.FocusedColumn);
            }
        }

        private void selectRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int colHandle = 0; colHandle < grv_Main.VisibleColumns.Count; colHandle++)
            {
                grv_Main.SelectCell(grv_Main.FocusedRowHandle, grv_Main.Columns[colHandle]);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clipboard = Clipboard.GetText();
        }

        private void insertNewBlankRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDatasrouce.Rows.InsertAt(MainDatasrouce.NewRow(), grv_Main.FocusedRowHandle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow rr = MainDatasrouce.NewRow();
            rr["ID"] = grv_Main.RowCount + 1;
            MainDatasrouce.Rows.Add(rr);
            grv_Main.FocusedRowHandle = grv_Main.RowCount - 1;
        }

        private void editFocusedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grv_Main.ShowEditor();
            multiCellChangeClick = true;
        }
        
        bool multiCellChangeClick = false;
        private void grv_Main_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (multiCellChangeClick)
                OnCellValueChanged(e);

            
            if (e.Column.FieldName == "PRICE_NAME" || e.Column.FieldName == "INPUT_VALUE")
            {
                try
                {
                    decimal quantity = 0;
                    decimal price = 0;
                    if (grv_Main.GetRowCellValue(e.RowHandle, "INPUT_VALUE").ToString().Replace(".", "").Replace(",", "") != "")
                    {
                        quantity = Convert.ToDecimal(grv_Main.GetRowCellValue(e.RowHandle, "INPUT_VALUE").ToString().Replace(".", "").Replace(",", ""));

                    }
                    if (grv_Main.GetRowCellValue(e.RowHandle, "PRICE_NAME").ToString().Replace(".", "").Replace(",", "") != "")
                    {
                        price = Convert.ToDecimal(grv_Main.GetRowCellValue(e.RowHandle, "PRICE_NAME").ToString().Replace(".", "").Replace(",", ""));
                    }

                    decimal total = quantity * price;
                    grv_Main.SetRowCellValue(e.RowHandle, "TOTAL", total.ToString());

                }
                catch { }
            }
        }

        bool lockEvents;
        private void OnCellValueChanged(CellValueChangedEventArgs e)
        {
            if (lockEvents)
                return;
            lockEvents = true;
            SetSelectedCellsValues(e.Value);
            lockEvents = false;
        }

        private void SetSelectedCellsValues(object value)
        {
            multiCellChangeClick = false;
            try
            {
                grv_Main.BeginUpdate();
                GridCell[] cells = grv_Main.GetSelectedCells();
                foreach (GridCell cell in cells)
                {
                    grv_Main.SetRowCellValue(cell.RowHandle, cell.Column, value);
                }
            }
            catch// (Exception ex)
            {

            }
            finally
            {
                grv_Main.EndUpdate();
            }

        }





        private void searchLookUpEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchLookUpEdit1.ShowPopup();
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)searchLookUpEdit1.Properties.View.GetRow(searchLookUpEdit1.Properties.GetIndexByKeyValue(searchLookUpEdit1.EditValue));
                int emptyRowHandle = RowEmpty(MainDatasrouce);
                grv_Main.SetRowCellValue(emptyRowHandle, "PRODUCT_NAME", row["PRODUCTS_NAME"]);
                grv_Main.SetRowCellValue(emptyRowHandle, "UNIT_NAME", row["UNIT_NAME"]);
                grv_Main.FocusedColumn = grv_Main.Columns[3];
                grv_Main.FocusedRowHandle = emptyRowHandle;
                grv_Main.ShowEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private int RowEmpty(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                object value = table.Rows[i]["PRODUCT_NAME"];
                if (value.ToString() == "")
                    return i;
            }
            return 0;
        }





        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRow rr = MainDatasrouce.NewRow();
            rr["Sort"] = grv_Main.RowCount + 1;
            MainDatasrouce.Rows.Add(rr);
            grv_Main.FocusedRowHandle = grv_Main.RowCount - 1;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int rowHandle = 0; rowHandle < MainDatasrouce.Rows.Count; rowHandle++)
            {
                try
                {
                    decimal quantity = 0;
                    decimal price = 0;
                    if (grv_Main.GetRowCellValue(rowHandle, "QUANTITY").ToString().Replace(".", "").Replace(",", "") != "")
                    {
                        quantity = Convert.ToDecimal(grv_Main.GetRowCellValue(rowHandle, "QUANTITY").ToString().Replace(".", "").Replace(",", ""));
                        
                    }
                    if (grv_Main.GetRowCellValue(rowHandle, "PRICE_NAME").ToString().Replace(".", "").Replace(",", "") != "")
                    {
                        price = Convert.ToDecimal(grv_Main.GetRowCellValue(rowHandle, "PRICE_NAME").ToString().Replace(".", "").Replace(",", ""));
                    }
                    if (quantity == 0 && price == 0)
                    {
                        continue;
                    }
                    decimal total = quantity * price;

                    grv_Main.SetRowCellValue(rowHandle, "TOTAL", total.ToString());
                }
                catch //(Exception)
                {

                    //throw;
                }

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = new Form();
            DevExpress.XtraGrid.GridControl g = new DevExpress.XtraGrid.GridControl();
            g.Dock = DockStyle.Fill;
            g.DataSource = MainDatasrouce;
            f.Controls.Add(g);
            f.Show();
        }


        private void insertClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            //Luu thông tin phiếu
            DTINPUTInfo Info = new DTINPUTInfo();
            Info.DATE_CREATED = DateTime.Now;
            Info.TOTAL_VALUE = (double)gridColumn5.SummaryItem.SummaryValue;

            DataTable dt = (DataTable)vGridControl1.DataSource;

            Info.WAREHOUSE_NAME = dt.Rows[0]["WAREHOUSE_NAME"].ToString();
            Info.FUNDS_NAME = dt.Rows[0]["FUNDS_NAME"].ToString();
            Info.EXPIRED_DATE = DateTime.Parse( dt.Rows[0]["EXPIRED_DATE"].ToString());
            Info.ORGANIZATION_NAME = dt.Rows[0]["ORGANIZATION_NAME"].ToString();
            Info.USER_NAME = dt.Rows[0]["USER_NAME"].ToString();
            Info.INPUT_CODE = dt.Rows[0]["INPUT_CODE"].ToString();
      

            DTINPUTInfo inputNew = new    DTINPUTInfo();
            if (this.inputMain != null)
            {
                Info.ID = this.inputMain.ID;
                int update =  DTINPUTController.Instance().Update(Info);
            }
            else
            {
                inputNew = DTINPUTController.Instance().Insert(Info);
            }
                        
            //Lưu danh mục 

            for (int i = 0; i < MainDatasrouce.Rows.Count; i++)
            {
                try
                {
                    if (!EmptyFeild(i,1))
                    {
                        DTINPUTDETAILInfo product = new DTINPUTDETAILInfo();
                        product.INPUT_ID = inputNew.ID;
                        product.TOTAL = double.Parse(MainDatasrouce.Rows[i]["TOTAL"].ToString().Trim());
                        product.QUANTITY = double.Parse(MainDatasrouce.Rows[i]["QUANTITY"].ToString().Trim());
                        product.PRODUCT_NAME = MainDatasrouce.Rows[i]["PRODUCT_NAME"].ToString().Trim();
                        product.PRICE_NAME = double.Parse(MainDatasrouce.Rows[i]["PRICE_NAME"].ToString().Trim());
                        product.INPUT_VALUE = double.Parse(MainDatasrouce.Rows[i]["INPUT_VALUE"].ToString().Trim());
                        product.UNIT_NAME = MainDatasrouce.Rows[i]["UNIT_NAME"].ToString().Trim();
                        product.SORT = i; 
                        if (MainDatasrouce.Rows[i]["ID"].ToString() != "")
                        {
                            DTINPUTDETAILController.Instance().Update(product);
                        }
                        else
                        {
                            if (this.inputMain != null)
                            {
                                product.INPUT_ID = this.inputMain.ID;
                            }
                            DTINPUTDETAILController.Instance().Insert(product);
                        }
                        
                    }

                }
                catch (Exception ex)
                {
 
                    MessageBox.Show(ex.Message);
                    // throw;
                }

            }

            splashScreenManager1.CloseWaitForm();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow rr = MainDatasrouce.NewRow();
            rr["Sort"] = grv_Main.RowCount + 1;
            MainDatasrouce.Rows.Add(rr);
            grv_Main.FocusedRowHandle = grv_Main.RowCount - 1;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Name == "xPageInvoce")
            {
                ribMenuTop.SelectedPage = ribInvoice;
            }
        }

        private void bar_btnPrintShow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReport f = new frmReport();
            f.Show();
        }
    }
}
