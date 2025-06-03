namespace NourPizzaria.Forms
{
    partial class FrmEditarOrcPed
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
            flowItens = new FlowLayoutPanel();
            lucasListItemEditavel1 = new NourPizzaria.Controls.LucasListItemEditavel();
            grpItens = new GroupBox();
            cmbItem = new NourPizzaria.Controles.LucasComboBox();
            btnSalvarItem = new Button();
            txtObservacoes = new NourPizzaria.Controles.LucasTextBox();
            numQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            grpCliente = new GroupBox();
            panel1 = new Panel();
            cmbClientes = new NourPizzaria.Controles.LucasComboBox();
            btnAdicionarCliente = new Button();
            btnSalvarAlteracoes = new Button();
            flowItens.SuspendLayout();
            grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            grpCliente.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowItens
            // 
            flowItens.AutoScroll = true;
            flowItens.BackColor = SystemColors.ActiveBorder;
            flowItens.Controls.Add(lucasListItemEditavel1);
            flowItens.Dock = DockStyle.Right;
            flowItens.FlowDirection = FlowDirection.TopDown;
            flowItens.Location = new Point(505, 0);
            flowItens.Name = "flowItens";
            flowItens.Size = new Size(622, 599);
            flowItens.TabIndex = 2;
            flowItens.WrapContents = false;
            // 
            // lucasListItemEditavel1
            // 
            lucasListItemEditavel1.BackColor = Color.Gray;
            lucasListItemEditavel1.BordaAtiva = true;
            lucasListItemEditavel1.CorBorda = Color.Black;
            lucasListItemEditavel1.CorFonteNomeItem = Color.White;
            lucasListItemEditavel1.CorFonteNumeroItem = Color.White;
            lucasListItemEditavel1.CorFonteObservacao = Color.Black;
            lucasListItemEditavel1.CorFonteTextoObservacao = Color.Black;
            lucasListItemEditavel1.EspessuraBorda = 2;
            lucasListItemEditavel1.Location = new Point(3, 4);
            lucasListItemEditavel1.Margin = new Padding(3, 4, 3, 4);
            lucasListItemEditavel1.Name = "lucasListItemEditavel1";
            lucasListItemEditavel1.NomeItem = "Nome do item";
            lucasListItemEditavel1.NumeroItem = "Item N°";
            lucasListItemEditavel1.Observacoes = "texto";
            lucasListItemEditavel1.Padding = new Padding(2);
            lucasListItemEditavel1.Size = new Size(616, 115);
            lucasListItemEditavel1.TabIndex = 0;
            lucasListItemEditavel1.TituloObservacao = "Observações:";
            // 
            // grpItens
            // 
            grpItens.Controls.Add(cmbItem);
            grpItens.Controls.Add(btnSalvarItem);
            grpItens.Controls.Add(txtObservacoes);
            grpItens.Controls.Add(numQuantidade);
            grpItens.Controls.Add(lblQuantidade);
            grpItens.Font = new Font("Segoe UI", 10F);
            grpItens.ForeColor = Color.White;
            grpItens.Location = new Point(5, 293);
            grpItens.Name = "grpItens";
            grpItens.Size = new Size(494, 231);
            grpItens.TabIndex = 7;
            grpItens.TabStop = false;
            grpItens.Text = "Itens";
            grpItens.Visible = false;
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
            // btnSalvarItem
            // 
            btnSalvarItem.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvarItem.FlatStyle = FlatStyle.Flat;
            btnSalvarItem.ForeColor = Color.White;
            btnSalvarItem.Location = new Point(383, 66);
            btnSalvarItem.Name = "btnSalvarItem";
            btnSalvarItem.Size = new Size(99, 153);
            btnSalvarItem.TabIndex = 6;
            btnSalvarItem.Text = "Atualizar item";
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
            numQuantidade.BackColor = Color.Gray;
            numQuantidade.Font = new Font("Segoe UI", 10F);
            numQuantidade.ForeColor = Color.White;
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
            // grpCliente
            // 
            grpCliente.Controls.Add(panel1);
            grpCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpCliente.ForeColor = Color.White;
            grpCliente.Location = new Point(5, 12);
            grpCliente.Name = "grpCliente";
            grpCliente.Size = new Size(494, 84);
            grpCliente.TabIndex = 8;
            grpCliente.TabStop = false;
            grpCliente.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbClientes);
            panel1.Controls.Add(btnAdicionarCliente);
            panel1.Location = new Point(7, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 47);
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
            cmbClientes.Size = new Size(433, 30);
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
            // btnSalvarAlteracoes
            // 
            btnSalvarAlteracoes.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvarAlteracoes.FlatStyle = FlatStyle.Flat;
            btnSalvarAlteracoes.ForeColor = Color.White;
            btnSalvarAlteracoes.Location = new Point(5, 530);
            btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            btnSalvarAlteracoes.Size = new Size(494, 57);
            btnSalvarAlteracoes.TabIndex = 9;
            btnSalvarAlteracoes.Text = "Salvar alterações";
            btnSalvarAlteracoes.UseVisualStyleBackColor = false;
            btnSalvarAlteracoes.Click += btnSalvarAlteracoes_Click;
            // 
            // FrmEditarOrcPed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(flowItens);
            Controls.Add(btnSalvarAlteracoes);
            Controls.Add(grpCliente);
            Controls.Add(grpItens);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarOrcPed";
            Text = "Editar ";
            flowItens.ResumeLayout(false);
            grpItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            grpCliente.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowItens;
        private GroupBox grpItens;
        private Controles.LucasComboBox cmbItem;
        private Button btnSalvarItem;
        private Controles.LucasTextBox txtObservacoes;
        private NumericUpDown numQuantidade;
        private Label lblQuantidade;
        private GroupBox grpCliente;
        private Panel panel1;
        private Controles.LucasComboBox cmbClientes;
        private Button btnAdicionarCliente;
        private Button btnSalvarAlteracoes;
        private Controls.LucasListItemEditavel lucasListItemEditavel1;
    }
}