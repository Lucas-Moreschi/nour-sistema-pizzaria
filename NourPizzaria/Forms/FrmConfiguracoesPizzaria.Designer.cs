namespace NourPizzaria.Forms
{
    partial class FrmConfiguracoesPizzaria
    {
        private System.ComponentModel.IContainer components = null;

        // Controles
        private DataGridView dgvTabela;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvTabela = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lucasComboBox1 = new NourPizzaria.Controles.LucasComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabela).BeginInit();
            SuspendLayout();
            // 
            // dgvTabela
            // 
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.AllowUserToDeleteRows = false;
            dgvTabela.AllowUserToOrderColumns = true;
            dgvTabela.AllowUserToResizeRows = false;
            dgvTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabela.BackgroundColor = Color.Gray;
            dgvTabela.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTabela.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(247, 220, 111);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTabela.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTabela.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTabela.EnableHeadersVisualStyles = false;
            dgvTabela.Font = new Font("Segoe UI", 10F);
            dgvTabela.GridColor = Color.FromArgb(102, 102, 102);
            dgvTabela.Location = new Point(20, 60);
            dgvTabela.Name = "dgvTabela";
            dgvTabela.RowHeadersVisible = false;
            dgvTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabela.Size = new Size(1087, 400);
            dgvTabela.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(62, 142, 65);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 122, 55);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 162, 75);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(255, 255, 255);
            btnAdd.Location = new Point(20, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 45);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(247, 220, 111);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(235, 200, 100);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 230, 150);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(51, 51, 51);
            btnEdit.Location = new Point(190, 480);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 45);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 55, 55);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(215, 35, 35);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 85, 85);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(255, 255, 255);
            btnDelete.Location = new Point(360, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 45);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            lucasComboBox1.Items.AddRange(new object[] { "Clientes", "Itens" });
            lucasComboBox1.ListBackColor = Color.Gray;
            lucasComboBox1.ListTextColor = Color.White;
            lucasComboBox1.Location = new Point(20, 15);
            lucasComboBox1.MinimumSize = new Size(200, 30);
            lucasComboBox1.Name = "lucasComboBox1";
            lucasComboBox1.Padding = new Padding(2);
            lucasComboBox1.Size = new Size(200, 30);
            lucasComboBox1.TabIndex = 6;
            lucasComboBox1.Texts = "";
            lucasComboBox1.OnSelectedIndexChanged += lucasComboBox1_OnSelectedIndexChanged;
            // 
            // FrmConfiguracoesPizzaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(dgvTabela);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lucasComboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguracoesPizzaria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações da Pizzaria";
            Load += FrmConfiguracoesPizzaria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabela).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.LucasComboBox lucasComboBox1;
    }
}
