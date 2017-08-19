using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VKTIM.Common;

namespace VKTIM
{
    public partial class InputWarehouse : CommonForm
    {
        public InputWarehouse()
        {
            InitializeComponent();
        }

        private void InputWarehouse_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= 29; i++)
                {
                    dgv_Data.Rows.Add();
                }
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, GBTSCConstants.MSG_CAPTION_ERROR, GBTSCCommon.MessageType.Message_NG);
            }
        }

        private void PasteClipboard(DataGridView dgv)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.UnicodeText))
            {
                if (dgv.RowCount > 0)
                    dgv.Rows.Clear();

                if (dgv.ColumnCount > 0)
                    dgv.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.UnicodeText).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dgv.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dgv.Rows.Add();
                    int myRowIndex = dgv.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dgv.Rows[myRowIndex])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                }
            }
        }

        private void PasteClipboardEx(DataGridView dgv)
        {
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.UnicodeText))
            {
                //  SỐ LƯỢNG CỘT ĐƯỢC CHỌN TRÊN GRID                    = COLG
                //  SỐ LƯỢNG DÒNG ĐƯỢC CHỌN TRÊN GRID                   = ROWG
                //  SỐ LƯỢNG CỘT ĐƯỢC CHỌN TRÊN EXCEL                   = COLE
                //  SỐ LƯỢNG DÒNG ĐƯỢC CHỌN TRÊN EXCEL                  = ROWE
                //  TỔNG SỐ LƯỢNG CỘT CÓ TRÊN GRID                      = TOTAL_COLG
                //  TỔNG SỐ LƯỢNG DÒNG CÓ TRÊN GRID                     = TOTAL_ROWG
                //  DANH SÁCH TÊN CỘT ĐƯỢC CHỌN TRÊN GRID               = _LST_COLG
                //  DANH SÁCH DÒNG ĐƯỢC CHỌN TRÊN GRID                  = _LST_ROWG
                //  MẢNG DANH SÁCH DÒNG ĐƯỢC COPY TRÊN EXCEL            = _PASTED_ROWS
                //  MẢNG DANH SÁCH CỘT ĐƯỢC COPY TRÊN EXCEL             = _PASTED_ROW_CELLS
                //  TỔNG SỐ TÊN CỘT CÓ Ở TRÊN GRID                      = TOTAL_COLNAME_G
                //  CHỈ SỐ DÒNG CỦA CELL ĐẦU TIÊN ĐƯỢC CHỌN TRÊN GRID   = _FIRST_ROWG_SELECTED
                //  CHỈ SỐ CỘT CỦA CELL ĐẦU TIÊN ĐƯỢC CHỌN TRÊN GRID    = _FIRST_COLG_SELECTED
                //  TÊN CỘT CỦA CELL ĐẦU TIÊN ĐƯỢC CHỌN TRÊN GRID       = _FIRST_COLNAME_G_SELECTED

                //  CẦN CÓ DANH SÁCH COLUMN Ở TRÊN GRID - KÈM THEO ĐÓ LÀ INDEX
                //  ĐỂ CÓ THỂ TÌM ĐƯỢC CÁC COLUMN TIÊP THEO HOẶC LIỀN TRƯỚC NÊU MỘT COLUMN NÀO ĐÓ ĐƯỢC CHỌN LÀM MỐC


                //  Total col selected ini Grid and Excel
                int COLG = 0;
                int ROWG = 0;
                int COLE = 0;
                int ROWE = 0;
                int TOTAL_COLG = 0;
                int TOTAL_ROWG = 0;
                List<string> _LST_COLG = new List<string>();
                List<int> _LST_ROWG = new List<int>();
                List<string> TOTAL_COLNAME_G = new List<string>();
                List<string> COLG_CURRENT_2_LAST = new List<string>();
                int _FIRST_ROWG_SELECTED = 0;
                int _FIRST_COLG_SELECTED = 0;
                string _FIRST_COLNAME_G_SELECTED = String.Empty;
                string[] _PASTED_ROWS;
                string[] _PASTED_ROW_CELLS;

                //  Calculate total row and column displayed in GRID
                TOTAL_ROWG = dgv.RowCount;
                TOTAL_COLG = dgv.ColumnCount;
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (col.Visible && !col.Name.Equals("colIndex"))
                    {
                        TOTAL_COLNAME_G.Add(col.Name);
                    }
                }

                //  Calculate total row and column selected in EXCEL
                _PASTED_ROWS = Regex.Split(o.GetData(DataFormats.UnicodeText).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                ROWE = _PASTED_ROWS.Length;
                if (ROWE > 0)
                {
                    _PASTED_ROW_CELLS = _PASTED_ROWS[0].Split(new char[] { '\t' });
                    COLE = _PASTED_ROW_CELLS.Length;
                }

                //  Calculate total row and column selected in GRID
                if (dgv.SelectedCells.Count > 0)
                {
                    _FIRST_ROWG_SELECTED = dgv.SelectedCells[dgv.SelectedCells.Count - 1].RowIndex;
                    _FIRST_COLG_SELECTED = dgv.SelectedCells[dgv.SelectedCells.Count - 1].ColumnIndex;
                    _FIRST_COLNAME_G_SELECTED = dgv.Columns[_FIRST_COLG_SELECTED].Name;
                    string colName;
                    foreach (DataGridViewCell cel in dgv.SelectedCells)
                    {
                        colName = dgv.Columns[cel.ColumnIndex].Name;
                        if (!_LST_COLG.Contains(colName))
                        {
                            _LST_COLG.Add(colName);
                        }
                        if (!_LST_ROWG.Contains(cel.RowIndex))
                        {
                            _LST_ROWG.Add(cel.RowIndex);
                        }
                    }
                }
                COLG = _LST_COLG.Count;
                ROWG = _LST_ROWG.Count;

                //string abc = string.Format("Excel: Row={0}, Col={1}  --- Grid: Row={2}, Col={3}", ROWE.ToString(), COLE.ToString(), ROWG.ToString(), COLG.ToString());
                //MessageBox.Show(abc);

                //Show temp
                //string result = "First Row: " + FirstRow.ToString() + Environment.NewLine;
                //foreach (string item in ColumnNames)
                //{
                //    result += item + Environment.NewLine;
                //}
                //MessageBox.Show(result);
                //return;

                //  Paste data from EXCEL to GRID
                if (COLG >= COLE)
                {
                    //  TRƯỜNG HỢP 1: COLG >= COLE
                    //  Số lượng Column được lựa chọn trên GRID >= Số lượng Column được lựa chọn trên EXCEL
                    //  Do vậy chỉ paste đến Số lượng Column được lựa chọn trên EXCEL
                    int rowIndexAdded = 0;
                    foreach (string pastedRow in _PASTED_ROWS)
                    {
                        _PASTED_ROW_CELLS = pastedRow.Split(new char[] { '\t' });
                        for (int i = COLG - 1; i >= 0; i--)
                        {
                            if (COLG - 1 - i == COLE)
                            {
                                break;
                            }
                            else
                            {
                                dgv.Rows[_FIRST_ROWG_SELECTED + rowIndexAdded].Cells[_LST_COLG[i]].Value = _PASTED_ROW_CELLS[COLG - 1 - i];
                            }
                        }

                        rowIndexAdded++;
                    }
                }
                else if (COLG < COLE)
                {
                    //  TRƯỜNG HỢP 2: COLG < COLE
                    //  Số lượng Column được lựa chọn trên GRID < Số lượng Column được lựa chọn trên Excel
                    //  Do vậy nếu paste đến Số lượng Column được lựa chọn trên EXCEL, ..
                    //  .. thì cần phải tìm được danh sách các Column tiếp theo ở trên GRID

                    //  Kiểm tra vị trí đặt chuột,
                    //  Nếu từ vị trí đặt chuột -> col cuối, tổng số lượng >= COLE => paste bình thường theo COLE
                    //  Nếu từ vị trí đặt chuột -> col cuối, tổng số lượng < COLE
                    //      ->Thông báo cho user rằng nếu chọn vị trí này để Paste thì X cột dữ liệu trong EXCEL sẽ bị mất
                    //      -> Hoặc thông báo rằng user có thể chọn lại vị trí để Paste
                    //      -> Hoặc thông báo rằng user nên kiểm tra lại dữ liệu copy trong EXCEL đã chính xác hay chưa

                    // Từ vị trí đặt chuôt -> col cuối
                    int current_2_last = 0;
                    int current_col_position = 0;
                    int count_for_cut = 0;
                    foreach (string colName in TOTAL_COLNAME_G)
                    {
                        current_col_position++;
                        if (_FIRST_COLNAME_G_SELECTED.Equals(colName))
                        {
                            break;
                        }
                    }
                    foreach (string colName in TOTAL_COLNAME_G)
                    {
                        count_for_cut++;
                        if (count_for_cut >= current_col_position)
                        {
                            current_2_last++;
                            COLG_CURRENT_2_LAST.Add(colName);
                        }
                    }

                    // So sánh current_2_last với COLE
                    if (current_2_last >= COLE)
                    {
                        int rowIndexAdded = 0;
                        int cellCount = 0;
                        foreach (string pastedRow in _PASTED_ROWS)
                        {
                            cellCount = 0;
                            _PASTED_ROW_CELLS = pastedRow.Split(new char[] { '\t' });
                            foreach (string col2last in COLG_CURRENT_2_LAST)
                            {
                                if (cellCount == COLE)
                                {
                                    break;
                                }
                                dgv.Rows[_FIRST_ROWG_SELECTED + rowIndexAdded].Cells[col2last].Value = _PASTED_ROW_CELLS[cellCount];
                                cellCount++;
                            }
                            rowIndexAdded++;
                        }
                    }
                    else
                    {
                        // current_2_last < COLE
                        int sub = COLE - current_2_last;
                        string warning = "Với vị trí đang chọn, dữ liệu được dán sẽ bị mất {0} cột cuối cùng." + Environment.NewLine;
                        warning += "Bạn có thể lựa chọn một vị trí khác để dán dữ liệu." + Environment.NewLine;
                        warning += "Hoặc kiểm tra lại số lượng cột dữ liệu được chọn trong Excel." + Environment.NewLine;
                        if (GBTSCCommon.Message_Confirm(string.Format(warning, sub.ToString()), "PASTE") == DialogResult.Yes)
                        {
                            int rowIndexAdded = 0;
                            int cellCount = 0;
                            foreach (string pastedRow in _PASTED_ROWS)
                            {
                                cellCount = 0;
                                _PASTED_ROW_CELLS = pastedRow.Split(new char[] { '\t' });
                                foreach (string col2last in COLG_CURRENT_2_LAST)
                                {
                                    dgv.Rows[_FIRST_ROWG_SELECTED + rowIndexAdded].Cells[col2last].Value = _PASTED_ROW_CELLS[cellCount];
                                    cellCount++;
                                }
                                rowIndexAdded++;
                            }
                        }
                    }


                }
            }
        }

        private void dgv_Data_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                PasteClipboardEx(dgv_Data);
            }
        }

        private void btn_AddNewRows_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nud_InsertRows.Value; i++)
            {
                dgv_Data.Rows.Add();
            }
        }

        private void dgv_Data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Check if the event is fired for your specific column
            //I suppose LinkColumn is name of your link column
            //You can use e.ColumnIndex == 0 for example, if your link column is first column
            if (e.ColumnIndex == this.dgv_Data.Columns["colIndex"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }
    }
}                                                                                                                                                                                   