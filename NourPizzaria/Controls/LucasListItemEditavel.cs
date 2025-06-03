using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria.Controls
{
    public partial class LucasListItemEditavel : UserControl
    {
        private Color corBorda = Color.Black;
        private int espessuraBorda = 2;
        private bool bordaAtiva = true;
        private System.Windows.Forms.Timer _timer;
        public event EventHandler ExcluirClicado;
        public event EventHandler EditarClicado;
        public LucasListItemEditavel()
        {
            InitializeComponent();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 100;
            _timer.Tick += Timer_Tick;
        }

        // Propriedades de texto
        [Category("Lucas")]
        public string NumeroItem
        {
            get { return lblNItem.Text; }
            set { lblNItem.Text = value; }
        }
        [Category("Lucas")]
        public string NomeItem
        {
            get { return lblNomeItem.Text; }
            set { lblNomeItem.Text = value; }
        }
        [Category("Lucas")]
        public string Observacoes
        {
            get { return lblTxtObs.Text; }
            set { lblTxtObs.Text = value; }
        }
        [Category("Lucas")]
        public string TituloObservacao
        {
            get { return lblObs.Text; }
            set { lblObs.Text = value; }
        }

        [Category("Lucas")]
        public Color CorFonteNumeroItem
        {
            get { return lblNItem.ForeColor; }
            set { lblNItem.ForeColor = value; }
        }
        [Category("Lucas")]
        public Color CorFonteNomeItem
        {
            get { return lblNomeItem.ForeColor; }
            set { lblNomeItem.ForeColor = value; }
        }
        [Category("Lucas")]
        public Color CorFonteObservacao
        {
            get { return lblObs.ForeColor; }
            set { lblObs.ForeColor = value; }
        }
        [Category("Lucas")]
        public Color CorFonteTextoObservacao
        {
            get { return lblTxtObs.ForeColor; }
            set { lblTxtObs.ForeColor = value; }
        }

        [Category("Lucas")]
        public Color CorBorda
        {
            get { return corBorda; }
            set
            {
                corBorda = value;
                this.Invalidate();
            }
        }

        [Category("Lucas")]
        public int EspessuraBorda
        {
            get { return espessuraBorda; }
            set
            {
                espessuraBorda = value;
                this.Invalidate();
            }
        }

        [Category("Lucas")]
        public bool BordaAtiva
        {
            get { return bordaAtiva; }
            set
            {
                bordaAtiva = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bordaAtiva)
            {
                using (Pen pen = new Pen(corBorda, espessuraBorda))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }


        private void lblTxtObs_TextChanged(object sender, EventArgs e)
        {
            _timer.Stop();
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            int maxLineWidth = pnlObs.Width - 10;

            string text = lblTxtObs.Text;

            string formattedText = "";
            string[] words = text.Split(' ');

            string currentLine = "";
            foreach (var word in words)
            {
                string testLine = currentLine + (currentLine.Length > 0 ? " " : "") + word;
                int lineWidth = TextRenderer.MeasureText(testLine, lblTxtObs.Font).Width;

                if (lineWidth <= maxLineWidth)
                {
                    currentLine = testLine;
                }
                else
                {
                    formattedText += currentLine + "\n";
                    currentLine = word;
                }
            }

            formattedText += currentLine;

            lblTxtObs.Text = formattedText;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LucasListItem_Load(object sender, EventArgs e)
        {
            lblNomeItem.Left = (this.Width - lblNomeItem.Width) / 2;
        }

        private void pctLixo_MouseEnter(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoVermelho;
        }

        private void pctLixo_MouseLeave(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoBranco;
        }

        private void pctLixo_Click(object sender, EventArgs e)
        {
            ExcluirClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pctEditar_MouseEnter(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_black;
        }

        private void pctEditar_MouseLeave(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_white;
        }

        private void pctEditar_Click(object sender, EventArgs e)
        {
            EditarClicado?.Invoke(this, EventArgs.Empty);
        }
    }
}
