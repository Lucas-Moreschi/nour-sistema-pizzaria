using NourPizzaria.Controles;
using NourPizzaria.Controls;

namespace NourPizzaria.Forms
{
    partial class FrmCadastroClientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblEndereco = new Label();
            txtNome = new LucasTextBox();
            txtTelefone = new LucasMaskedTextBox();
            txtEmail = new LucasTextBox();
            txtEndereco = new LucasTextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnListar = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Clientes";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(20, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(480, 80);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(20, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.ForeColor = Color.White;
            lblEndereco.Location = new Point(480, 120);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 7;
            lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Gray;
            txtNome.BorderColor = Color.White;
            txtNome.BorderFocusColor = Color.MediumSpringGreen;
            txtNome.BorderSize = 2;
            txtNome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.White;
            txtNome.Hint = "Digite o nome completo";
            txtNome.HintForeColor = Color.Gainsboro;
            txtNome.Location = new Point(100, 75);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(7);
            txtNome.PasswordChar = false;
            txtNome.Size = new Size(350, 31);
            txtNome.TabIndex = 2;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = false;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.Gray;
            txtTelefone.BorderColor = Color.White;
            txtTelefone.BorderFocusColor = Color.MediumSpringGreen;
            txtTelefone.BorderSize = 2;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTelefone.ForeColor = Color.White;
            txtTelefone.Location = new Point(560, 73);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Padding = new Padding(7);
            txtTelefone.Size = new Size(200, 31);
            txtTelefone.TabIndex = 4;
            txtTelefone.Texts = "(  )      -";
            txtTelefone.UnderlinedStyle = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gray;
            txtEmail.BorderColor = Color.White;
            txtEmail.BorderFocusColor = Color.MediumSpringGreen;
            txtEmail.BorderSize = 2;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Hint = "Digite o e-mail";
            txtEmail.HintForeColor = Color.Gainsboro;
            txtEmail.Location = new Point(100, 115);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(350, 31);
            txtEmail.TabIndex = 6;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.Gray;
            txtEndereco.BorderColor = Color.White;
            txtEndereco.BorderFocusColor = Color.MediumSpringGreen;
            txtEndereco.BorderSize = 2;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.ForeColor = Color.White;
            txtEndereco.Hint = "Digite o endereço";
            txtEndereco.HintForeColor = Color.Gainsboro;
            txtEndereco.Location = new Point(560, 115);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.Multiline = false;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Padding = new Padding(7);
            txtEndereco.PasswordChar = false;
            txtEndereco.Size = new Size(400, 31);
            txtEndereco.TabIndex = 8;
            txtEndereco.Texts = "";
            txtEndereco.UnderlinedStyle = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(100, 160);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(210, 160);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 30);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(44, 130, 201);
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.ForeColor = Color.White;
            btnListar.Location = new Point(320, 160);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(130, 30);
            btnListar.TabIndex = 11;
            btnListar.Text = "Listar Clientes";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.Gray;
            dgvClientes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(247, 220, 111);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Font = new Font("Segoe UI", 10F);
            dgvClientes.GridColor = Color.FromArgb(102, 102, 102);
            dgvClientes.Location = new Point(20, 210);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(1080, 360);
            dgvClientes.TabIndex = 1;
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(lblTitulo);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnListar);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroClientes";
            Text = "Cadastrar Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblEndereco;
        private LucasTextBox txtNome;
        private LucasMaskedTextBox txtTelefone;
        private LucasTextBox txtEmail;
        private LucasTextBox txtEndereco;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnListar;
        private DataGridView dgvClientes;
        private Controles.LucasTextBox lucasTextBox1;
    }
}