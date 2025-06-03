using System;
using System.Collections.Generic;
using System.ComponentModel;
using NourPizzaria.Classes;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NourPizzaria.Controls
{
    public partial class LucasLItemPedido : UserControl
    {
        private Color corBorda = Color.Black;
        private int espessuraBorda = 2;
        private EstadoPedido _estado = EstadoPedido.EmPreparo;
        private bool bordaAtiva = true;
        private System.Windows.Forms.Timer _timer;
        public event EventHandler EditarClicado;
        public event EventHandler ExcluirClicado;
        public event EventHandler StatusClicado;
        public event EventHandler StatusTxtChanged;

        public LucasLItemPedido()
        {
            InitializeComponent();
        }

        [Category("Lucas")]
        public string NumeroItem
        {
            get { return lblNItem.Text; }
            set { lblNItem.Text = value; }
        }

        [Category("Lucas")]
        public EstadoPedido EstadoDoPedido
        {
            get { return _estado; }
            set
            {
                _estado = value;
                DefinirStatus(value);
                Invalidate();
            }
        }

        [Category("Lucas")]
        public string NumeroPedido
        {
            get { return lblNItem.Text; }
            set { lblNItem.Text = value; }
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
        public Color CorFonteNumeroPedido
        {
            get { return lblNItem.ForeColor; }
            set { lblNItem.ForeColor = value; }
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
        public int IdPedido { get; set; }

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

        private void pctLixo_MouseEnter(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoVermelho;
        }

        private void pctLixo_MouseLeave(object sender, EventArgs e)
        {
            pctLixo.Image = Properties.Resources.lixoBranco;
        }

        private void pctEditar_MouseEnter(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_black;
        }

        private void pctEditar_MouseLeave(object sender, EventArgs e)
        {
            pctEditar.Image = Properties.Resources.pencil_white;
        }

        private void pctLixo_Click(object sender, EventArgs e)
        {
            ExcluirClicado?.Invoke(this, EventArgs.Empty);
        }

        private void pctEditar_Click(object sender, EventArgs e)
        {
            EditarClicado?.Invoke(this, EventArgs.Empty);
        }

        public void DefinirStatus(EstadoPedido novoStatus)
        {
            string status = novoStatus == EstadoPedido.EmPreparo ? "Em preparo" :
                            novoStatus == EstadoPedido.Pronto ? "Pronto" :
                            novoStatus == EstadoPedido.Entregue ? "Entregue" :
                            novoStatus == EstadoPedido.Cancelado ? "Cancelado" : "";

            lblStatus.Text = status;

            switch (status)
            {
                case "Em preparo":
                    lblStatus.BackColor = Color.FromArgb(247, 220, 111);
                    lucasComboBox1.BackColor = Color.FromArgb(247, 220, 111);
                    lucasComboBox1.ListBackColor = Color.FromArgb(247, 220, 111);
                    break;
                case "Pronto":
                    lblStatus.BackColor = Color.FromArgb(46, 204, 113);
                    lucasComboBox1.BackColor = Color.FromArgb(46, 204, 113);
                    lucasComboBox1.ListBackColor = Color.FromArgb(46, 204, 113);
                    break;
                case "Entregue":
                    lblStatus.BackColor = Color.FromArgb(52, 152, 219);
                    lucasComboBox1.BackColor = Color.FromArgb(52, 152, 219);
                    lucasComboBox1.ListBackColor = Color.FromArgb(52, 152, 219);
                    break;
                case "Cancelado":
                    lblStatus.BackColor = Color.FromArgb(231, 76, 60);
                    lucasComboBox1.BackColor = Color.FromArgb(231, 76, 60);
                    lucasComboBox1.ListBackColor = Color.FromArgb(231, 76, 60);
                    break;
                default:
                    lblStatus.BackColor = Color.Gray;
                    lucasComboBox1.BackColor = Color.Gray;
                    lucasComboBox1.ListBackColor = Color.Gray;
                    break;
            }
        }

        private void AtualizarCentralizacao()
        {
            int alturaDisponivel = pnlObs.ClientSize.Height;
            int alturaTexto = lblObs.PreferredHeight;
            lblObs.Top = (alturaDisponivel - alturaTexto) / 2;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lucasComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string status = lucasComboBox1.Texts;
            
            switch (status)
            {
                case "Em preparo":
                    this.EstadoDoPedido = EstadoPedido.EmPreparo;
                    break;
                case "Pronto":
                    this.EstadoDoPedido = EstadoPedido.Pronto;
                    break;
                case "Entregue":
                    this.EstadoDoPedido = EstadoPedido.Entregue;
                    break;
                case "Cancelado":
                    this.EstadoDoPedido = EstadoPedido.Cancelado;
                    break;
                default:
                    this.EstadoDoPedido = EstadoPedido.EmPreparo;
                    break;
            }
            StatusTxtChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
