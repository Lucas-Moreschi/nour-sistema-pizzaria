using NourPizzaria.Classes;
using NourPizzaria.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria
{
    public partial class MainForm : Form
    {
        private Form activeForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public MainForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            CompartilhaForm.mainForm = this;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Inicio Eventos formulário principal
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0)); // Sem cantos arredondados
            }
            else
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); // Com cantos arredondados
            }
        }
        // Fim Eventos formulário principal


        // Inicio Panel Title 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // Fim Panel Title

        // Inicio abertura de formulários
        public void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            CentralizarTitulo();
            btnCloseChildForm.Visible = true;
        }

        // Não descarta o formulário para retornar a ele depois
        public void ShowChildFormWithoutClosing(Form childForm)
        {
            if (childForm == null) return;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            CentralizarTitulo();
            btnCloseChildForm.Visible = true;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            Reset();
        }

        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void Reset()
        {
            lblTitle.Text = "Nour";
            CentralizarTitulo();
            btnCloseChildForm.Visible = false;
        }

        private void CentralizarTitulo()
        {
            lblTitle.Left = (panelTitleBar.Width - lblTitle.Width) / 2;
            lblTitle.Top = (panelTitleBar.Height - lblTitle.Height) / 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Fim abertura de formulários

        // Inicio métodos botões
        private void btnsPrincipais_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string botao = btn.Name;
            MostrarSubPanels(botao);
            AbrirFormulario(botao);
        }

        private void btnsSecundarios_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string botao = btn.Name;
            AbrirFormulario(botao);
        }

        private void MostrarSubPanels(string botao)
        {
            switch (botao)
            {
                case "btnOrcamentos":
                    pnlSubConfiguracoes.Visible = false;
                    pnlSubOrcamentos.Visible = !pnlSubOrcamentos.Visible;
                    break;
                case "btnConfiguracoes":
                    pnlSubOrcamentos.Visible = false;
                    pnlSubConfiguracoes.Visible = !pnlSubConfiguracoes.Visible;
                    break;


                default:
                    pnlSubConfiguracoes.Visible = false;
                    pnlSubOrcamentos.Visible = false;
                    break;
            }
        }

        private void AbrirFormulario(string botao)
        {
            Form form;

            switch (botao)
            {
                case "btnNovoOrcamento":
                    form = new FrmNovoOrcamento();
                    break;
                case "btnConsultarOrcamentos":
                    form = new FrmConsultarOrcamentos();
                    break;
                case "btnPedidos":
                    form = new FrmPedidos();
                    break;
                case "btnCadastroClientes":
                    form = new FrmCadastroClientes();
                    break;
                case "btnRelatorios":
                    form = new FrmRelatorios();
                    break;
                case "btnAdicionarItens":
                    form = new FrmAdicionarItens();
                    break;
                case "btnConfiguracoesPizzaria":
                    form = new FrmConfiguracoesPizzaria();
                    break;
                default:
                    return;
            }
            OpenChildForm(form);
        }
    }
}
