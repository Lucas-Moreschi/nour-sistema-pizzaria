namespace NourPizzaria.Forms
{
    partial class FrmNovoOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpCliente = new GroupBox();
            panel1 = new Panel();
            cmbClientes = new NourPizzaria.Controles.LucasComboBox();
            btnAdicionarCliente = new Button();
            grpItens = new GroupBox();
            cmbItem = new NourPizzaria.Controles.LucasComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSalvarItem = new Button();
            txtObservacoes = new NourPizzaria.Controles.LucasTextBox();
            numQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            btnDescartar = new Button();
            btnGerarOrcamento = new Button();
            grpCliente.SuspendLayout();
            panel1.SuspendLayout();
            grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // grpCliente
            // 
            grpCliente.Controls.Add(panel1);
            grpCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCliente.ForeColor = Color.White;
            grpCliente.Location = new Point(680, 12);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(439, 84);
            grpCliente.TabIndex = 5;
            grpCliente.TabStop = false;
            grpCliente.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbClientes);
            panel1.Controls.Add(btnAdicionarCliente);
            panel1.Location = new Point(11, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 47);
            panel1.TabIndex = 5;
            // 
            // cmbClientes
            // 
            cmbClientes.BackColor = Color.Gray;
            cmbClientes.BorderColor = Color.White;
            cmbClientes.BorderSize = 2;
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDown;
            cmbClientes.Font = new Font("Segoe UI", 10F);
            cmbClientes.ForeColor = Color.White;
            cmbClientes.IconColor = Color.MediumSpringGreen;
            cmbClientes.ListBackColor = Color.Gray;
            cmbClientes.ListTextColor = Color.White;
            cmbClientes.Location = new Point(39, 8);
            cmbClientes.MinimumSize = new Size(200, 30);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Padding = new Padding(2);
            cmbClientes.Size = new Size(370, 30);
            cmbClientes.TabIndex = 3;
            cmbClientes.Texts = "Selecione o cliente";
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.BackColor = Color.Transparent;
            btnAdicionarCliente.BackgroundImage = Properties.Resources.adicionar24px;
            btnAdicionarCliente.BackgroundImageLayout = ImageLayout.Center;
            btnAdicionarCliente.FlatAppearance.BorderSize = 0;
            btnAdicionarCliente.FlatStyle = FlatStyle.Flat;
            btnAdicionarCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarCliente.ForeColor = Color.White;
            btnAdicionarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarCliente.Location = new Point(6, 8);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Padding = new Padding(12, 0, 0, 0);
            btnAdicionarCliente.Size = new Size(27, 29);
            btnAdicionarCliente.TabIndex = 2;
            btnAdicionarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarCliente.UseVisualStyleBackColor = false;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // grpItens
            // 
            grpItens.Controls.Add(cmbItem);
            grpItens.Controls.Add(flowLayoutPanel1);
            grpItens.Controls.Add(btnSalvarItem);
            grpItens.Controls.Add(txtObservacoes);
            grpItens.Controls.Add(numQuantidade);
            grpItens.Controls.Add(lblQuantidade);
            grpItens.Font = new Font("Segoe UI", 10F);
            grpItens.ForeColor = Color.White;
            grpItens.Location = new Point(12, 12);
            grpItens.Name = "grpItens";
            grpItens.Size = new Size(659, 575);
            grpItens.TabIndex = 6;
            grpItens.TabStop = false;
            grpItens.Text = "Itens";
            // 
            // cmbItem
            // 
            cmbItem.BackColor = Color.Gray;
            cmbItem.BorderColor = Color.White;
            cmbItem.BorderSize = 2;
            cmbItem.DropDownStyle = ComboBoxStyle.DropDown;
            cmbItem.Font = new Font("Segoe UI", 10F);
            cmbItem.ForeColor = Color.White;
            cmbItem.IconColor = Color.MediumSpringGreen;
            cmbItem.ListBackColor = Color.Gray;
            cmbItem.ListTextColor = Color.White;
            cmbItem.Location = new Point(6, 30);
            cmbItem.MinimumSize = new Size(200, 30);
            cmbItem.Name = "cmbItem";
            cmbItem.Padding = new Padding(2);
            cmbItem.Size = new Size(370, 30);
            cmbItem.TabIndex = 7;
            cmbItem.Texts = "Selecione o item";
            cmbItem.OnSelectedIndexChanged += cmbItem_OnSelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 227);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(653, 345);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnSalvarItem
            // 
            btnSalvarItem.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvarItem.FlatStyle = FlatStyle.Flat;
            btnSalvarItem.ForeColor = Color.White;
            btnSalvarItem.Location = new Point(383, 162);
            btnSalvarItem.Name = "btnSalvarItem";
            btnSalvarItem.Size = new Size(273, 57);
            btnSalvarItem.TabIndex = 6;
            btnSalvarItem.Text = "Salvar Item";
            btnSalvarItem.UseVisualStyleBackColor = false;
            btnSalvarItem.Click += btnSalvarItem_Click;
            // 
            // txtObservacoes
            // 
            txtObservacoes.BackColor = Color.Gray;
            txtObservacoes.BorderColor = Color.White;
            txtObservacoes.BorderFocusColor = Color.MediumSpringGreen;
            txtObservacoes.BorderSize = 2;
            txtObservacoes.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacoes.ForeColor = Color.White;
            txtObservacoes.Hint = "Observações";
            txtObservacoes.HintForeColor = Color.Gainsboro;
            txtObservacoes.Location = new Point(6, 66);
            txtObservacoes.Margin = new Padding(4);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Padding = new Padding(7);
            txtObservacoes.PasswordChar = false;
            txtObservacoes.Size = new Size(370, 153);
            txtObservacoes.TabIndex = 5;
            txtObservacoes.Texts = "";
            txtObservacoes.UnderlinedStyle = false;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Segoe UI", 10F);
            numQuantidade.Location = new Point(382, 35);
            numQuantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(100, 25);
            numQuantidade.TabIndex = 8;
            numQuantidade.TextAlign = HorizontalAlignment.Center;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantidade
            // 
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 10F);
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Location = new Point(382, 12);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(85, 20);
            lblQuantidade.TabIndex = 0;
            lblQuantidade.Text = "Quantidade:";
            // 
            // btnDescartar
            // 
            btnDescartar.BackColor = Color.FromArgb(102, 102, 102);
            btnDescartar.FlatStyle = FlatStyle.Flat;
            btnDescartar.ForeColor = Color.White;
            btnDescartar.Location = new Point(680, 527);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(213, 57);
            btnDescartar.TabIndex = 7;
            btnDescartar.Text = "Descartar tudo";
            btnDescartar.UseVisualStyleBackColor = false;
            btnDescartar.Click += btnDescartar_Click;
            // 
            // btnGerarOrcamento
            // 
            btnGerarOrcamento.BackColor = Color.FromArgb(62, 142, 65);
            btnGerarOrcamento.FlatStyle = FlatStyle.Flat;
            btnGerarOrcamento.ForeColor = Color.White;
            btnGerarOrcamento.Location = new Point(906, 527);
            btnGerarOrcamento.Name = "btnGerarOrcamento";
            btnGerarOrcamento.Size = new Size(213, 57);
            btnGerarOrcamento.TabIndex = 8;
            btnGerarOrcamento.Text = "Gerar orçamento";
            btnGerarOrcamento.UseVisualStyleBackColor = false;
            btnGerarOrcamento.Click += btnGerarOrcamento_Click;
            // 
            // FrmNovoOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(btnGerarOrcamento);
            Controls.Add(btnDescartar);
            Controls.Add(grpCliente);
            Controls.Add(grpItens);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNovoOrcamento";
            Text = "Novo Orçamento";
            Load += FrmNovoOrcamento_Load;
            grpCliente.ResumeLayout(false);
            panel1.ResumeLayout(false);
            grpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox grpCliente;
        private Panel panel1;
        private Controles.LucasComboBox cmbClientes;
        private Button btnAdicionarCliente;
        private GroupBox grpItens;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSalvarItem;
        private Controles.LucasTextBox txtObservacoes;
        private Button btnDescartar;
        private Button btnGerarOrcamento;
        private Controles.LucasComboBox cmbItem;
        private NumericUpDown numQuantidade;
        private Label lblQuantidade;
    }
}