namespace NourPizzaria.Forms
{
    partial class FrmEditar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtNome = new NourPizzaria.Controles.LucasTextBox();
            txtDescricao = new NourPizzaria.Controles.LucasTextBox();
            txtPreco = new NourPizzaria.Controles.LucasTextBox();
            cmbCategoria = new NourPizzaria.Controles.LucasComboBox();
            txtEmail = new NourPizzaria.Controles.LucasTextBox();
            txtEndereco = new NourPizzaria.Controles.LucasTextBox();
            btnSalvar = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            txtTelefone = new NourPizzaria.Controls.LucasMaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(202, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(81, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Gray;
            txtNome.BorderColor = Color.White;
            txtNome.BorderFocusColor = Color.MediumSpringGreen;
            txtNome.BorderSize = 2;
            txtNome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = Color.White;
            txtNome.Hint = "Nome";
            txtNome.HintForeColor = Color.Gainsboro;
            txtNome.Location = new Point(52, 123);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(7);
            txtNome.PasswordChar = false;
            txtNome.Size = new Size(380, 31);
            txtNome.TabIndex = 2;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = false;
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
            txtDescricao.Location = new Point(52, 173);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Padding = new Padding(7);
            txtDescricao.PasswordChar = false;
            txtDescricao.Size = new Size(380, 34);
            txtDescricao.TabIndex = 3;
            txtDescricao.Texts = "";
            txtDescricao.UnderlinedStyle = false;
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
            txtPreco.Location = new Point(52, 223);
            txtPreco.Margin = new Padding(4);
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.Padding = new Padding(7);
            txtPreco.PasswordChar = false;
            txtPreco.Size = new Size(180, 34);
            txtPreco.TabIndex = 4;
            txtPreco.Texts = "";
            txtPreco.UnderlinedStyle = false;
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
            cmbCategoria.Location = new Point(252, 223);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(2);
            cmbCategoria.Size = new Size(180, 31);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.Texts = "";
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
            txtEmail.Location = new Point(252, 223);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(180, 31);
            txtEmail.TabIndex = 7;
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
            txtEndereco.Location = new Point(52, 173);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.Multiline = false;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Padding = new Padding(7);
            txtEndereco.PasswordChar = false;
            txtEndereco.Size = new Size(380, 31);
            txtEndereco.TabIndex = 8;
            txtEndereco.Texts = "";
            txtEndereco.UnderlinedStyle = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(62, 142, 65);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(152, 297);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.FromArgb(64, 70, 60);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 74, 74);
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 15F);
            btnClose.ForeColor = Color.White;
            btnClose.ImageAlign = ContentAlignment.MiddleRight;
            btnClose.Location = new Point(447, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 35);
            btnClose.TabIndex = 10;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 70, 60);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 100);
            panel1.TabIndex = 11;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.Gray;
            txtTelefone.BorderColor = Color.White;
            txtTelefone.BorderFocusColor = Color.MediumSpringGreen;
            txtTelefone.BorderSize = 2;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTelefone.ForeColor = Color.White;
            txtTelefone.Location = new Point(52, 223);
            txtTelefone.Margin = new Padding(4);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Padding = new Padding(7);
            txtTelefone.Size = new Size(180, 31);
            txtTelefone.TabIndex = 12;
            txtTelefone.Texts = "(  )      -";
            txtTelefone.UnderlinedStyle = false;
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(484, 377);
            Controls.Add(txtTelefone);
            Controls.Add(btnClose);
            Controls.Add(btnSalvar);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(panel1);
            Controls.Add(txtPreco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Registro";
            Load += FrmEditar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Controles.LucasTextBox txtNome;
        private Controles.LucasTextBox txtDescricao;
        private Controles.LucasTextBox txtPreco;
        private Controles.LucasComboBox cmbCategoria;
        private Controles.LucasTextBox txtEmail;
        private Controles.LucasTextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private Button btnClose;
        private Panel panel1;
        private Controls.LucasMaskedTextBox txtTelefone;
    }
}
