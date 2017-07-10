using VKTIM.Common;
using System;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class frmMessage : CommonForm
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            //GBTSCCommon.SetCommon(this);
            lblType.Text = lblType.AccessibleDescription;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
