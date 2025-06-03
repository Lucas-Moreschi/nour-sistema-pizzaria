namespace NourPizzaria.Controls
{
    partial class LucasListItemEditavel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNItem = new Label();
            pnlObs = new Panel();
            lblTxtObs = new Label();
            lblObs = new Label();
            lblNomeItem = new Label();
            pctLixo = new PictureBox();
            pctEditar = new PictureBox();
            pnlObs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLixo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctEditar).BeginInit();
            SuspendLayout();
            // 
            // lblNItem
            // 
            lblNItem.AutoSize = true;
            lblNItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNItem.ForeColor = Color.White;
            lblNItem.Location = new Point(5, 9);
            lblNItem.Name = "lblNItem";
            lblNItem.Size = new Size(63, 21);
            lblNItem.TabIndex = 0;
            lblNItem.Text = "Item N°";
            // 
            // pnlObs
            // 
            pnlObs.BackColor = Color.FromArgb(235, 235, 235);
            pnlObs.Controls.Add(lblTxtObs);
            pnlObs.Controls.Add(lblObs);
            pnlObs.Dock = DockStyle.Bottom;
            pnlObs.Location = new Point(2, 48);
            pnlObs.Name = "pnlObs";
            pnlObs.Size = new Size(595, 65);
            pnlObs.TabIndex = 1;
            pnlObs.Paint += panel1_Paint;
            // 
            // lblTxtObs
            // 
            lblTxtObs.AutoSize = true;
            lblTxtObs.ForeColor = Color.Black;
            lblTxtObs.Location = new Point(3, 20);
            lblTxtObs.Name = "lblTxtObs";
            lblTxtObs.Size = new Size(33, 15);
            lblTxtObs.TabIndex = 1;
            lblTxtObs.Text = "texto";
            lblTxtObs.TextChanged += lblTxtObs_TextChanged;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.ForeColor = Color.Black;
            lblObs.Location = new Point(3, 3);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(77, 15);
            lblObs.TabIndex = 0;
            lblObs.Text = "Observações:";
            // 
            // lblNomeItem
            // 
            lblNomeItem.AutoSize = true;
            lblNomeItem.Font = new Font("Segoe UI", 12F);
            lblNomeItem.ForeColor = Color.White;
            lblNomeItem.Location = new Point(253, 9);
            lblNomeItem.Name = "lblNomeItem";
            lblNomeItem.Size = new Size(110, 21);
            lblNomeItem.TabIndex = 2;
            lblNomeItem.Text = "Nome do item";
            // 
            // pctLixo
            // 
            pctLixo.Image = Properties.Resources.lixoBranco;
            pctLixo.Location = new Point(564, 9);
            pctLixo.Margin = new Padding(3, 2, 3, 2);
            pctLixo.Name = "pctLixo";
            pctLixo.Size = new Size(30, 26);
            pctLixo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLixo.TabIndex = 6;
            pctLixo.TabStop = false;
            pctLixo.Click += pctLixo_Click;
            pctLixo.MouseEnter += pctLixo_MouseEnter;
            pctLixo.MouseLeave += pctLixo_MouseLeave;
            // 
            // pctEditar
            // 
            pctEditar.Image = Properties.Resources.pencil_white;
            pctEditar.Location = new Point(528, 9);
            pctEditar.Margin = new Padding(3, 2, 3, 2);
            pctEditar.Name = "pctEditar";
            pctEditar.Size = new Size(30, 26);
            pctEditar.SizeMode = PictureBoxSizeMode.Zoom;
            pctEditar.TabIndex = 7;
            pctEditar.TabStop = false;
            pctEditar.Click += pctEditar_Click;
            pctEditar.MouseEnter += pctEditar_MouseEnter;
            pctEditar.MouseLeave += pctEditar_MouseLeave;
            // 
            // LucasListItemEditavel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(pctEditar);
            Controls.Add(pctLixo);
            Controls.Add(lblNomeItem);
            Controls.Add(pnlObs);
            Controls.Add(lblNItem);
            Name = "LucasListItemEditavel";
            Padding = new Padding(2);
            Size = new Size(599, 115);
            Load += LucasListItem_Load;
            pnlObs.ResumeLayout(false);
            pnlObs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctLixo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNItem;
        private Panel pnlObs;
        private Label lblTxtObs;
        private Label lblObs;
        private Label lblNomeItem;
        private PictureBox pctLixo;
        private PictureBox pctEditar;
    }
}
