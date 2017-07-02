using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VKTIM.UserControl
{
    public partial class MyTextBox : TextBox
    {
        public MyTextBox()
        {
            InitializeComponent();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Tab) return true;
            return base.IsInputKey(keyData);
        }
    }
}
