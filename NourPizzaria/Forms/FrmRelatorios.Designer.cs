namespace NourPizzaria.Forms
{
    partial class FrmRelatorios
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
            btnGerar = new Button();
            dgvResultados = new DataGridView();
            lblRelatorio = new Label();
            lblTitulo = new Label();
            lucasComboBox1 = new NourPizzaria.Controles.LucasComboBox();
            pnlFiltros = new Panel();
            btnExcel = new Button();
            btnPDF = new Button();
            label2 = new Label();
            label1 = new Label();
            dtLimite = new DateTimePicker();
            dtInicio = new DateTimePicker();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            pnlFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(62, 142, 65);
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.ForeColor = Color.White;
            btnGerar.Location = new Point(914, 75);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(186, 27);
            btnGerar.TabIndex = 4;
            btnGerar.Text = "Gerar Relatório";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.Gray;
            dgvResultados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvResultados.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(247, 220, 111);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle4;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.Font = new Font("Segoe UI", 10F);
            dgvResultados.GridColor = Color.FromArgb(102, 102, 102);
            dgvResultados.Location = new Point(20, 190);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(1080, 390);
            dgvResultados.TabIndex = 5;
            // 
            // lblRelatorio
            // 
            lblRelatorio.AutoSize = true;
            lblRelatorio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelatorio.ForeColor = Color.White;
            lblRelatorio.Location = new Point(21, 78);
            lblRelatorio.Name = "lblRelatorio";
            lblRelatorio.Size = new Size(128, 20);
            lblRelatorio.TabIndex = 1;
            lblRelatorio.Text = "Tipo de Relatório:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(129, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Relatórios";
            // 
            // lucasComboBox1
            // 
            lucasComboBox1.BackColor = Color.Gray;
            lucasComboBox1.BorderColor = Color.White;
            lucasComboBox1.BorderSize = 2;
            lucasComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            lucasComboBox1.Font = new Font("Segoe UI", 10F);
            lucasComboBox1.ForeColor = Color.White;
            lucasComboBox1.IconColor = Color.MediumSpringGreen;
            lucasComboBox1.Items.AddRange(new object[] { "Vendas por Período", "Vendas por Categoria de Item", "Ranking de Itens Mais Vendidos", "Itens Menos Vendidos", "Clientes que Mais Compram", "Frequência de Pedidos por Cliente", "Clientes Inativos", "Orçamentos por Status", "Taxa de Conversão de Orçamentos" });
            lucasComboBox1.ListBackColor = Color.Gray;
            lucasComboBox1.ListTextColor = Color.White;
            lucasComboBox1.Location = new Point(155, 75);
            lucasComboBox1.Name = "lucasComboBox1";
            lucasComboBox1.Padding = new Padding(1);
            lucasComboBox1.Size = new Size(264, 27);
            lucasComboBox1.TabIndex = 6;
            lucasComboBox1.Texts = "";
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.Gray;
            pnlFiltros.Controls.Add(btnExcel);
            pnlFiltros.Controls.Add(btnPDF);
            pnlFiltros.Controls.Add(label2);
            pnlFiltros.Controls.Add(label1);
            pnlFiltros.Controls.Add(dtLimite);
            pnlFiltros.Controls.Add(dtInicio);
            pnlFiltros.Location = new Point(20, 120);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(1080, 60);
            pnlFiltros.TabIndex = 3;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(62, 142, 65);
            btnExcel.Dock = DockStyle.Right;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(894, 0);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(93, 60);
            btnExcel.TabIndex = 12;
            btnExcel.Text = "Exportar\r\nExcel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Visible = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.FromArgb(62, 142, 65);
            btnPDF.Dock = DockStyle.Right;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.ForeColor = Color.White;
            btnPDF.Location = new Point(987, 0);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(93, 60);
            btnPDF.TabIndex = 7;
            btnPDF.Text = "Exportar\r\nPDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Visible = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(327, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Data de término";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 10;
            label1.Text = "Data de início";
            // 
            // dtLimite
            // 
            dtLimite.Location = new Point(327, 28);
            dtLimite.Name = "dtLimite";
            dtLimite.Size = new Size(200, 23);
            dtLimite.TabIndex = 1;
            dtLimite.ValueChanged += dtLimite_ValueChanged;
            // 
            // dtInicio
            // 
            dtInicio.Location = new Point(27, 28);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(200, 23);
            dtInicio.TabIndex = 0;
            dtInicio.ValueChanged += dtInicio_ValueChanged;
            // 
            // saveFileDialog
            // 
            saveFileDialog.FileOk += saveFileDialog1_FileOk;
            // 
            // FrmRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(lucasComboBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblRelatorio);
            Controls.Add(pnlFiltros);
            Controls.Add(btnGerar);
            Controls.Add(dgvResultados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRelatorios";
            Text = "Relatórios";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label lblRelatorio;
        private Label lblTitulo;
        private Controles.LucasComboBox lucasComboBox1;
        private Panel pnlFiltros;
        private DateTimePicker dtLimite;
        private DateTimePicker dtInicio;
        private Label label2;
        private Label label1;
        private Button btnPDF;
        private Button btnExcel;
        private SaveFileDialog saveFileDialog;
    }
}