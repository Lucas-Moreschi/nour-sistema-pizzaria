using NourPizzaria.Classes;
using NourPizzaria.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria.Forms
{
    public partial class FrmEditarOrcPed : Form
    {
        ClasseConexao con;
        DataTable dt;
        List<Item> itens;
        List<Item> itensAtualizados;
        char pedOrc;
        int idPedOrc;
        List<string> categorias;
        Button btnAdicionar;
        int numeroItemSelecionado = -1;

        public FrmEditarOrcPed()
        {
            InitializeComponent();
        }

        public FrmEditarOrcPed(char pedOrc, int idPedOrc)
        {
            InitializeComponent();
            this.pedOrc = pedOrc;
            this.idPedOrc = idPedOrc;
            this.Text = pedOrc == 'P' ? $"Editar Pedido {idPedOrc}" : $"Editar Orçamento {idPedOrc}";
            PreencherComboBoxProdutos();
            SelecionarClientePorId(BuscarIdDoCliente(idPedOrc));
            CarregarItens();
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
            dt = con.executarSQL("Select * from Clientes where ativo != 0 order by nome");

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

        private void CarregarItens()
        {
            itens = new List<Item>();
            string comando = pedOrc == 'P' ? $"Select * from pedido_itens where pedido_id = {idPedOrc}" : $"Select * from orcamento_itens where orcamento_id = {idPedOrc}";
            con = new ClasseConexao();
            dt = con.executarSQL(comando);
            foreach (DataRow row in dt.Rows)
            {
                con = new ClasseConexao();
                DataTable dt2 = con.executarSQL($"Select * from Itens where id = {row["item_id"]}");

                Item item = new Item(Convert.ToInt32(row["id"]), Convert.ToInt32(dt2.Rows[0]["id"]), dt2.Rows[0]["nome"] + "", row["observacao"] + "", Convert.ToInt32(row["Quantidade"]), Convert.ToInt32(row["preco_unitario"]));
                itens.Add(item);
            }
            AtualizarExibicaoDosItens();
        }

        private void AtualizarExibicaoDosItens()
        {
            flowItens.Controls.Clear();
            int numeroItem = 1;
            foreach (Item item in itens)
            {
                LucasListItemEditavel controle = new LucasListItemEditavel();
                item.NumeroItem = numeroItem++;
                controle.NumeroItem += " " + item.NumeroItem;
                string palavraQtde = item.Quantidade == 1 ? "unidade" : "unidades";
                controle.NomeItem = item.NomeItem + " - " + item.Quantidade + " " + palavraQtde;
                controle.Observacoes = item.Observacoes;

                controle.ExcluirClicado += (s, e) =>
                {
                    DialogResult dialog = MessageBox.Show("Você deseja excluir esse item?", "Pizzaria Delicia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        RemoverItem(item);
                    }
                };

                controle.EditarClicado += (s, e) =>
                {
                    ItemEditar_Click(item);
                };

                flowItens.Controls.Add(controle);
            }
            btnAdicionar = new Button()
            {
                BackColor = Color.FromArgb(62, 142, 65),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(3, 124),
                Name = "btnAdicionar",
                Size = new Size(599, 57),
                TabIndex = 10,
                Text = "Adicionar",
                UseVisualStyleBackColor = false,
            };
            btnAdicionar.Click += (s, e) =>
            {
                btnAdicionar_Click();
            };

            flowItens.Controls.Add(btnAdicionar);
            CentralizarItensFlow(flowItens);
        }

        private void CentralizarItensFlow(FlowLayoutPanel flow)
        {
            bool temScrollVertical = flow.VerticalScroll.Visible;

            foreach (Control ctrl in flow.Controls)
            {
                if (temScrollVertical)
                {
                    ctrl.Margin = new Padding(3, ctrl.Margin.Top, 0, ctrl.Margin.Bottom);
                }
                else
                {
                    int margemEsquerda = (flow.ClientSize.Width - ctrl.Width) / 2;
                    margemEsquerda = margemEsquerda < 0 ? 0 : margemEsquerda;

                    ctrl.Margin = new Padding(margemEsquerda, ctrl.Margin.Top, 0, ctrl.Margin.Bottom);
                }
            }
        }


        private void btnAdicionar_Click()
        {
            cmbItem.SelectedItem = -1;
            numQuantidade.Value = 1;
            txtObservacoes.Texts = "";
            grpItens.Text = "Adicionar item";
            btnSalvarItem.Text = "Adicionar item";
            grpItens.Visible = true;
            btnAdicionar.Visible = false;
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
            if (categorias.Contains(cmbItem.SelectedItem))
            {
                cmbItem.SelectedIndex = cmbItem.SelectedIndex + 1;
            }
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            MainForm mainForm = CompartilhaForm.mainForm;
            CompartilhaForm.frmEditarOrcamento = this;
            mainForm.ShowChildFormWithoutClosing(new FrmCadastroClientes('E'));
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

        public int BuscarIdDoCliente(int idPedido)
        {
            con = new ClasseConexao();
            dt = con.executarSQL($"Select cliente_id from {(pedOrc == 'P' ? "Pedidos" : "Orcamentos")} where id = {idPedido}");
            return Convert.ToInt32(dt.Rows[0]["cliente_id"]);
        }

        private void RemoverItem(Item item)
        {
            if (itensAtualizados == null)
                itensAtualizados = new List<Item>();
            item.Quantidade = 0;
            itens.Remove(item);
            itensAtualizados.Add(item);
            OrganizarNumeroDosItens();
            AtualizarExibicaoDosItens();
            LimparCampos();
        }

        private void ItemEditar_Click(Item item)
        {
            cmbItem.SelectedItem = item.NomeItem;
            numQuantidade.Value = item.Quantidade;
            txtObservacoes.Texts = item.Observacoes;
            numeroItemSelecionado = item.NumeroItem;
            btnSalvarItem.Text = "Atualizar item";
            grpItens.Text = $"Editando item N° {item.NumeroItem}";
            grpItens.Visible = true;
            btnAdicionar.Visible = true;
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (numQuantidade.Value <= 0)
            {
                MessageBox.Show("Selecione uma quantidade maior que 0", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (btnAdicionar.Visible) // Se estiver visivel, estamos alterando um item
            {
                AlterarItem();

            }
            else // Se não estiver visivel, estamos adicionando um item
            {
                AdicionarItem();
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            grpItens.Text = "";
            cmbItem.SelectedItem = -1;
            numQuantidade.Value = 1;
            txtObservacoes.Texts = "";
            grpItens.Visible = false;
            btnAdicionar.Visible = true;
            btnSalvarItem.Text = "Adicionar item";
            grpItens.Text = "Adicionar item";
        }

        private void AlterarItem()
        {
            Item itemOriginal = itens[numeroItemSelecionado - 1];
            Item item = new Item
            {
                IdOP_Itens = itemOriginal.IdOP_Itens,
                NumeroItem = itemOriginal.NumeroItem,
                NomeItem = cmbItem.SelectedItem + "",
                Quantidade = Convert.ToInt32(numQuantidade.Value),
                Observacoes = txtObservacoes.Texts,
            };
            item = buscarValoresDoNovoItem(item);
            if (item.Equals(itemOriginal))
            {
                return;
            }
            else if (itensAtualizados == null)
                itensAtualizados = new List<Item>();
            itensAtualizados.Add(item);
            itens[numeroItemSelecionado - 1] = item;
            AtualizarExibicaoDosItens();
        }

        private void AdicionarItem()
        {
            Item item = new Item
            {
                IdOP_Itens = -1,
                NomeItem = cmbItem.SelectedItem + "",
                Quantidade = Convert.ToInt32(numQuantidade.Value),
                Observacoes = txtObservacoes.Texts,
            };
            item = buscarValoresDoNovoItem(item);
            if (itensAtualizados == null)
                itensAtualizados = new List<Item>();
            itensAtualizados.Add(item);
            itens.Add(item);
            AtualizarExibicaoDosItens();
        }

        private Item buscarValoresDoNovoItem(Item item)
        {
            con = new ClasseConexao();
            dt = con.executarSQL($"Select * from Itens where nome = '{item.NomeItem}'");
            item.IdItem = Convert.ToInt32(dt.Rows[0]["id"]);
            item.ValorUnitario = Convert.ToInt32(dt.Rows[0]["preco"]);
            return item;
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {

            if (SalvarItens() || AtualizarCliente())
            {
                if (pedOrc == 'P')
                    CompartilhaForm.mainForm.OpenChildForm(new FrmPedidos());
                else
                    CompartilhaForm.mainForm.OpenChildForm(new FrmConsultarOrcamentos());
            }
            else
            {
                MessageBox.Show("Erro ao salvar as alterações", "Pizzaria Delicia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SalvarItens()
        {
            if (itensAtualizados == null || itensAtualizados.Count == 0)
                return false;

            string tabela = pedOrc == 'P' ? "pedido_itens" : "orcamento_itens";
            string tabelaPai = pedOrc == 'P' ? "Pedidos" : "Orcamentos";
            int idPai = idPedOrc;

            decimal valorTotal = 0;

            foreach (Item item in itensAtualizados)
            {
                string sql = "";

                if (item.Quantidade == 0)
                {
                    sql = $"DELETE FROM {tabela} WHERE id = {item.IdOP_Itens}";
                }
                else if (item.IdOP_Itens == -1) // novo item
                {
                    string colunaPai = pedOrc == 'P' ? "pedido_id" : "orcamento_id";
                    sql = $"INSERT INTO {tabela} (item_id, quantidade, preco_unitario, observacao, {colunaPai}) " +
                          $"VALUES ({item.IdItem}, {item.Quantidade}, {item.ValorUnitario}, " +
                          $"'{item.Observacoes?.Replace("'", "''")}', {idPai})";
                }
                else // atualização
                {
                    sql = $"UPDATE {tabela} SET item_id = {item.IdItem}, quantidade = {item.Quantidade}, " +
                          $"preco_unitario = {item.ValorUnitario}, " +
                          $"observacao = '{item.Observacoes?.Replace("'", "''")}' WHERE id = {item.IdOP_Itens}";
                }

                new ClasseConexao().manutencaoDB(sql);

                if (item.Quantidade > 0)
                {
                    valorTotal += item.Quantidade * item.ValorUnitario;
                }
            }

            string sqlValor = $"UPDATE {tabelaPai} SET valor_total = {valorTotal} WHERE id = {idPai}";
            new ClasseConexao().manutencaoDB(sqlValor);
            return true;
        }

        private bool AtualizarCliente()
        {
            if (cmbClientes.SelectedItem is Cliente clienteSelecionado)
            {
                string tabelaPai = pedOrc == 'P' ? "Pedidos" : "Orcamentos";
                string sql = $"UPDATE {tabelaPai} SET cliente_id = {clienteSelecionado.Id} WHERE id = {idPedOrc}";
                return new ClasseConexao().manutencaoDB(sql);
            }
            return false;
        }
    }
}
