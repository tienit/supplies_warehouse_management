using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace VKTIM.UserControl
{
    public partial class MyPC : System.Windows.Forms.UserControl
    {
        private string _PC_Name;
        private Image _PC_Icon;
        private string _Is_Online = "OFFLINE";

        public string PC_Name
        {
            get
            {
                return _PC_Name;
            }

            set
            {
                _PC_Name = value;
            }
        }

        public Image PC_Icon
        {
            get
            {
                return _PC_Icon;
            }

            set
            {
                _PC_Icon = value;
            }
        }

        public string Is_Online
        {
            get
            {
                return _Is_Online;
            }

            set
            {
                _Is_Online = value;
            }
        }

        public MyPC()
        {
            InitializeComponent();
        }

        private void MyPC_Load(object sender, EventArgs e)
        {
            pic_Main.Image = _PC_Icon;
            lbl_Name.Text = _PC_Name;
            timerPC.Start();
        }

        private bool IsOnline(string hostNameOrIP)
        {
            try
            {
                var p = new Ping();
                if (p.Send(hostNameOrIP).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message + ex.StackTrace);
                return false;
            }
        }

        private void timerPC_Tick(object sender, EventArgs e)
        {
            try
            {
                if (IsOnline(PC_Name))
                {
                    _Is_Online = "ONLINE";
                    pic_Main.Image = Properties.Resources.pc_online_gif;
                }
                else
                {
                    _Is_Online = "OFFLINE";
                    pic_Main.Image = Properties.Resources.pc_offline_48;
                }
            }
            catch
            {
                _Is_Online = "OFFLINE";
                pic_Main.Image = Properties.Resources.pc_offline_48;
            }
        }
    }
}
