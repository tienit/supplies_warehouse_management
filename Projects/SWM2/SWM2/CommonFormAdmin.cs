using VKTIM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;
using VKTIM.Component.Infos;
using System.IO;

namespace VKTIM
{
    public partial class CommonFormAdmin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int WS_EX_NOACTIVATE = 0x8000000;

        private bool _Is_Show_Minimized;
        private bool _Is_Show_Maximized;
        private bool _Is_Show_Help;

        //Variables
        protected string _TABLE_NAME;
        protected List<GridLayoutInfo> _ARR_FILE_NAME;
        protected DataTable _DT_SRC;

        public string KEY_WORD {
            get { return txt_data_keyword.Text; }
            set { txt_data_keyword.Text = value; }
        }

        public DataGridView GRID_DATA
        {
            get { return dgv_Data; }
        }

        public string DATA_COUNT
        {
            get { return lbl_data_count.Text; }
            set { lbl_data_count.Text = value; }
        }

        public CommonFormAdmin()
        {
            InitializeComponent();
        }

        //For moving form
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                //cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE;
                return cp;
            }
        }

        //For show/hide Control Button
        public bool Is_Show_Minimized
        {
            get
            {
                return _Is_Show_Minimized;
            }

            set
            {
                _Is_Show_Minimized = value;
            }
        }

        public bool Is_Show_Maximized
        {
            get
            {
                return _Is_Show_Maximized;
            }

            set
            {
                _Is_Show_Maximized = value;
            }
        }

        public bool Is_Show_Help
        {
            get
            {
                return _Is_Show_Help;
            }

            set
            {
                _Is_Show_Help = value;
            }
        }

        private void Show_Button()
        {
            if (!_Is_Show_Help && !_Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = false;
            }
            else if (!_Is_Show_Help && !_Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = true;
            }
            else if (!_Is_Show_Help && _Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = false;
                btn_Minimized.Location = btn_Maximized.Location;
            }
            else if (!_Is_Show_Help && _Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = true;
            }
            else if (_Is_Show_Help && !_Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = false;
                btn_Help.Location = btn_Maximized.Location;
            }
            else if (_Is_Show_Help && !_Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = true;
                btn_Help.Location = btn_Minimized.Location;
            }
            else if (_Is_Show_Help && _Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = false;
                btn_Help.Location = btn_Minimized.Location;
                btn_Minimized.Location = btn_Maximized.Location;
            }
            else if (_Is_Show_Help && _Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = true;
            }
        }

        //Form load
        private void CommonForm_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Components(); // Init common variables
                Grid_Layout(); // Create grid layout

                GBTSCCommon.SetCommon(this);
                GBTSCCommon.InitErrorProvider(this);
                lbl_FormTitle.Text = this.Text;
                mainTip.SetToolTip(pic_Header, lbl_FormTitle.Text);

                Show_Button(); // Show/hide control buttons

                Load_Data(); // Bind data to grid
                Add_Events(); // Add events for buttons
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }
        
        //Form key down
        private void CommonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void btn_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, mainHelp.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_Maximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pn_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pn_TOP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pic_Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_FormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CommonForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected virtual void Init_Components()
        {
            // Chỗ này để cho các form kế thừa thực thi
            // Do vậy các biến bên trên đều là NULL
            // Dẫn đến các function bên dưới (có sử dụng các biến này) bị error
        }

        private void Add_Events()
        {
            btn_Add.Click += new EventHandler(btnAdd_Click);
            btn_Update.Click += new EventHandler(btnUpdate_Click);
            btn_Delete.Click += new EventHandler(btnDelete_Click);
            btn_Search.Click += new EventHandler(btnSearch_Click);
            btn_Export_Excel.Click += btnExportExcel_Click;
            btn_Print.Click += new EventHandler(btnPrint_Click);
            txt_data_keyword.KeyDown += new KeyEventHandler(txt_data_keyword_KeyDown);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Add();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Update();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Delete();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Search();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Export_Excel();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Do_Print();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void txt_data_keyword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Do_Search();
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void Grid_Layout()
        {
            if (_ARR_FILE_NAME == null || _ARR_FILE_NAME.Count == 0)
            {
                return;
            }
            DataGridViewColumn col = null;
            foreach (GridLayoutInfo gInfo in _ARR_FILE_NAME)
            {
                switch (gInfo.TYPE)
                {
                    case GIRD_COLUMN_TYPE.TextBox:
                        col = new DataGridViewTextBoxColumn();
                        break;
                    case GIRD_COLUMN_TYPE.ComboBox:
                        col = new DataGridViewComboBoxColumn();
                        break;
                    case GIRD_COLUMN_TYPE.Image:
                        col = new DataGridViewImageColumn();
                        break;
                    case GIRD_COLUMN_TYPE.Link:
                        col = new DataGridViewLinkColumn();
                        break;
                    case GIRD_COLUMN_TYPE.CheckBox:
                        col = new DataGridViewCheckBoxColumn();
                        break;
                    case GIRD_COLUMN_TYPE.Button:
                        col = new DataGridViewButtonColumn();
                        break;
                    default:
                        col = new DataGridViewColumn();
                        break;
                }
                col.Name = "col_" + gInfo.FILE_NAME;
                col.DataPropertyName = gInfo.FILE_NAME;
                //if (gInfo.FILE_NAME.Equals("ID"))
                //{
                //    col.Visible = false;
                //}
                dgv_Data.Columns.Add(col);
            }
        }

        protected void Load_Data()
        {
            if (_TABLE_NAME == null || _TABLE_NAME.Equals(""))
            {
                return;
            }
            _DT_SRC = COMMONController.Instance().GetDataByTableName(_TABLE_NAME);
            dgv_Data.DataSource = _DT_SRC;
            lbl_data_count.Text = _DT_SRC.Rows.Count.ToString();
        }


        protected virtual void Do_Add()
        {

        }

        protected virtual void Do_Update()
        {

        }

        protected virtual void Do_Delete()
        {

        }

        protected virtual void Do_Search()
        {

        }

        protected virtual void Do_Export_Excel()
        {
            System.Globalization.CultureInfo oldCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ExportToExcel(_DT_SRC, "");
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCulture;
        }

        public void ExportToExcel(DataTable dtSrc, string filePath)
        {
            if (dtSrc == null || dtSrc.Columns.Count == 0)
            {
                GBTSCCommon.Message_Info(GBTSCConstants.ESWS_MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL, GBTSCConstants.ESWS_MSG_CAPTION_EXPORT_EXCEL, GBTSCCommon.MessageType.Message_NG);
                return;
            }

            // load excel, and create a new workbook
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();
            // single worksheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;
            // column headings
            for (int i = 0; i < dtSrc.Columns.Count; i++)
            {
                workSheet.Cells[1, (i + 1)] = dtSrc.Columns[i].ColumnName;
            }
            // rows
            for (int i = 0; i < dtSrc.Rows.Count; i++)
            {
                // to do: format date time values before printing
                for (int j = 0; j < dtSrc.Columns.Count; j++)
                {
                    string pa = dtSrc.Rows[i][j].ToString();
                    workSheet.Cells[(i + 2), (j + 1)] = pa;
                }
            }

            if (filePath != null && filePath != "")
            {
                try
                {
                    workSheet.SaveAs(filePath);
                    excelApp.Quit();
                    GBTSCCommon.Message_Info(GBTSCConstants.ESWS_MSG_REPORT_TO_EXCEL_SUCCESS, GBTSCConstants.ESWS_MSG_CAPTION_EXPORT_EXCEL, GBTSCCommon.MessageType.Message_OK);
                }
                catch (Exception ex)
                {
                    GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
                }
            }
            else
            {
                excelApp.Visible = true;
            }
        }

        protected virtual void Do_Print()
        {
            Print(_DT_SRC);
        }

        public void Print(DataTable dtSrc)
        {
            if (dtSrc == null || dtSrc.Columns.Count == 0)
            {
                GBTSCCommon.Message_Info(GBTSCConstants.ESWS_MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL, GBTSCConstants.ESWS_MSG_CAPTION_EXPORT_EXCEL, GBTSCCommon.MessageType.Message_NG);
                return;
            }

            // load excel, and create a new workbook
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Workbooks.Add();
            // single worksheet
            Microsoft.Office.Interop.Excel._Worksheet workSheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;
            // column headings
            for (int i = 0; i < dtSrc.Columns.Count; i++)
            {
                workSheet.Cells[1, (i + 1)] = dtSrc.Columns[i].ColumnName;
            }
            // rows
            for (int i = 0; i < dtSrc.Rows.Count; i++)
            {
                // to do: format date time values before printing
                for (int j = 0; j < dtSrc.Columns.Count; j++)
                {
                    string pa = dtSrc.Rows[i][j].ToString();
                    workSheet.Cells[(i + 2), (j + 1)] = pa;
                }
            }

            string savePath = Application.StartupPath + "\\Template\\TEMP_" + GBTSCCommon.SERVER_NOW().ToString("yyyyMMdd_HH_mm_ss") + ".xlsx";
            workSheet.SaveAs(savePath);
            excelApp.Quit();

            PrintMyExcelFile(savePath);

            try
            {
                FileInfo f_Info = new FileInfo(savePath);
                if (f_Info.Exists)
                {
                    f_Info.Delete();
                }
            }
            catch
            {
            }
        }

        void PrintMyExcelFile(string url)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Open the Workbook:
            Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(
                url,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Get the first worksheet.
            // (Excel uses base 1 indexing, not base 0.)
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            // Print out 1 copy to the default printer:
            ws.PrintOut(
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Cleanup:
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(ws);

            wb.Close(false, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(wb);

            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }
    }
}
