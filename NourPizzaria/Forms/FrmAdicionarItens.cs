using NourPizzaria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria.Forms
{
    public partial class FrmAdicionarItens : Form
    {
        int idItem = -1;
        public FrmAdicionarItens()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Texts = "";
            txtPreco.Texts = "";
            txtDescricao.Texts = "";
            cmbCategoria.SelectedIndex = -1;
            txtNome.Focus();
        }

        private void FrmAdicionarItens_Load(object sender, EventArgs e)
        {
            MostrarItens();
            PreencherComboBox();
        }

        private void MostrarItens()
        {
            ClasseConexao conexao = new ClasseConexao();
            dgvItens.DataSource = conexao.executarSQL("Select * from itens");
        }

        private void PreencherComboBox()
        {
            ClasseConexao conexao = new ClasseConexao();
            DataTable dt = conexao.executarSQL("Select distinct categoria from itens order by categoria desc");
            foreach (DataRow row in dt.Rows)
            {
                cmbCategoria.Items.Add(row["categoria"].ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Salvar")
                SalvarItem();
            else if (btnSalvar.Text == "Atualizar item")
                EditarItem();
        }

        private void SalvarItem()
        {
            if (txtNome.Texts == "" || txtPreco.Texts == "" || txtDescricao.Texts == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            ClasseConexao conexao = new ClasseConexao();
            string comando_sql = $"INSERT INTO itens (nome, preco, descricao, categoria) VALUES ('{txtNome.Texts}', '{txtPreco.Texts.Replace(',','.')}', '{txtDescricao.Texts}', '{cmbCategoria.SelectedItem}')";
            bool sucesso = conexao.manutencaoDB(comando_sql);
            MessageBox.Show("Item adicionado com sucesso!");
            MostrarItens();
            LimparCampos();
        }

        private void EditarItem()
        {
            if (txtNome.Texts == "" || txtPreco.Texts == "" || txtDescricao.Texts == "" || cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            ClasseConexao conexao = new ClasseConexao();
            string comando_sql = $"UPDATE itens SET nome = '{txtNome.Texts}', preco = '{txtPreco.Texts.Replace(',', '.')}', descricao = '{txtDescricao.Texts}', categoria = '{cmbCategoria.SelectedItem}' WHERE id = {idItem}";
            conexao.executarSQL(comando_sql);
            MessageBox.Show("Item atualizado com sucesso!");
            MostrarItens();
            LimparCampos();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (btnEditarItem.Text == "Editar Item Selecionado")
            {
                if (dgvItens.CurrentRow == null)
                {
                    MessageBox.Show("Selecione um item para editar.");
                    return;
                }
                idItem = Convert.ToInt32(dgvItens.CurrentRow.Cells[0].Value);
                btnEditarItem.Text = "Adicionar item";
                btnSalvar.Text = "Atualizar item";
                PreencherCamposEditar();
            }
            else if (btnEditarItem.Text == "Adicionar item")
            {
                btnEditarItem.Text = "Editar Item Selecionado";
                btnSalvar.Text = "Salvar";
                LimparCampos();
            }
        }

        private void PreencherCamposEditar()
        {
            txtNome.Texts = dgvItens.CurrentRow.Cells[1].Value + "";
            txtDescricao.Texts = dgvItens.CurrentRow.Cells[2].Value + "";
            txtPreco.Texts = dgvItens.CurrentRow.Cells[3].Value + "";
            cmbCategoria.SelectedItem = dgvItens.CurrentRow.Cells[4].Value + "";
        }
    }
}
