using ADOX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class frmExcelImportWinz : CommonForm
    {
        public frmExcelImportWinz()
        {
            InitializeComponent();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.FileName = txt_File.Text;
            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txt_File.Text = fdlg.FileName;
                // do something

                com_Sheet.Items.Clear();
                foreach (var item in GetTableExcel(txt_File.Text))
                {
                    if (item != null)
                    {
                        com_Sheet.Items.Add(item);
                    }
                }

                if (com_Sheet.Items.Count > 0)
                {
                    com_Sheet.SelectedIndex = 0;
                }

                FillComboboxData();
            }
        }

        public static string[] GetTableExcel(string strFileName)
        {
            string[] strTables = new string[100];
            Catalog oCatlog = new Catalog();
            ADOX.Table oTable = new ADOX.Table();
            ADODB.Connection oConn = new ADODB.Connection();
            oConn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);
            oCatlog.ActiveConnection = oConn;
            if (oCatlog.Tables.Count > 0)
            {
                int item = 0;
                foreach (ADOX.Table tab in oCatlog.Tables)
                {
                    if (tab.Type == "TABLE")
                    {
                        strTables[item] = tab.Name;
                        item++;
                    }
                }
            }
            return strTables;
        }

        private void FillComboboxData()
        {

            DataTable data = new DataTable();
            if (com_Sheet.SelectedItem.ToString() != "")
            {
                data = GetDataTableExcel(txt_File.Text, com_Sheet.SelectedItem.ToString());
            }

            List<string> lstColumn = new List<string>();

            for (int i = 0; i < data.Columns.Count; i++)
            {
                lstColumn.Add(data.Columns[i].ColumnName.ToString());
            }



            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            column.DataSource = lstColumn;
            column.HeaderText = "Cột dữ liệu";
            column.DataPropertyName = "Money";
            column.Name = "D";
            column.Width = 300;


            if (grv_Merge.Columns["D"] != null)
                grv_Merge.Columns.Remove("D");


            grv_Merge.Columns.Add(column);


            if (grv_Merge.Rows.Count > 0)
                grv_Merge.Rows.Clear();

            for (int i = 0; i < grv_Main.Columns.Count; i++)
            {
                if (grv_Main.Columns[i].Name != "")
                {
                    this.grv_Merge.Rows.Add(grv_Main.Columns[i].Name, grv_Main.Columns[i].HeaderText);
                }

            }

        }

        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            conn.Open();
            string strQuery = "SELECT * FROM [" + Table + "]";
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        private void btn_Refres_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> header_column = new Dictionary<string, string>();

            DataTable data = new DataTable();
            if (com_Sheet.SelectedItem.ToString() != "")
            {
                data = GetDataTableExcel(txt_File.Text, com_Sheet.SelectedItem.ToString());
            }

            for (int i = 0; i < grv_Merge.Rows.Count; i++)
            {
                try
                {
                    //header_column.Add(grv_Winzard.Rows[i].Cells["col1"].Value.ToString(), grv_Winzard.Rows[i].Cells["D"].Value.ToString());
                    data.Columns[grv_Merge.Rows[i].Cells["D"].Value.ToString()].ColumnName = grv_Merge.Rows[i].Cells["col1"].Value.ToString();
                }
                catch (Exception)
                {
                }
            }

            grv_Main.AutoGenerateColumns = false;
            grv_Main.DataSource = null;
            grv_Main.DataSource = data;



            //tinh tong ben duoi
            int widh = 0;
            foreach (DataGridViewColumn item in grv_Main.Columns)
            {
                widh = widh + item.Width;
            }
            grv_Total.AutoGenerateColumns = false;
            grv_Total.Columns[0].Width = widh / 2;
            grv_Total.Columns[1].Width = widh / 2;

            double total_value = 0;
            double valuecell = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                try
                {
                    valuecell = double.Parse(data.Rows[i]["colTotal"].ToString());
                }
                catch (Exception)
                {
                }
                total_value = total_value + valuecell;
            }

            grv_Total.Rows.Clear();
            grv_Total.Rows.Add("Tổng cộng: ", String.Format("{0:n0}", total_value));
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.grv_Main.SelectedRows)
            {
                try
                {
                    grv_Main.Rows.RemoveAt(item.Index);
                }
                catch (Exception)
                {

                }

            }
        }

        private void btn_Datatable_Click(object sender, EventArgs e)
        {
            Form f_ = new Form();
            DataGridView dtgrv = new DataGridView();
            dtgrv.Dock = DockStyle.Fill;
            dtgrv.DataSource = ((DataRowView)grv_Main.Rows[0].DataBoundItem).DataView.Table;
            f_.Controls.Add(dtgrv);
            f_.Show();

        }

        private void com_Sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_File.Text != "")
            {
                try
                {
                    FillComboboxData();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
