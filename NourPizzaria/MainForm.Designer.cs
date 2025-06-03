namespace NourPizzaria
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            pnlSubConfiguracoes = new Panel();
            btnConfiguracoesPizzaria = new Button();
            btnAdicionarItens = new Button();
            btnConfiguracoes = new Button();
            btnRelatorios = new Button();
            btnCadastroClientes = new Button();
            btnPedidos = new Button();
            pnlSubOrcamentos = new Panel();
            btnConsultarOrcamentos = new Button();
            btnNovoOrcamento = new Button();
            btnOrcamentos = new Button();
            panelLogo = new Panel();
            lucasCircularPictureBox1 = new NourPizzaria.Controles.LucasCircularPictureBox();
            label1 = new Label();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            pnlSubConfiguracoes.SuspendLayout();
            pnlSubOrcamentos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lucasCircularPictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Gray;
            panelMenu.Controls.Add(pnlSubConfiguracoes);
            panelMenu.Controls.Add(btnConfiguracoes);
            panelMenu.Controls.Add(btnRelatorios);
            panelMenu.Controls.Add(btnCadastroClientes);
            panelMenu.Controls.Add(btnPedidos);
            panelMenu.Controls.Add(pnlSubOrcamentos);
            panelMenu.Controls.Add(btnOrcamentos);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(273, 700);
            panelMenu.TabIndex = 0;
            // 
            // pnlSubConfiguracoes
            // 
            pnlSubConfiguracoes.AutoSize = true;
            pnlSubConfiguracoes.Controls.Add(btnConfiguracoesPizzaria);
            pnlSubConfiguracoes.Controls.Add(btnAdicionarItens);
            pnlSubConfiguracoes.Dock = DockStyle.Top;
            pnlSubConfiguracoes.Location = new Point(0, 521);
            pnlSubConfiguracoes.Name = "pnlSubConfiguracoes";
            pnlSubConfiguracoes.Size = new Size(273, 120);
            pnlSubConfiguracoes.TabIndex = 22;
            pnlSubConfiguracoes.Visible = false;
            // 
            // btnConfiguracoesPizzaria
            // 
            btnConfiguracoesPizzaria.BackColor = Color.Transparent;
            btnConfiguracoesPizzaria.Dock = DockStyle.Top;
            btnConfiguracoesPizzaria.FlatAppearance.BorderSize = 0;
            btnConfiguracoesPizzaria.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnConfiguracoesPizzaria.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnConfiguracoesPizzaria.FlatStyle = FlatStyle.Flat;
            btnConfiguracoesPizzaria.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracoesPizzaria.ForeColor = Color.White;
            btnConfiguracoesPizzaria.Image = (Image)resources.GetObject("btnConfiguracoesPizzaria.Image");
            btnConfiguracoesPizzaria.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoesPizzaria.Location = new Point(0, 60);
            btnConfiguracoesPizzaria.Name = "btnConfiguracoesPizzaria";
            btnConfiguracoesPizzaria.Padding = new Padding(12, 0, 0, 0);
            btnConfiguracoesPizzaria.Size = new Size(273, 60);
            btnConfiguracoesPizzaria.TabIndex = 3;
            btnConfiguracoesPizzaria.Text = "  Editar produtos/clientes";
            btnConfiguracoesPizzaria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracoesPizzaria.UseVisualStyleBackColor = false;
            btnConfiguracoesPizzaria.Click += btnsSecundarios_Click;
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.BackColor = Color.Transparent;
            btnAdicionarItens.Dock = DockStyle.Top;
            btnAdicionarItens.FlatAppearance.BorderSize = 0;
            btnAdicionarItens.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnAdicionarItens.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnAdicionarItens.FlatStyle = FlatStyle.Flat;
            btnAdicionarItens.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionarItens.ForeColor = Color.White;
            btnAdicionarItens.Image = Properties.Resources.plus;
            btnAdicionarItens.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarItens.Location = new Point(0, 0);
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(12, 0, 0, 0);
            btnAdicionarItens.Size = new Size(273, 60);
            btnAdicionarItens.TabIndex = 2;
            btnAdicionarItens.Text = "  Adicionar Itens";
            btnAdicionarItens.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarItens.UseVisualStyleBackColor = false;
            btnAdicionarItens.Click += btnsSecundarios_Click;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConfiguracoes.Dock = DockStyle.Top;
            btnConfiguracoes.FlatAppearance.BorderSize = 0;
            btnConfiguracoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnConfiguracoes.FlatStyle = FlatStyle.Flat;
            btnConfiguracoes.Font = new Font("Segoe UI", 10.2F);
            btnConfiguracoes.ForeColor = Color.White;
            btnConfiguracoes.Image = Properties.Resources.settings_branco32px;
            btnConfiguracoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.Location = new Point(0, 461);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Padding = new Padding(12, 0, 0, 0);
            btnConfiguracoes.Size = new Size(273, 60);
            btnConfiguracoes.TabIndex = 21;
            btnConfiguracoes.Text = "  Configurações";
            btnConfiguracoes.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.Click += btnsPrincipais_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.Transparent;
            btnRelatorios.Dock = DockStyle.Top;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Font = new Font("Segoe UI", 10.2F);
            btnRelatorios.ForeColor = Color.White;
            btnRelatorios.Image = Properties.Resources.relatorio_branco32px;
            btnRelatorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Location = new Point(0, 401);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Padding = new Padding(12, 0, 0, 0);
            btnRelatorios.Size = new Size(273, 60);
            btnRelatorios.TabIndex = 20;
            btnRelatorios.Text = "  Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnsPrincipais_Click;
            // 
            // btnCadastroClientes
            // 
            btnCadastroClientes.BackColor = Color.Transparent;
            btnCadastroClientes.Dock = DockStyle.Top;
            btnCadastroClientes.FlatAppearance.BorderSize = 0;
            btnCadastroClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnCadastroClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnCadastroClientes.FlatStyle = FlatStyle.Flat;
            btnCadastroClientes.Font = new Font("Segoe UI", 10.2F);
            btnCadastroClientes.ForeColor = Color.White;
            btnCadastroClientes.Image = Properties.Resources.cadastrocliente_branco32px;
            btnCadastroClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroClientes.Location = new Point(0, 341);
            btnCadastroClientes.Name = "btnCadastroClientes";
            btnCadastroClientes.Padding = new Padding(12, 0, 0, 0);
            btnCadastroClientes.Size = new Size(273, 60);
            btnCadastroClientes.TabIndex = 19;
            btnCadastroClientes.Text = "  Cadastro de clientes";
            btnCadastroClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastroClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastroClientes.UseVisualStyleBackColor = false;
            btnCadastroClientes.Click += btnsPrincipais_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.Transparent;
            btnPedidos.Dock = DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 10.2F);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = Properties.Resources.pedido_branco32px;
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(0, 281);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new Padding(12, 0, 0, 0);
            btnPedidos.Size = new Size(273, 60);
            btnPedidos.TabIndex = 14;
            btnPedidos.Text = "  Pedidos";
            btnPedidos.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnsPrincipais_Click;
            // 
            // pnlSubOrcamentos
            // 
            pnlSubOrcamentos.AutoSize = true;
            pnlSubOrcamentos.Controls.Add(btnConsultarOrcamentos);
            pnlSubOrcamentos.Controls.Add(btnNovoOrcamento);
            pnlSubOrcamentos.Dock = DockStyle.Top;
            pnlSubOrcamentos.Location = new Point(0, 161);
            pnlSubOrcamentos.Name = "pnlSubOrcamentos";
            pnlSubOrcamentos.Size = new Size(273, 120);
            pnlSubOrcamentos.TabIndex = 13;
            pnlSubOrcamentos.Visible = false;
            // 
            // btnConsultarOrcamentos
            // 
            btnConsultarOrcamentos.BackColor = Color.Transparent;
            btnConsultarOrcamentos.Dock = DockStyle.Top;
            btnConsultarOrcamentos.FlatAppearance.BorderSize = 0;
            btnConsultarOrcamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnConsultarOrcamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnConsultarOrcamentos.FlatStyle = FlatStyle.Flat;
            btnConsultarOrcamentos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarOrcamentos.ForeColor = Color.White;
            btnConsultarOrcamentos.Image = Properties.Resources.search;
            btnConsultarOrcamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultarOrcamentos.Location = new Point(0, 60);
            btnConsultarOrcamentos.Name = "btnConsultarOrcamentos";
            btnConsultarOrcamentos.Padding = new Padding(12, 0, 0, 0);
            btnConsultarOrcamentos.Size = new Size(273, 60);
            btnConsultarOrcamentos.TabIndex = 3;
            btnConsultarOrcamentos.Text = "  Consultar orçamentos";
            btnConsultarOrcamentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultarOrcamentos.UseVisualStyleBackColor = false;
            btnConsultarOrcamentos.Click += btnsSecundarios_Click;
            // 
            // btnNovoOrcamento
            // 
            btnNovoOrcamento.BackColor = Color.Transparent;
            btnNovoOrcamento.Dock = DockStyle.Top;
            btnNovoOrcamento.FlatAppearance.BorderSize = 0;
            btnNovoOrcamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnNovoOrcamento.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnNovoOrcamento.FlatStyle = FlatStyle.Flat;
            btnNovoOrcamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovoOrcamento.ForeColor = Color.White;
            btnNovoOrcamento.Image = Properties.Resources.plus;
            btnNovoOrcamento.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoOrcamento.Location = new Point(0, 0);
            btnNovoOrcamento.Name = "btnNovoOrcamento";
            btnNovoOrcamento.Padding = new Padding(12, 0, 0, 0);
            btnNovoOrcamento.Size = new Size(273, 60);
            btnNovoOrcamento.TabIndex = 2;
            btnNovoOrcamento.Text = "  Novo orçamento";
            btnNovoOrcamento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovoOrcamento.UseVisualStyleBackColor = false;
            btnNovoOrcamento.Click += btnsSecundarios_Click;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.BackColor = Color.Transparent;
            btnOrcamentos.Dock = DockStyle.Top;
            btnOrcamentos.FlatAppearance.BorderSize = 0;
            btnOrcamentos.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnOrcamentos.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnOrcamentos.FlatStyle = FlatStyle.Flat;
            btnOrcamentos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrcamentos.ForeColor = Color.White;
            btnOrcamentos.Image = Properties.Resources.orcamento_branco32px;
            btnOrcamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrcamentos.Location = new Point(0, 101);
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Padding = new Padding(12, 0, 0, 0);
            btnOrcamentos.Size = new Size(273, 60);
            btnOrcamentos.TabIndex = 1;
            btnOrcamentos.Text = "  Orçamentos";
            btnOrcamentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrcamentos.UseVisualStyleBackColor = false;
            btnOrcamentos.Click += btnsPrincipais_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(64, 64, 64);
            panelLogo.Controls.Add(lucasCircularPictureBox1);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(273, 101);
            panelLogo.TabIndex = 0;
            // 
            // lucasCircularPictureBox1
            // 
            lucasCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            lucasCircularPictureBox1.BorderColor = Color.Transparent;
            lucasCircularPictureBox1.BorderColor2 = Color.Transparent;
            lucasCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            lucasCircularPictureBox1.BorderSize = 2;
            lucasCircularPictureBox1.GradientAngle = 50F;
            lucasCircularPictureBox1.Image = Properties.Resources.logotipo;
            lucasCircularPictureBox1.Location = new Point(6, 2);
            lucasCircularPictureBox1.Name = "lucasCircularPictureBox1";
            lucasCircularPictureBox1.Size = new Size(96, 96);
            lucasCircularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            lucasCircularPictureBox1.TabIndex = 2;
            lucasCircularPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 38);
            label1.Name = "label1";
            label1.Size = new Size(162, 26);
            label1.TabIndex = 1;
            label1.Text = "Pizzaria Delicia";
            label1.Click += label1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Gray;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(273, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1127, 101);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.AutoSize = true;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 15F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1009, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(38, 35);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "ꟷ";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.AutoSize = true;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 15F);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1052, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(35, 35);
            btnMaximize.TabIndex = 3;
            btnMaximize.Text = "o";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 152, 75);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 142, 65);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 15F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1092, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseChildForm.ForeColor = Color.White;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 101);
            btnCloseChildForm.TabIndex = 1;
            btnCloseChildForm.Text = "X";
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Visible = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(534, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nour";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.FromArgb(64, 64, 64);
            panelDesktopPane.BackgroundImageLayout = ImageLayout.Stretch;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(273, 101);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1127, 599);
            panelDesktopPane.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(1400, 700);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(948, 488);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            Resize += MainForm_Resize;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            pnlSubConfiguracoes.ResumeLayout(false);
            pnlSubOrcamentos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lucasCircularPictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnOrcamentos;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Button btnCloseChildForm;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Label label1;
        private Panel panelDesktopPane;
        private Controles.LucasCircularPictureBox lucasCircularPictureBox1;
        private Button btnPedidos;
        private Panel pnlSubOrcamentos;
        private Button btnConsultarOrcamentos;
        private Button btnNovoOrcamento;
        private Button btnConfiguracoes;
        private Button btnRelatorios;
        private Button btnCadastroClientes;
        private Panel pnlSubConfiguracoes;
        private Button btnConfiguracoesPizzaria;
        private Button btnAdicionarItens;
    }
}