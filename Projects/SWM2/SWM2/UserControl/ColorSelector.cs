using System.Drawing;
using System.Windows.Forms;

namespace VKTIM.UserControl
{
    public sealed class ColorSelector : ComboBox
    {
        public ColorSelector()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            e.DrawFocusRectangle();

            if (e.Index >= 0 && e.Index < Items.Count)
            {
                DropDownItem item = (DropDownItem)Items[e.Index];

                e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);

                //item.Value
                e.Graphics.DrawString(item.Name, e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + item.Image.Width, e.Bounds.Top);
            }

            base.OnDrawItem(e);
        }
    }

    public sealed class DropDownItem
    {
        public Color IconColor { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public Image Image { get; set; }

        public DropDownItem()
            : this(Color.White, "", "")
        { }

        public DropDownItem(Color iconClor, string name, string val)
        {
            Value = val;
            Name = name;
            IconColor = iconClor;
            Image = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(Image))
            {
                using (Brush b = new SolidBrush(Color.FromArgb(255, iconClor)))
                {
                    g.DrawRectangle(Pens.White, 0, 0, Image.Width, Image.Height);
                    g.FillRectangle(b, 1, 1, Image.Width - 1, Image.Height - 1);
                }
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
