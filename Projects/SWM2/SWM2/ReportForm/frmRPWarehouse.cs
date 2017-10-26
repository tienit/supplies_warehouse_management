using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tienit.core;
using VKTIM.Common;
using VKTIM.Component;
using VKTIM.Reports;


namespace VKTIM.ReportForm
{
    public partial class frmRPWarehouse : Form
    {
        public frmRPWarehouse()
        {
            InitializeComponent();
        }

        private void frmRPWarehouse_Load(object sender, EventArgs e)
        {
            //Combobox datasource
            foreach (string item in DMPRODUCTSController.Instance().GetProductsColumn())
            {
                cmb_Parameter1.Properties.Items.Add(item);
                cmb_Parameter2.Properties.Items.Add(item);
                cmb_Parameter3.Properties.Items.Add(item);
                cmb_Parameter4.Properties.Items.Add(item);
                cmb_Parameter5.Properties.Items.Add(item);

            }

            cmb_Parameter1.SelectedIndex = 0;
            cmb_Parameter2.SelectedIndex = 1;
            cmb_Parameter3.SelectedIndex = 15;
            cmb_Parameter5.SelectedIndex = 3;


            //ribbon control
            ribbonControl1.Minimized = true;
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string paran1 = cmb_Parameter1.SelectedItem.ToString();
            string paran2 = cmb_Parameter2.SelectedItem.ToString();
            string paran3 = cmb_Parameter3.SelectedItem.ToString();

            string value1 = txt_Keyword1.Text;
            string value2 = txt_Keyword2.Text;
            string value3 = txt_Keyword3.Text;

            try
            {
                grc_Main.DataSource = null;
                grc_Main.DataSource = DMPRODUCTSController.Instance().SearchWithParameter(paran1, value1, paran2, value2, paran3, value3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
