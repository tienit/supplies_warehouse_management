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
    public partial class frmWaitTesting : CommonFormAdmin
    {
        public frmWaitTesting()
        {
            InitializeComponent();
        }

        private void frmWaitTesting_Load(object sender, EventArgs e)
        {
            TakeALongTime();
        }

        private void TakeALongTime()
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(90);
                textBox1.Text = i.ToString();
            }
        }
    }
}
