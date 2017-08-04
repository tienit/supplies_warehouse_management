using VKTIM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VKTIM
{
    public partial class CommonForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int WS_EX_NOACTIVATE = 0x8000000;

        private bool _Is_Show_Minimized;
        private bool _Is_Show_Maximized;
        private bool _Is_Show_Help;


        public CommonForm()
        {
            InitializeComponent();
            //GBTSCCommon.SetCommon(this);
            //Show_Button();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                //cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT | WS_EX_NOACTIVATE;
                return cp;
            }
        }

        public bool Is_Show_Minimized
        {
            get
            {
                return _Is_Show_Minimized;
            }

            set
            {
                _Is_Show_Minimized = value;
            }
        }

        public bool Is_Show_Maximized
        {
            get
            {
                return _Is_Show_Maximized;
            }

            set
            {
                _Is_Show_Maximized = value;
            }
        }

        public bool Is_Show_Help
        {
            get
            {
                return _Is_Show_Help;
            }

            set
            {
                _Is_Show_Help = value;
            }
        }

        public event EventHandler LoadCompleted;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.OnLoadCompleted(EventArgs.Empty);
        }

        protected virtual void OnLoadCompleted(EventArgs e)
        {
            var hander = LoadCompleted;
            if (hander != null)
            {
                hander(this, e);
            }
        }

        private void CommonForm_Load(object sender, EventArgs e)
        {
            GBTSCCommon.SetCommon(this);
            GBTSCCommon.InitErrorProvider(this);
            lbl_FormTitle.Text = this.Text;
            mainTip.SetToolTip(pic_Header, lbl_FormTitle.Text);
            Show_Button();
        }

        private void Show_Button()
        {
            if (!_Is_Show_Help && !_Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = false;
            }
            else if (!_Is_Show_Help && !_Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = true;
            }
            else if (!_Is_Show_Help && _Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = false;
                btn_Minimized.Location = btn_Maximized.Location;
            }
            else if (!_Is_Show_Help && _Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = false;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = true;
            }
            else if (_Is_Show_Help && !_Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = false;
                btn_Help.Location = btn_Maximized.Location;
            }
            else if (_Is_Show_Help && !_Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = false;
                btn_Maximized.Visible = true;
                btn_Help.Location = btn_Minimized.Location;
            }
            else if (_Is_Show_Help && _Is_Show_Minimized && !_Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = false;
                btn_Help.Location = btn_Minimized.Location;
                btn_Minimized.Location = btn_Maximized.Location;
            }
            else if (_Is_Show_Help && _Is_Show_Minimized && _Is_Show_Maximized)
            {
                btn_Help.Visible = true;
                btn_Minimized.Visible = true;
                btn_Maximized.Visible = true;
            }
        }

        private void CommonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, mainHelp.HelpNamespace, HelpNavigator.TableOfContents);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_Maximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pn_Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pn_TOP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pic_Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_FormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CommonForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
