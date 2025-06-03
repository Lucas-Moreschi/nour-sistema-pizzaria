namespace NourPizzaria.Controls
{
    partial class LucasLItemPedido
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
            lblNItem = new Label();
            lblCliente = new Label();
            lblData = new Label();
            pnlObs = new Panel();
            lblObs = new Label();
            lblValor = new Label();
            lblStatus = new Label();
            pctEditar = new PictureBox();
            pctLixo = new PictureBox();
            lucasComboBox1 = new NourPizzaria.Controles.LucasComboBox();
            pnlObs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctEditar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctLixo).BeginInit();
            SuspendLayout();
            // 
            // lblNItem
            // 
            lblNItem.AutoSize = true;
            lblNItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNItem.ForeColor = Color.White;
            lblNItem.Location = new Point(10, 10);
            lblNItem.Name = "lblNItem";
            lblNItem.Size = new Size(127, 21);
            lblNItem.TabIndex = 0;
            lblNItem.Text = "Pedido N° 0000";
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
            // pnlObs
            // 
            pnlObs.AutoScroll = true;
            pnlObs.BackColor = Color.FromArgb(235, 235, 235);
            pnlObs.Controls.Add(lblObs);
            pnlObs.Dock = DockStyle.Bottom;
            pnlObs.Location = new Point(2, 71);
            pnlObs.Name = "pnlObs";
            pnlObs.Padding = new Padding(0, 3, 0, 3);
            pnlObs.Size = new Size(613, 70);
            pnlObs.TabIndex = 1;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblObs.ForeColor = Color.Black;
            lblObs.Location = new Point(0, 3);
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
            lblValor.Location = new Point(251, 10);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(114, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor total: R$ 0";
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(247, 220, 111);
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(426, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Padding = new Padding(6, 3, 6, 3);
            lblStatus.Size = new Size(85, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Em preparo";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.TextChanged += lblStatus_TextChanged;
            lblStatus.Click += lblStatus_Click;
            // 
            // pctEditar
            // 
            pctEditar.Image = Properties.Resources.pencil_white;
            pctEditar.Location = new Point(582, 7);
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
            // pctLixo
            // 
            pctLixo.Image = Properties.Resources.lixoBranco;
            pctLixo.Location = new Point(546, 7);
            pctLixo.Margin = new Padding(3, 2, 3, 2);
            pctLixo.Name = "pctLixo";
            pctLixo.Size = new Size(30, 26);
            pctLixo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLixo.TabIndex = 7;
            pctLixo.TabStop = false;
            pctLixo.Click += pctLixo_Click;
            pctLixo.MouseEnter += pctLixo_MouseEnter;
            pctLixo.MouseLeave += pctLixo_MouseLeave;
            // 
            // lucasComboBox1
            // 
            lucasComboBox1.BackColor = Color.WhiteSmoke;
            lucasComboBox1.BorderColor = Color.WhiteSmoke;
            lucasComboBox1.BorderSize = 0;
            lucasComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            lucasComboBox1.Font = new Font("Segoe UI", 10F);
            lucasComboBox1.ForeColor = Color.WhiteSmoke;
            lucasComboBox1.IconColor = Color.WhiteSmoke;
            lucasComboBox1.Items.AddRange(new object[] { "Em preparo", "Pronto", "Entregue", "Cancelado" });
            lucasComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            lucasComboBox1.ListTextColor = Color.WhiteSmoke;
            lucasComboBox1.Location = new Point(426, 9);
            lucasComboBox1.Name = "lucasComboBox1";
            lucasComboBox1.Size = new Size(114, 21);
            lucasComboBox1.TabIndex = 8;
            lucasComboBox1.Texts = "";
            lucasComboBox1.OnSelectedIndexChanged += lucasComboBox1_OnSelectedIndexChanged;
            // 
            // LucasLItemPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(lblCliente);
            Controls.Add(lblData);
            Controls.Add(pctLixo);
            Controls.Add(lblStatus);
            Controls.Add(pctEditar);
            Controls.Add(lblValor);
            Controls.Add(pnlObs);
            Controls.Add(lblNItem);
            Controls.Add(lucasComboBox1);
            Name = "LucasLItemPedido";
            Padding = new Padding(2);
            Size = new Size(617, 143);
            pnlObs.ResumeLayout(false);
            pnlObs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctEditar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctLixo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNItem;
        private Label lblCliente;
        private Label lblData;
        private Label lblValor;
        private Label lblStatus;
        private Panel pnlObs;
        private Label lblObs;
        private PictureBox pctEditar;
        private PictureBox pctLixo;
        private Controles.LucasComboBox lucasComboBox1;
    }
}
