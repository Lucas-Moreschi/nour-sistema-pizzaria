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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NourPizzaria.Forms
{
    public partial class FrmPedidos : Form
    {
        char ocultos = 'N';
        public FrmPedidos()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            string sqlBase = @"SELECT 
        p.id, 
        p.valor_total, 
        p.status,
        c.nome AS cliente_nome,
        p.data_pedido,
        i.nome AS nome_item,
        pi.observacao,
        pi.quantidade
        FROM Pedidos p
        LEFT JOIN Pedido_Itens pi ON p.id = pi.pedido_id
        LEFT JOIN Itens i ON pi.item_id = i.id
        LEFT JOIN Clientes c ON p.cliente_id = c.id ";
            string sql = ocultos == 'S' ? sqlBase + "order by id desc" : sqlBase + @"WHERE p.status != 'Entregue' AND p.status != 'Cancelado' order by id desc";
            ClasseConexao con = new ClasseConexao();
            DataTable dt = con.executarSQL(sql);

            var gruposPedidos = dt.AsEnumerable()
                .GroupBy(row => new
                {
                    Id = row.Field<int>("id"),
                    Valor = row.Field<decimal>("valor_total"),
                    Status = row.Field<string>("status"),
                    ClienteNome = row.Field<string>("cliente_nome"),
                    DataPedido = row.Field<DateTime>("data_pedido")
                });

            flowPedidos.Controls.Clear();

            foreach (var grupo in gruposPedidos)
            {
                StringBuilder obsBuilder = new StringBuilder();
                foreach (var row in grupo)
                {
                    string nomeItem = row["nome_item"]?.ToString() ?? "Item desconhecido";
                    int quantidade = row.Field<int>("quantidade");
                    string observacao = row["observacao"]?.ToString();

                    string palavraQtd = quantidade == 1 ? "unidade" : "unidades";
                    obsBuilder.Append($"{quantidade} {palavraQtd} de {nomeItem}");

                    if (!string.IsNullOrWhiteSpace(observacao))
                    {
                        obsBuilder.Append($": {observacao}");
                    }

                    obsBuilder.AppendLine();
                }

                LucasLItemPedido item = new LucasLItemPedido
                {
                    IdPedido = grupo.Key.Id,
                    NumeroPedido = $"Pedido #{grupo.Key.Id}",
                    ValorTotal = grupo.Key.Valor.ToString("C2", new CultureInfo("pt-BR")),
                    Observacao = obsBuilder.ToString().TrimEnd(),
                    Cliente = grupo.Key.ClienteNome,
                    DataPedido = grupo.Key.DataPedido.ToString("dd/MM/yyyy")
                };

                item.DefinirStatus(PegarStatus(grupo.Key.Status));

                item.EditarClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemPedido;
                    FrmEditarOrcPed form = new FrmEditarOrcPed('P', clicado.IdPedido);
                    CompartilhaForm.mainForm.OpenChildForm(form);
                };

                item.ExcluirClicado += (s, e) =>
                {
                    var clicado = s as LucasLItemPedido;
                    AlterarStatusPedido(clicado.IdPedido, "Cancelado");
                };

                item.StatusTxtChanged += (s, e) =>
                {
                    var clicado = s as LucasLItemPedido;
                    AlterarStatusPedido(clicado.IdPedido, clicado.EstadoDoPedido + "");
                };

                flowPedidos.Controls.Add(item);
            }
        }

        private EstadoPedido PegarStatus(string status)
        {
            switch (status)
            {
                case "Em preparo":
                    return EstadoPedido.EmPreparo;
                case "Pronto":
                    return EstadoPedido.Pronto;
                case "Entregue":
                    return EstadoPedido.Entregue;
                case "Cancelado":
                    return EstadoPedido.Cancelado;
                default:
                    return EstadoPedido.EmPreparo;
            }
        }


        private void AlterarStatusPedido(int idPedido, string novoStatus)
        {
            // status: 'Em preparo', 'Pronto', 'Entregue', 'Cancelado'
            if (novoStatus != "EmPreparo" && novoStatus != "Pronto" && novoStatus != "Entregue" && novoStatus != "Cancelado")
            {
                MessageBox.Show("Status inválido.");
                return;
            }
            novoStatus = novoStatus.Replace("EmPreparo", "Em preparo")
                                    .Replace("Pronto", "Pronto")
                                    .Replace("Entregue", "Entregue")
                                    .Replace("Cancelado", "Cancelado");
            ClasseConexao con = new ClasseConexao();
            string comando = $"UPDATE Pedidos SET status = '{novoStatus}' WHERE id = {idPedido}";
            bool pedidoAtualizado = con.manutencaoDB(comando);
            if (pedidoAtualizado == true)
            {
                MessageBox.Show("Pedido atualizado com sucesso.");
            }
            else
                MessageBox.Show("Erro ao atualizar o orçamento.");

            CarregarPedidos();
        }

        private void rdoMostrar_CheckedChanged(object sender, EventArgs e)
        {
            ocultos = rdoMostrar.Checked ? 'S' : 'N';
            CarregarPedidos();
        }
    }
}
