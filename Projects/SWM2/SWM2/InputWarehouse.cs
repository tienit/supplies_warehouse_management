using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class InputWarehouse : CommonForm
    {
        public InputWarehouse()
        {
            InitializeComponent();
        }

        private void pn_Bottom_Paint(object sender, PaintEventArgs e)
        {

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

        private void dgv_Data_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                PasteClipboard(dgv_Data);
            }
        }
    }
}                                                                                                                                                                                   