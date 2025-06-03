using NourPizzaria.Controles;

namespace NourPizzaria.Forms
{
    partial class FrmAdicionarItens
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblNome;
        private Controles.LucasTextBox txtNome;

        private Label lblDescricao;
        private Controles.LucasTextBox txtDescricao;

        private Label lblPreco;
        private Controles.LucasTextBox txtPreco;

        private Label lblCategoria;
        private Controles.LucasComboBox cmbCategoria;

        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnEditarItem;

        private DataGridView dgvItens;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblNome = new Label();
            txtNome = new LucasTextBox();
            lblDescricao = new Label();
            txtDescricao = new LucasTextBox();
            lblPreco = new Label();
            txtPreco = new LucasTextBox();
            lblCategoria = new Label();
            cmbCategoria = new LucasComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dgvItens = new DataGridView();
            btnEditarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(60, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 19);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome do Item";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Gray;
            txtNome.BorderColor = Color.White;
            txtNome.BorderFocusColor = Color.MediumSpringGreen;
            txtNome.BorderSize = 2;
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.ForeColor = Color.White;
            txtNome.Hint = "Ex: Pizza de Calabresa";
            txtNome.HintForeColor = Color.Gainsboro;
            txtNome.Location = new Point(60, 65);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(7);
            txtNome.PasswordChar = false;
            txtNome.Size = new Size(1000, 34);
            txtNome.TabIndex = 1;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(60, 115);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(146, 19);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição (opcional)";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.Gray;
            txtDescricao.BorderColor = Color.White;
            txtDescricao.BorderFocusColor = Color.MediumSpringGreen;
            txtDescricao.BorderSize = 2;
            txtDescricao.Font = new Font("Segoe UI", 10F);
            txtDescricao.ForeColor = Color.White;
            txtDescricao.Hint = "Ex: Massa fina, borda recheada...";
            txtDescricao.HintForeColor = Color.Gainsboro;
            txtDescricao.Location = new Point(60, 140);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Padding = new Padding(7);
            txtDescricao.PasswordChar = false;
            txtDescricao.Size = new Size(1000, 34);
            txtDescricao.TabIndex = 3;
            txtDescricao.Texts = "";
            txtDescricao.UnderlinedStyle = false;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPreco.ForeColor = Color.White;
            lblPreco.Location = new Point(60, 190);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(104, 19);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço unitário";
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.Gray;
            txtPreco.BorderColor = Color.White;
            txtPreco.BorderFocusColor = Color.MediumSpringGreen;
            txtPreco.BorderSize = 2;
            txtPreco.Font = new Font("Segoe UI", 10F);
            txtPreco.ForeColor = Color.White;
            txtPreco.Hint = "Ex: 49,90";
            txtPreco.HintForeColor = Color.Gainsboro;
            txtPreco.Location = new Point(60, 215);
            txtPreco.Margin = new Padding(4);
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.Padding = new Padding(7);
            txtPreco.PasswordChar = false;
            txtPreco.Size = new Size(200, 34);
            txtPreco.TabIndex = 5;
            txtPreco.Texts = "";
            txtPreco.UnderlinedStyle = false;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(290, 190);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 19);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.Gray;
            cmbCategoria.BorderColor = Color.White;
            cmbCategoria.BorderSize = 2;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.ForeColor = Color.White;
            cmbCategoria.IconColor = Color.MediumSpringGreen;
            cmbCategoria.ListBackColor = Color.Gray;
            cmbCategoria.ListTextColor = Color.White;
            cmbCategoria.Location = new Point(290, 215);
            cmbCategoria.MinimumSize = new Size(200, 30);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(2);
            cmbCategoria.Size = new Size(250, 30);
            cmbCategoria.TabIndex = 7;
            cmbCategoria.Texts = "Escolha uma categoria";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvar.FlatAppearance.BorderColor = Color.White;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(60, 290);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 45);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(260, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 45);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvItens
            // 
            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItens.BackgroundColor = Color.Gray;
            dgvItens.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItens.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(247, 220, 111);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItens.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItens.EnableHeadersVisualStyles = false;
            dgvItens.Font = new Font("Segoe UI", 10F);
            dgvItens.GridColor = Color.FromArgb(102, 102, 102);
            dgvItens.Location = new Point(60, 360);
            dgvItens.MultiSelect = false;
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.RowHeadersVisible = false;
            dgvItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new Size(1000, 150);
            dgvItens.TabIndex = 10;
            // 
            // btnEditarItem
            // 
            btnEditarItem.BackColor = Color.SteelBlue;
            btnEditarItem.FlatStyle = FlatStyle.Flat;
            btnEditarItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditarItem.ForeColor = Color.White;
            btnEditarItem.Location = new Point(60, 525);
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.Size = new Size(200, 40);
            btnEditarItem.TabIndex = 11;
            btnEditarItem.Tag = "";
            btnEditarItem.Text = "Editar Item Selecionado";
            btnEditarItem.UseVisualStyleBackColor = false;
            btnEditarItem.Click += btnEditarItem_Click;
            // 
            // FrmAdicionarItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvItens);
            Controls.Add(btnEditarItem);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdicionarItens";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Item ao Cardápio";
            Load += FrmAdicionarItens_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
