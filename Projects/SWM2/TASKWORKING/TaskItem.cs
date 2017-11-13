using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TASKWORKING
{
    public partial class TaskItem : UserControl
    {
        //
        private bool _ItemStatus = false;
        private string _ItemText = "";
        private int _Sort = 0;

        public int Sort
        {
            get { return _Sort; }
            set { _Sort = value; }
        }

        public bool ItemStatus
        {
            get { return _ItemStatus; }
            set { _ItemStatus = value; }
        }

        public  string ItemText
        {
            get { return _ItemText; }
            set { _ItemText = value; }
        }

        public TaskItem()
        {
            InitializeComponent();            
        }

        public TaskItem(bool Status)
        {
            InitializeComponent();
            this._ItemStatus = Status;
        }

        public TaskItem(string Text)
        {
            InitializeComponent();
            this._ItemText = Text;
            lblTaskContent.Text = Text;
        }

        public TaskItem(bool Status, string Text)
        {
            InitializeComponent();
            this._ItemText = Text;
            this._ItemStatus = Status;
            lblTaskContent.Text = Text;
        }

        private void picStatus_Click(object sender, EventArgs e)
        {
            SetTaskItemStatus();
        }

        private void TaskItem_Load(object sender, EventArgs e)
        {
            SetTaskItemStatus();
        }

        private void SetTaskItemStatus()
        {
            if (!ItemStatus)//uncheck
            {
                picStatus.Image = global::TASKWORKING.Properties.Resources.uncheck_bold;

                lblTaskContent.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTaskContent.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
                
                ItemStatus = !ItemStatus;
            }
            else//checked
            {
                picStatus.Image = global::TASKWORKING.Properties.Resources._checked;

                lblTaskContent.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                    | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTaskContent.Appearance.ForeColor = System.Drawing.Color.DimGray;

                ItemStatus = !ItemStatus;
            }
        }
    }
}
