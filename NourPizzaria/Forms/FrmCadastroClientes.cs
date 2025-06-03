using NourPizzaria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria.Forms
{
    public partial class FrmCadastroClientes : Form
    {
        ClasseConexao con;
        char formulario;
        public FrmCadastroClientes()
        {
            InitializeComponent();
        }

        public FrmCadastroClientes(char formulario)
        {
            this.formulario = formulario;
            InitializeComponent();
        }




        private void btnListar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dgvClientes.DataSource = con.executarSQL("Select * from clientes");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Texts;
            string nome = txtNome.Texts;
            string telefone = txtTelefone.Texts;
            string endereco = txtEndereco.Texts;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Preecha todos os campos", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idCliente = -1;

            if (InserirCliente(nome, telefone, email, endereco))
            {
                MessageBox.Show("Cliente inserido com sucesso!", "Pizzaria Delícia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idCliente = PegarIdCliente(telefone);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o cliente.", "Pizzaria Delícia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (formulario != null)
            {
                MainForm mainForm = CompartilhaForm.mainForm;

                if (formulario == 'N')
                {
                    FrmNovoOrcamento form = CompartilhaForm.frmNovoOrcamento;
                    form.SelecionarClientePorId(idCliente);
                    CompartilhaForm.mainForm.ShowChildFormWithoutClosing(form);
                }
                else if (formulario == 'E')
                {
                    FrmEditarOrcPed form = CompartilhaForm.frmEditarOrcamento;
                    form.SelecionarClientePorId(idCliente);
                    CompartilhaForm.mainForm.ShowChildFormWithoutClosing(form);
                }
            }
        }

        public bool InserirCliente(string nome, string telefone, string email, string endereco)
        {
            try
            {
                string sql = "INSERT INTO Clientes (nome, telefone, email, endereco) VALUES (@nome, @telefone, @email, @endereco)";

                SqlCommand comando = new SqlCommand(sql);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@endereco", endereco);

                con = new ClasseConexao();
                int resultado = con.manutencaoDB_Parametros(comando);

                if (resultado > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private int PegarIdCliente(string telefone)
        {
            try
            {
                string sql = $"SELECT id FROM Clientes WHERE telefone = '{telefone}'";
                con = new ClasseConexao();
                DataTable dt = con.executarSQL(sql);
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["id"]);
                else
                    return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtEmail.Texts = " ";
            txtEndereco.Texts = "";
            txtNome.Texts = "";
            txtTelefone.Texts = "";

        }
    }
}
