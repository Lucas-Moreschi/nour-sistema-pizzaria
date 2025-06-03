namespace NourPizzaria.Controls
{
    partial class LucasLItemOrcamento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblNOrc = new Label();
            pnlObs = new Panel();
            lblObs = new Label();
            lblValor = new Label();
            lblStatus = new Label();
            pctAprovacao = new NourPizzaria.Controles.LucasCircularPictureBox();
            pctLixo = new PictureBox();
            pctEditar = new PictureBox();
            lblCliente = new Label();
            lblData = new Label();
            pnlObs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctAprovacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLixo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctEditar).BeginInit();
            SuspendLayout();
            // 
            // lblNOrc
            // 
            lblNOrc.AutoSize = true;
            lblNOrc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNOrc.ForeColor = Color.White;
            lblNOrc.Location = new Point(10, 10);
            lblNOrc.Name = "lblNOrc";
            lblNOrc.Size = new Size(158, 21);
            lblNOrc.TabIndex = 0;
            lblNOrc.Text = "Orçamento N° 9020";
            // 
            // pnlObs
            // 
            pnlObs.AutoScroll = true;
            pnlObs.BackColor = Color.FromArgb(235, 235, 235);
            pnlObs.Controls.Add(lblObs);
            pnlObs.Dock = DockStyle.Bottom;
            pnlObs.Location = new Point(2, 68);
            pnlObs.Name = "pnlObs";
            pnlObs.Size = new Size(613, 73);
            pnlObs.TabIndex = 1;
            pnlObs.Paint += panel1_Paint;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblObs.ForeColor = Color.Black;
            lblObs.Location = new Point(0, 0);
            lblObs.Name = "lblObs";
            lblObs.Padding = new Padding(10, 0, 10, 0);
            lblObs.Size = new Size(20, 15);
            lblObs.TabIndex = 0;
            lblObs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 11F);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(300, 10);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(114, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor total: R$ 0";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(247, 220, 111);
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(417, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(6, 3, 6, 3);
            lblStatus.Size = new Size(75, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Pendente";
            // 
            // pctAprovacao
            // 
            pctAprovacao.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pctAprovacao.BorderColor = Color.RoyalBlue;
            pctAprovacao.BorderColor2 = Color.HotPink;
            pctAprovacao.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pctAprovacao.BorderSize = 0;
            pctAprovacao.GradientAngle = 50F;
            pctAprovacao.Image = Properties.Resources.NaoAprovado;
            pctAprovacao.Location = new Point(574, 5);
            pctAprovacao.Name = "pctAprovacao";
            pctAprovacao.Size = new Size(34, 34);
            pctAprovacao.SizeMode = PictureBoxSizeMode.Zoom;
            pctAprovacao.TabIndex = 4;
            pctAprovacao.TabStop = false;
            pctAprovacao.Click += pctAprovacao_Click;
            pctAprovacao.MouseEnter += pctAprovacao_MouseEnter;
            pctAprovacao.MouseLeave += pctAprovacao_MouseLeave;
            // 
            // pctLixo
            // 
            pctLixo.Image = Properties.Resources.lixoBranco;
            pctLixo.Location = new Point(500, 7);
            pctLixo.Margin = new Padding(3, 2, 3, 2);
            pctLixo.Name = "pctLixo";
            pctLixo.Size = new Size(30, 26);
            pctLixo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLixo.TabIndex = 5;
            pctLixo.TabStop = false;
            pctLixo.Click += pctLixo_Click;
            pctLixo.MouseEnter += pctLixo_MouseEnter;
            pctLixo.MouseLeave += pctLixo_MouseLeave;
            // 
            // pctEditar
            // 
            pctEditar.Image = Properties.Resources.pencil_white;
            pctEditar.Location = new Point(536, 7);
            pctEditar.Margin = new Padding(3, 2, 3, 2);
            pctEditar.Name = "pctEditar";
            pctEditar.Size = new Size(30, 26);
            pctEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pctEditar.TabIndex = 6;
            pctEditar.TabStop = false;
            pctEditar.Click += pctEditar_Click;
            pctEditar.MouseEnter += pctEditar_MouseEnter;
            pctEditar.MouseLeave += pctEditar_MouseLeave;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(10, 33);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 19);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente: ";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(10, 53);
            lblData.Name = "lblData";
            lblData.Size = new Size(37, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data: ";
            // 
            // LucasLItemOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblCliente);
            Controls.Add(lblData);
            Controls.Add(lblStatus);
            Controls.Add(pctEditar);
            Controls.Add(lblValor);
            Controls.Add(pctLixo);
            Controls.Add(pctAprovacao);
            Controls.Add(pnlObs);
            Controls.Add(lblNOrc);
            Name = "LucasLItemOrcamento";
            Padding = new Padding(2);
            Size = new Size(617, 143);
            pnlObs.ResumeLayout(false);
            pnlObs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctAprovacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLixo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNOrc;
        private Label lblValor;
        private Label lblResumo;
        private Label lblStatus;
        private Panel pnlObs;
        private Label lblObs;
        private Controles.LucasCircularPictureBox pctAprovacao;
        private PictureBox pctLixo;
        private PictureBox pctEditar;
        private Label lblCliente;
        private Label lblData;
    }
}