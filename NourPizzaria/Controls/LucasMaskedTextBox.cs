using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NourPizzaria.Controls
{
    public partial class LucasMaskedTextBox: UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        public LucasMaskedTextBox()
        {
            InitializeComponent();
            UpdateControlHeight();
        }

        public event EventHandler _TextChanged;

        [Category("Lucas")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Lucas")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Lucas")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set { underlinedStyle = value; this.Invalidate(); }
        }

        [Category("Lucas")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; maskedTextBox1.BackColor = value; }
        }

        [Category("Lucas")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; maskedTextBox1.ForeColor = value; }
        }

        [Category("Lucas")]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; maskedTextBox1.Font = value; UpdateControlHeight(); }
        }

        [Category("Lucas")]
        public string Texts
        {
            get
            {
                if (maskedTextBox1.Text == maskedTextBox1.Mask)
                {
                    return "";
                }
                else
                {
                    return maskedTextBox1.Text;
                }
            }
            set { maskedTextBox1.Text = value; }
        }

        [Category("Lucas")]
        public string Mask
        {
            get { return maskedTextBox1.Mask; }
            set { maskedTextBox1.Mask = value; }
        }

        [Category("Lucas")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        private void UpdateControlHeight()
        {
            if (!maskedTextBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                maskedTextBox1.MinimumSize = new Size(0, txtHeight);
                this.Height = maskedTextBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

    }
}
