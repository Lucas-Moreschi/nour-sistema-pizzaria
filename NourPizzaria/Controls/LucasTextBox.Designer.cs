namespace NourPizzaria.Controles
{
    partial class LucasTextBox
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 15);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // LucasTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(textBox1);
            Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DimGray;
            Margin = new Padding(4);
            Name = "LucasTextBox";
            Padding = new Padding(7);
            Size = new Size(250, 30);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
