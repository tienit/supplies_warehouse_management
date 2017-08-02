using VKTIM.Common;
using System;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class frmMessage : CommonForm
    {
        private string _CAPTION;
        private string _MSG;

        public string CAPTION { get => _CAPTION; set => _CAPTION = value; }
        public string MSG { get => _MSG; set => _MSG = value; }


        public frmMessage()
        {
            InitializeComponent();
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            lblType.Text = _CAPTION;
            txtMsg.Text = _MSG;
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
