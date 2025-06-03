using NourPizzaria.Classes;
using NourPizzaria.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NourPizzaria.Forms
{
    public partial class FrmConsultarOrcamentos : Form
    {
        MainForm mainForm;
        char ocultos = 'N';
        public FrmConsultarOrcamentos()
        {
            mainForm = CompartilhaForm.mainForm;
            InitializeComponent();
        }

        private void FrmConsultarOrcamentos_Load(object sender, EventArgs e)
        {
            CarregarOrcamentos();
        }

        private void CarregarOrcamentos()
        {
            string sqlBase = @"
        SELECT 
        o.id, 
        o.valor_total, 
        o.status,
        o.data_criacao data_orcamento,
        c.nome cliente_nome,
        i.nome AS nome_item,
        oi.observacao,
        oi.quantidade
        FROM Orcamentos o
        LEFT JOIN Orcamento_Itens oi ON o.id = oi.orcamento_id
        LEFT JOIN Itens i ON oi.item_id = i.id
        LEFT JOIN Clientes c ON o.cliente_id = c.id ";
            string sql = ocultos == 'S' ? sqlBase + "order by id desc" : sqlBase + @"WHERE o.status != 'Rejeitado' and o.status != 'Aprovado' order by id desc";
            ClasseConexao con = new ClasseConexao();
            DataTable dt = con.executarSQL(sql);

            var gruposOrcamentos = dt.AsEnumerable()
                .GroupBy(row => new
                {
                    Id = row.Field<int>("id"),
                    Valor = row.Field<decimal>("valor_total"),
                    Status = row.Field<string>("status"),
                    ClienteNome = row.Field<string>("cliente_nome"),
                    DataPedido = row.Field<DateTime>("data_orcamento")
                });

            flowOrcamentos.Controls.Clear();

            foreach (var grupo in gruposOrcamentos)
            {
                StringBuilder obsBuilder = new StringBuilder();
                foreach (var row in grupo)
                {
                    int quantidade = row.Field<int?>("quantidade") ?? 0;
                    if (quantidade > 0)
                    {
                        string nomeItem = row["nome_item"]?.ToString() ?? "Item desconhecido";
                        string observacao = row["observacao"]?.ToString();

                        string palavraQtd = quantidade == 1 ? "unidade" : "unidades";
                        obsBuilder.Append($"{quantidade} {palavraQtd} de {nomeItem}");

                        if (!string.IsNullOrWhiteSpace(observacao))
                        {
                            obsBuilder.Append($": {observacao}");
                        }

                        obsBuilder.AppendLine();
                    }

                }

                LucasLItemOrcamento item = new LucasLItemOrcamento
                {
                    IdOrcamento = grupo.Key.Id,
                    NumeroOrcamento = $"Orçamento #{grupo.Key.Id}",
                    ValorTotal = grupo.Key.Valor.ToString("C2", new CultureInfo("pt-BR")),
                    Observacao = obsBuilder.ToString().TrimEnd(),
                    Cliente = grupo.Key.ClienteNome,
                    DataPedido = grupo.Key.DataPedido.ToString("dd/MM/yyyy")
                };

                item.DefinirStatus(grupo.Key.Status);
                item.Aprovado_NaoAprovado = grupo.Key.Status == "Aprovado"
                    ? LucasLItemOrcamento.EstadoOrcamento.Aprovado
                    : LucasLItemOrcamento.EstadoOrcamento.NaoAprovado;

                item.EditarClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemOrcamento;
                    FrmEditarOrcPed form = new FrmEditarOrcPed('O', clicado.IdOrcamento);
                    mainForm.OpenChildForm(form);
                };

                item.ExcluirClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemOrcamento;
                    AlterarStatusOrcamento(clicado.IdOrcamento, "Rejeitado");
                };

                item.AprovadoClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemOrcamento;
                    DialogResult dialog = MessageBox.Show("Você deseja aprovar o orçamento?", "Pizzaria Delicia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {

                        AlterarStatusOrcamento(clicado.IdOrcamento, "Aprovado");
                    }
                };

                flowOrcamentos.Controls.Add(item);
            }
        }

        private void AlterarStatusOrcamento(int idOrcamento, string novoStatus)
        {
            if (novoStatus != "Aprovado" && novoStatus != "Rejeitado")
            {
                MessageBox.Show("Status inválido.");
                return;
            }
            ClasseConexao con = new ClasseConexao();
            string comando = $"UPDATE Orcamentos SET status = '{novoStatus}' WHERE id = {idOrcamento}";
            bool orcamentoAtualizado = con.manutencaoDB(comando);
            if (orcamentoAtualizado == true)
            {
                if (novoStatus == "Aprovado")
                {
                    GerarPedido(idOrcamento);
                }
                else
                {
                    MessageBox.Show("Orçamento reprovado com sucesso!");
                }
            }
            else
                MessageBox.Show("Erro ao atualizar o orçamento.");

            CarregarOrcamentos();
        }

        private void GerarPedido(int idOrcamento)
        {
            ClasseConexao con = new ClasseConexao();
            DateTime dataAtual = DateTime.Now;
            DataTable dt = con.executarSQL($"SELECT cliente_id, valor_total FROM Orcamentos WHERE id = {idOrcamento}");
            string comando = $"INSERT INTO Pedidos (status, data_pedido, cliente_id, valor_total) VALUES ('Em preparo', '{dataAtual}', {dt.Rows[0]["cliente_id"]}, {dt.Rows[0]["valor_total"]})";
            con = new ClasseConexao();
            bool pedidoGerado = con.manutencaoDB(comando);
            if (pedidoGerado == true)
            {
                con = new ClasseConexao();
                dt = con.executarSQL($"SELECT id FROM Pedidos WHERE cliente_id = {dt.Rows[0]["cliente_id"]} AND data_pedido = '{dataAtual}'");
                int idPedido = Convert.ToInt32(dt.Rows[0]["id"]);
                con = new ClasseConexao();
                dt = con.executarSQL($"SELECT * FROM Orcamento_Itens WHERE orcamento_id = {idOrcamento}");
                foreach (DataRow row in dt.Rows)
                {
                    string comandoItem = $"INSERT INTO Pedido_Itens (pedido_id, item_id, quantidade, preco_unitario, observacao) VALUES ({idPedido}, {row["item_id"]}, {row["quantidade"]}, {row["preco_unitario"]},'{row["observacao"]}')";
                    con = new ClasseConexao();
                    con.manutencaoDB(comandoItem);
                }
                MessageBox.Show("Pedido gerado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao gerar o pedido.");

            }
        }

        private void rdoMostrar_CheckedChanged(object sender, EventArgs e)
        {
            ocultos = rdoMostrar.Checked ? 'S' : 'N';
            CarregarOrcamentos();
        }
    }
}
