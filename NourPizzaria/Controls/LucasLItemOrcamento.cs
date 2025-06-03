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
    public partial class LucasLItemOrcamento : UserControl
    {
        private Color corBorda = Color.Black;
        private int espessuraBorda = 2;
        private EstadoOrcamento _estado = EstadoOrcamento.NaoAprovado;
        private bool bordaAtiva = true;
        private System.Windows.Forms.Timer _timer;
        public event EventHandler EditarClicado;
        public event EventHandler ExcluirClicado;
        public event EventHandler AprovadoClicado;

        public LucasLItemOrcamento()
        {
            InitializeComponent();
        }

        public enum EstadoOrcamento
        {
            Aprovado,
            NaoAprovado
        }

        [Category("Lucas")]
        public string NumeroItem
        {
            get { return lblNOrc.Text; }
            set { lblNOrc.Text = value; }
        }

        [Category("Lucas")]
        public EstadoOrcamento Aprovado_NaoAprovado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                AlterarImagemEstadoOrcamento();
                Invalidate();
            }
        }

        [Category("Lucas")]
        public string NumeroOrcamento
        {
            get { return lblNOrc.Text; }
            set { lblNOrc.Text = value; }
        }

        [Category("Lucas")]
        public string ValorTotal
        {
            get { return lblValor.Text; }
            set { lblValor.Text = value; }
        }

        [Category("Lucas")]
        public string Observacao
        {
            get { return lblObs.Text; }
            set
            {
                lblObs.Text = value;
                AtualizarCentralizacao();
            }
        }

        [Category("Lucas")]
        public string Cliente
        {
            get { return lblCliente.Text; }
            set { lblCliente.Text = value; }
        }

        [Category("Lucas")]
        public string DataPedido
        {
            get { return lblData.Text; }
            set { lblData.Text = value; }
        }

        [Category("Lucas")]
        public Color CorFonteNumeroOrcamento
        {
            get { return lblNOrc.ForeColor; }
            set { lblNOrc.ForeColor = value; }
        }

        [Category("Lucas")]
        public Color CorFonteValorTotal
        {
            get { return lblValor.ForeColor; }
            set { lblValor.ForeColor = value; }
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
        public int IdOrcamento { get; set; }

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
            if (espessuraBorda <= 0)
                return;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctLixo_MouseEnter(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoVermelho;
        }

        private void pctLixo_MouseLeave(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoBranco;
        }

        private void AlterarImagemEstadoOrcamento()
        {
            if (_estado == EstadoOrcamento.Aprovado)
                pctAprovacao.Image = Properties.Resources.Aprovado;
            else
                pctAprovacao.Image = Properties.Resources.NaoAprovado;
        }

        private void pctLixo_Click(object sender, EventArgs e)
        {
            ExcluirClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pctEditar_Click(object sender, EventArgs e)
        {
            EditarClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pctAprovacao_Click(object sender, EventArgs e)
        {
            AprovadoClicado?.Invoke(this, EventArgs.Empty);
        }

        public void DefinirStatus(string status)
        {
            lblStatus.Text = status;

            switch (status)
            {
                case "Pendente":
                    lblStatus.BackColor = Color.FromArgb(247, 220, 111);
                    break;
                case "Aprovado":
                    lblStatus.BackColor = Color.FromArgb(46, 204, 113);
                    break;
                case "Rejeitado":
                    lblStatus.BackColor = Color.FromArgb(231, 76, 60);
                    break;
                default:
                    lblStatus.BackColor = Color.Gray;
                    break;
            }
        }

        private void AtualizarCentralizacao()
        {
            int alturaDisponivel = pnlObs.ClientSize.Height;
            int alturaTexto = lblObs.PreferredHeight;
            lblObs.Top = (alturaDisponivel - alturaTexto) / 2;
        }

        private void pctEditar_MouseEnter(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_black;
        }

        private void pctEditar_MouseLeave(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_white;
        }

        private void pctAprovacao_MouseEnter(object sender, EventArgs e)
        {
            pctAprovacao.Image = Properties.Resources.Aprovado;
        }

        private void pctAprovacao_MouseLeave(object sender, EventArgs e)
        {
            pctAprovacao.Image = Properties.Resources.NaoAprovado;
        }
    }
}
