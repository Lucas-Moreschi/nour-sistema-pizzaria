namespace NourPizzaria.Forms
{
    partial class FrmConsultarOrcamentos
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
            flowOrcamentos = new FlowLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            rdoNaoMostrar = new RadioButton();
            rdoMostrar = new RadioButton();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowOrcamentos
            // 
            flowOrcamentos.AutoScroll = true;
            flowOrcamentos.BackColor = SystemColors.ActiveBorder;
            flowOrcamentos.Dock = DockStyle.Left;
            flowOrcamentos.FlowDirection = FlowDirection.TopDown;
            flowOrcamentos.Location = new Point(0, 0);
            flowOrcamentos.Name = "flowOrcamentos";
            flowOrcamentos.Padding = new Padding(10);
            flowOrcamentos.Size = new Size(661, 599);
            flowOrcamentos.TabIndex = 3;
            flowOrcamentos.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(661, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 119);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoNaoMostrar);
            groupBox1.Controls.Add(rdoMostrar);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(117, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 78);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exibir itens ocultos";
            // 
            // rdoNaoMostrar
            // 
            rdoNaoMostrar.AutoSize = true;
            rdoNaoMostrar.Checked = true;
            rdoNaoMostrar.Location = new Point(6, 47);
            rdoNaoMostrar.Name = "rdoNaoMostrar";
            rdoNaoMostrar.Size = new Size(91, 19);
            rdoNaoMostrar.TabIndex = 1;
            rdoNaoMostrar.TabStop = true;
            rdoNaoMostrar.Text = "Não mostrar";
            rdoNaoMostrar.UseVisualStyleBackColor = true;
            // 
            // rdoMostrar
            // 
            rdoMostrar.AutoSize = true;
            rdoMostrar.Location = new Point(6, 22);
            rdoMostrar.Name = "rdoMostrar";
            rdoMostrar.Size = new Size(66, 19);
            rdoMostrar.TabIndex = 0;
            rdoMostrar.Text = "Mostrar";
            rdoMostrar.UseVisualStyleBackColor = true;
            rdoMostrar.CheckedChanged += rdoMostrar_CheckedChanged;
            // 
            // FrmConsultarOrcamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1127, 599);
            Controls.Add(panel1);
            Controls.Add(flowOrcamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarOrcamentos";
            Text = "Consultar Orçamentos";
            Load += FrmConsultarOrcamentos_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowOrcamentos;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton rdoNaoMostrar;
        private RadioButton rdoMostrar;
    }
}