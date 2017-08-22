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
    public partial class frmTaskList : CommonForm
    {
        public frmTaskList()
        {
            InitializeComponent();
        }

        private void frmTaskList_Load(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);

        }

        private void frmTaskList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            
            for (int i = 0; i < this.Height - 10; i++)
            {
                this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height +i);
            }
        }
    }
}
