using NourPizzaria.Classes;
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

namespace NourPizzaria.Forms
{
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        private string tabela;
        private int id;
        ClasseConexao conexao;

        public FrmEditar(string tabela, int id)
        {
            InitializeComponent();
            this.tabela = tabela;
            this.id = id;
            lblTitulo.Text = $"Editar {tabela}";
            CentralizarTitulo();
        }

        private void CentralizarTitulo()
        {
            lblTitulo.Left = (panel1.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = (panel1.Height - lblTitulo.Height) / 2;
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            if (tabela == "Clientes")
            {
                txtNome.Visible = true;
                txtTelefone.Visible = true;
                txtEmail.Visible = true;
                txtEndereco.Visible = true;

                txtDescricao.Visible = false;
                txtPreco.Visible = false;
                cmbCategoria.Visible = false;

                CarregarDadosCliente();
            }
            else if (tabela == "Itens")
            {
                txtNome.Visible = true;
                txtDescricao.Visible = true;
                txtPreco.Visible = true;
                cmbCategoria.Visible = true;

                txtTelefone.Visible = false;
                txtEmail.Visible = false;
                txtEndereco.Visible = false;

                CarregarDadosItem();
            }
        }



        private void CarregarDadosCliente()
        {
            string sql = $"SELECT * FROM Clientes WHERE id = {id}";
            conexao = new ClasseConexao();
            DataTable dt = conexao.executarSQL(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow linha = dt.Rows[0];
                txtNome.Texts = linha["nome"].ToString();
                txtTelefone.Texts = linha["telefone"].ToString();
                txtEmail.Texts = linha["email"].ToString();
                txtEndereco.Texts = linha["endereco"].ToString();
            }
        }

        private void CarregarDadosItem()
        {
            string sql = $"SELECT * FROM Itens WHERE id = {id}";
            conexao = new ClasseConexao();
            DataTable dt = conexao.executarSQL(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow linha = dt.Rows[0];
                txtNome.Texts = linha["nome"].ToString();
                txtDescricao.Texts = linha["descricao"].ToString();
                txtPreco.Texts = linha["preco"].ToString();
                cmbCategoria.Texts = linha["categoria"].ToString();
            }

            sql = "SELECT distinct categoria FROM Itens";
            conexao = new ClasseConexao();
            dt = conexao.executarSQL(sql);
            if (dt.Rows.Count > 0)
            {
                cmbCategoria.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbCategoria.Items.Add(row["categoria"].ToString());
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tabela == "Clientes")
                AtualizarCliente();
            else if (tabela == "Itens")
                AtualizarItem();
        }

        private void AtualizarCliente()
        {
            conexao = new ClasseConexao();
            string sql = $"UPDATE Clientes SET " +
                         $"nome = '{txtNome.Texts}', " +
                         $"telefone = '{txtTelefone.Texts}', " +
                         $"email = '{txtEmail.Texts}', " +
                         $"endereco = '{txtEndereco.Texts}' " +
                         $"WHERE id = {id}";

            bool sucesso = conexao.manutencaoDB(sql);

            if (sucesso)
            {
                MessageBox.Show("Cliente atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o cliente.");
            }
        }

        private void AtualizarItem()
        {
            conexao = new ClasseConexao();
            string sql = $"UPDATE Itens SET " +
                         $"nome = '{txtNome.Texts}', " +
                         $"descricao = '{txtDescricao.Texts}', " +
                         $"preco = {Convert.ToDecimal(txtPreco.Texts).ToString().Replace(",", ".")}, " +
                         $"categoria = '{cmbCategoria.Texts}' " +
                         $"WHERE id = {id}";

            bool sucesso = conexao.manutencaoDB(sql);

            if (sucesso)
            {
                MessageBox.Show("Item atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o item.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
