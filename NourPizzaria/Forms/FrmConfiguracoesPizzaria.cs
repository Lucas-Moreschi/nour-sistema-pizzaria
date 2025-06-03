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
    public partial class FrmConfiguracoesPizzaria : Form
    {
        public FrmConfiguracoesPizzaria()
        {
            InitializeComponent();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfiguracoesPizzaria_Load(object sender, EventArgs e)
        {
            ClasseConexao con = new ClasseConexao();
            dgvTabela.DataSource = con.executarSQL("select * from itens");
            lucasComboBox1.SelectedItem = "Itens";
        }

        private void lucasComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarDgv();
        }

        private void AtualizarDgv()
        {
            ClasseConexao con = new ClasseConexao();
            dgvTabela.DataSource = con.executarSQL($"select * from {lucasComboBox1.Texts} where ativo != 0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lucasComboBox1.Texts == "Clientes")
            {
                CompartilhaForm.mainForm.OpenChildForm(new FrmCadastroClientes());
            }
            else if (lucasComboBox1.Texts == "Itens")
            {
                CompartilhaForm.mainForm.OpenChildForm(new FrmAdicionarItens());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClasseConexao con = new ClasseConexao();
            string sql = $"update {lucasComboBox1.Texts} set ativo = 0 where id = {Convert.ToInt32(dgvTabela.CurrentRow.Cells[0].Value)}";
            bool sucesso = con.manutencaoDB(sql);
            if (sucesso)
            {
                MessageBox.Show("Item excluído com sucesso!");
                AtualizarDgv();
            }
            else
            {
                MessageBox.Show("Erro ao excluir o item.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar = new FrmEditar(lucasComboBox1.Texts, Convert.ToInt32(dgvTabela.CurrentRow.Cells[0].Value));
            frmEditar.ShowDialog();
            if (frmEditar.DialogResult == DialogResult.OK)
            {
                AtualizarDgv();
            }
        }
    }
}
