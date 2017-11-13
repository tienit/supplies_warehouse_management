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

namespace VKTIM
{
    public partial class frmDmAssetProductsPopup : Form
    {
        public frmDmAssetProductsPopup()
        {
            InitializeComponent();
        }

        private void frmDmAssetProductsPopup_Load(object sender, EventArgs e)
        {
            //search edit
            


        
        }

        private void lookupMain_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            



        }

        private void frmDmAssetProductsPopup_KeyDown(object sender, KeyEventArgs e)
        {
            txt_CodeProduct.Text = "";
            txt_CodeProduct.Select();
        }

        private void txt_CodeProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_CodeProduct.Text.Length >= 5)
            {
                grc_SearchResult.DataSource = DMASSETPRODUCTSController.Instance().GetASProductByCode(txt_CodeProduct.Text);
                
            }
        }
    }
}
