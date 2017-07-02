using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VKTIM.UserControl
{
    class MarqueeLabel: Label
    {
        private int CurrentPosition { get; set; }
        private Timer Timer { get; set; }
        private string _Direction;
        public string Direction
        {
            //1 = Left -> Right
            //2 = Right -> Left
            get { return _Direction; }
            set { _Direction = value; }
        }

        public MarqueeLabel()
        {
            UseCompatibleTextRendering = true;
            Timer = new Timer();
            Timer.Interval = 25;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (_Direction == "1")
            {
                if (CurrentPosition > Width)
                    CurrentPosition = -Width;
                else
                    CurrentPosition += 1;
            }
            else if (_Direction == "2")
            {
                if (CurrentPosition < 0)
                    CurrentPosition = Width;
                else
                    CurrentPosition -= 1;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)CurrentPosition, 0);
            base.OnPaint(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Timer != null)
                    Timer.Dispose();
            }
            Timer = null;
        }
    }
}
