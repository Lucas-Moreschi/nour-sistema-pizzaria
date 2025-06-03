using NourPizzaria.Classes;
using NourPizzaria.Controls;
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
    public partial class FrmNovoOrcamento : Form
    {
        ClasseConexao con;
        DataTable dt;
        List<string> categorias;
        List<Item> itens;

        public FrmNovoOrcamento()
        {
            InitializeComponent();
        }

        private void FrmNovoOrcamento_Load(object sender, EventArgs e)
        {
            PreencherComboBoxProdutos();
            PreencherComboBoxClientes();
            itens = new List<Item>();
        }

        private void PreencherComboBoxProdutos()
        {
            cmbItem.Items.Clear();
            categorias = new List<string>();
            con = new ClasseConexao();
            dt = con.executarSQL("Select * from Itens where ativo != 0 order by Categoria desc");
            string categoriaAtual = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string categoria = dt.Rows[i]["categoria"] + "";
                if (categoriaAtual != categoria)
                {
                    categoriaAtual = categoria;
                    categoria = "---------------- " + categoria + " ----------------";
                    categorias.Add(categoria);
                    cmbItem.Items.Add(categoria);
                }
                cmbItem.Items.Add(dt.Rows[i]["nome"] + "");
            }
        }

        private void PreencherComboBoxClientes()
        {
            con = new ClasseConexao();
            dt = con.executarSQL("Select * from Clientes where ativo != 0 order by nome ");

            cmbClientes.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Cliente cliente = new Cliente()
                {
                    Id = Convert.ToInt32(dt.Rows[i]["id"]),
                    Nome = dt.Rows[i]["nome"].ToString(),
                    Telefone = dt.Rows[i]["telefone"].ToString()
                };
                cmbClientes.Items.Add(cliente);
            }
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {

            string nomeItem = cmbItem.SelectedItem + "";
            if (string.IsNullOrEmpty(nomeItem))
            {
                MessageBox.Show("Selecione um item", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string observacoes = txtObservacoes.Texts;
            int numeroItem = itens.Count + 1;
            int quantidade = Convert.ToInt32(numQuantidade.Value);


            Item item = new Item(numeroItem, nomeItem, observacoes, quantidade);
            itens.Add(item);
            AtualizarExibicaoDosItens();
            LimparCampos();
        }

        private void AtualizarExibicaoDosItens()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Item item in itens)
            {
                LucasListItem controle = new LucasListItem();

                controle.NumeroItem += " " + item.NumeroItem;
                string palavraQtde = item.Quantidade == 1 ? "unidade" : "unidades";
                controle.NomeItem = item.NomeItem + " - " + item.Quantidade + " " + palavraQtde;
                controle.Observacoes = item.Observacoes;

                controle.ExcluirClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemOrcamento;
                    DialogResult dialog = MessageBox.Show("Você deseja excluir esse item?", "Pizzaria Delicia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        itens.Remove(item);
                        OrganizarNumeroDosItens();
                        AtualizarExibicaoDosItens();
                    }
                };

                flowLayoutPanel1.Controls.Add(controle);
            }
        }

        private void OrganizarNumeroDosItens()
        {
            if (itens.Count <= 0)
                return;
            List<Item> tempList = itens;
            itens = new List<Item>();
            for (int i = 0; i < tempList.Count; i++)
            {
                Item item = tempList[i];
                item.NumeroItem = i + 1;
                itens.Add(item);
            }
        }

        private void cmbItem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> itens = new Dictionary<string, string>();
            if (categorias.Contains(cmbItem.SelectedItem))
            {
                cmbItem.SelectedIndex = cmbItem.SelectedIndex + 1;
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void LimparTudo()
        {
            categorias = new List<string>();
            itens = new List<Item>();
            cmbClientes.SelectedIndex = -1;
            cmbClientes.Texts = "Selecione o cliente";
            flowLayoutPanel1.Controls.Clear();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtObservacoes.Texts = "";
            cmbItem.SelectedIndex = -1;
            cmbItem.Texts = "Selecione o item";
            numQuantidade.Value = 1;
        }

        private void btnGerarOrcamento_Click(object sender, EventArgs e)
        {
            string cliente = cmbClientes.SelectedItem + "";
            if (string.IsNullOrEmpty(cliente))
            {
                MessageBox.Show("Selecione um cliente", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] nomeTelefone = cliente.Split(" - ");
            string nome = nomeTelefone[0];
            string telefone = nomeTelefone[1];

            con = new ClasseConexao();
            dt = con.executarSQL($"Select id from clientes where nome like '{nome}' and telefone like '{telefone}'");
            GerarOrcamento(Convert.ToInt32(dt.Rows[0]["id"]));
            CompartilhaForm.mainForm.OpenChildForm(new FrmConsultarOrcamentos());
        }

        private void GerarOrcamento(int clienteId)
        {
            con = new ClasseConexao();
            DateTime data = DateTime.Now;
            bool geracaoDoOrcamento = con.manutencaoDB($"INSERT INTO Orcamentos (cliente_id, data_criacao) VALUES ({clienteId},'{data}')");
            con = new ClasseConexao();
            dt = con.executarSQL($"Select id from Orcamentos where data_criacao = '{data}' and cliente_id = {clienteId}");
            InserirItensAoOrcamento(Convert.ToInt32(dt.Rows[0]["id"]));
        }

        private void InserirItensAoOrcamento(int idOrcamento)
        {
            double valorTotal = 0;
            foreach (Item item in itens)
            {
                con = new ClasseConexao();
                dt = con.executarSQL($"Select id, preco from Itens where nome like '{item.NomeItem}'");
                int idItem = Convert.ToInt32(dt.Rows[0]["id"]);
                double valorUnitario = Convert.ToDouble(dt.Rows[0]["preco"]);
                valorTotal += (valorUnitario * item.Quantidade);

                con = new ClasseConexao();
                bool insercaoItem = con.manutencaoDB($"INSERT INTO Orcamento_Itens (orcamento_id, item_id, quantidade, preco_unitario, observacao) VALUES ({idOrcamento}, {idItem}, {item.Quantidade}, {valorUnitario}, '{item.Observacoes}')");
                LimparTudo();
            }
            con = new ClasseConexao();
            bool AdicionarValorTotal = con.manutencaoDB($"Update Orcamentos set valor_total = {valorTotal} where id = {idOrcamento}");
        }
        public void SelecionarClientePorId(int id)
        {
            PreencherComboBoxClientes();
            foreach (var item in cmbClientes.Items)
            {
                Cliente cliente = item as Cliente;
                if (cliente != null && cliente.Id == id)
                {
                    cmbClientes.SelectedItem = cliente;
                    break;
                }
            }
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            MainForm mainForm = CompartilhaForm.mainForm;
            CompartilhaForm.frmNovoOrcamento = this;
            mainForm.ShowChildFormWithoutClosing(new FrmCadastroClientes('N'));
        }
    }
}
