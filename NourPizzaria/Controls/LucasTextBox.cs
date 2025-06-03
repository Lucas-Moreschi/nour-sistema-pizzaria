using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NourPizzaria.Controles
{
    [DefaultEvent("_TextChanged")]
    public partial class LucasTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private Color hintForeColor = Color.FromArgb(108, 117, 125);
        private Color trueForeColor;
        private string hint = string.Empty;
        private bool isFocused = false;

        public LucasTextBox()
        {
            InitializeComponent();
            // Capture the default forecolor
            trueForeColor = textBox1.ForeColor;
            // Set initial properties
            textBox1.Text = string.Empty;
        }

        public event EventHandler _TextChanged;

        [Category("Lucas")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }
        [Category("Lucas")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }
        [Category("Lucas")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; Invalidate(); }
        }
        [Category("Lucas")]
        public bool PasswordChar
        {
            get => textBox1.UseSystemPasswordChar;
            set => textBox1.UseSystemPasswordChar = value;
        }
        [Category("Lucas")]
        public bool Multiline
        {
            get => textBox1.Multiline;
            set { textBox1.Multiline = value; UpdateControlHeight(); }
        }
        [Category("Lucas")]
        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; textBox1.BackColor = value; }
        }
        [Category("Lucas")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set { base.ForeColor = value; trueForeColor = value; textBox1.ForeColor = value; }
        }
        [Category("Lucas")]
        public override Font Font
        {
            get => base.Font;
            set { base.Font = value; textBox1.Font = value; if (DesignMode) UpdateControlHeight(); }
        }
        [Category("Lucas")]
        public string Texts
        {
            get => (textBox1.Text == hint) ? string.Empty : textBox1.Text;
            set
            {
                textBox1.Text = value;
                if (string.IsNullOrWhiteSpace(value))
                    ApplyHint();
                else
                    textBox1.ForeColor = trueForeColor;
            }
        }
        [Category("Lucas")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; }
        }
        [Category("Lucas")]
        public string Hint
        {
            get => hint;
            set { hint = value; ApplyHint(); }
        }
        [Category("Lucas")]
        public Color HintForeColor
        {
            get => hintForeColor;
            set { hintForeColor = value; if (textBox1.Text == hint) textBox1.ForeColor = hintForeColor; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                    e.Graphics.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                else
                    e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode) UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            ApplyHint();
        }

        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }
        private void ApplyHint()
        {
            if (!string.IsNullOrEmpty(hint) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = hint;
                textBox1.ForeColor = hintForeColor;
            }
        }
        private void RemoveHint()
        {
            if (textBox1.Text == hint)
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = trueForeColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _TextChanged?.Invoke(this, EventArgs.Empty);
        }
        private void textBox1_Click(object sender, EventArgs e) => OnClick(e);
        private void textBox1_MouseEnter(object sender, EventArgs e) => OnMouseEnter(e);
        private void textBox1_MouseLeave(object sender, EventArgs e) => OnMouseLeave(e);
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) => OnKeyPress(e);
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
            RemoveHint();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
            if (string.IsNullOrWhiteSpace(textBox1.Text)) ApplyHint();
        }
    }
}