using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;

namespace VKTIM.UserControl
{
    [ToolboxItem(true), ToolboxBitmap(typeof(gGlowBox), "gGlowBox.gGlowBox.bmp")]
    [System.Diagnostics.DebuggerStepThrough()]
    public partial class gGlowBox : Panel
    {
        #region "Initialize"
        public gGlowBox()
        {
            //This call is required by the designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        #endregion

        #region "Fields"
        private Color _glowColor = Color.Red;
        private bool _glowOn;
        #endregion

        #region "Properties"

        /// <summary>
        /// Get or Set the color of the Glow
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("gGlowBox")]
        [Description("Get or Set the color of the Glow")]
        [DefaultValue(typeof(Color), "Maroon")]
        public Color GlowColor
        {
            get { return _glowColor; }
            set
            {
                _glowColor = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Turn the Glow effect on or off
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        [Category("gGlowBox")]
        [Description("Turn the Glow effect on or off")]
        [DefaultValue(false)]
        public bool GlowOn
        {
            get { return _glowOn; }
            set
            {
                _glowOn = value;
                Invalidate();
            }
        }
        #endregion

        #region "Paint"

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (DesignMode == true && Controls.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, string.Format("Drop a control{0}on the gGlowBox", Constants.vbNewLine), new Font("Arial", 8, FontStyle.Bold), new Point(20, 20), Color.DarkBlue);
                TextRenderer.DrawText(e.Graphics, "SSDiver2112", new Font("Arial", 7, FontStyle.Bold), new Point(Width - 75, Height - 17), Color.LightGray);
            }
            else if (_glowOn)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    int _Glow = 15;
                    int _Feather = 50;
                    //Get a Rectangle a little smaller than the Panel's
                    //and make a GraphicsPath with it
                    Rectangle rect = DisplayRectangle;
                    rect.Inflate(-5, -5);
                    gp.AddRectangle(rect);

                    //Draw multiple rectangles with increasing thickness and transparency
                    {
                        for (int i = 1; i <= _Glow; i += 2)
                        {
                            int aGlow = Convert.ToInt32(_Feather - ((_Feather / _Glow) * i));
                            using (Pen pen = new Pen(Color.FromArgb(aGlow, _glowColor), i) { LineJoin = LineJoin.Round })
                            {
                                e.Graphics.DrawPath(pen, gp);
                            }
                        }
                    }
                }
            }

        }
        #endregion

        #region "Sizing"


        private void gGlowBox_Layout(object sender, LayoutEventArgs e)
        {
            //Resize the gGlowBox to fit in the Child Control size
            if (Controls.Count > 0)
            {
                if (object.ReferenceEquals(e.AffectedControl, Controls[0]))
                {
                    Size = new Size(Controls[0].Width + 7, Controls[0].Height + 7);
                    Controls[0].Location = new Point(4, 4);
                    Invalidate();
                }

            }

        }


        private void gGlowBox_Resize(object sender, System.EventArgs e)
        {
            //This is needed to avoid resizing an Anchored gGlowBox when the parent Form is Minimized 
            if ((FindForm() == null) || FindForm().WindowState == FormWindowState.Minimized)
                return;

            //Resize the Child Control to fit the size of the gGlowBox
            if (Controls.Count > 0)
            {
                Controls[0].Size = new Size(Width - 7, Height - 7);
            }

        }
        #endregion

        #region "Control Focus Event"

        private void gGlowBox_ControlAdded(object sender, ControlEventArgs e)
        {
            // Add handlers to let the gGlowBox know when the child control gets Focus 
            e.Control.GotFocus += ChildGotFocus;
            e.Control.LostFocus += ChildLostFocus;
        }

        private void ChildGotFocus(object sender, EventArgs e)
        {
            if (Controls.Count > 0)
            {
                //Check if the control has the ReadOnly property and if so, its value.
                if ((Controls[0].GetType().GetProperty("ReadOnly") != null))
                {
                    object oResult = Interaction.CallByName(Controls[0], "ReadOnly", CallType.Get);
                    GlowOn = Convert.ToBoolean(oResult);
                }
                else
                {
                    GlowOn = true;
                }

            }

        }

        private void ChildLostFocus(object sender, EventArgs e)
        {
            GlowOn = false;
        }
        #endregion
    }
}
