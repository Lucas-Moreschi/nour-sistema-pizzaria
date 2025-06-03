using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourPizzaria.Classes
{
    public class Relatorios
    {
        ClasseConexao conexao = new ClasseConexao();
        public DataTable VendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            CAST(data_pedido AS DATE) AS [Data],
            COUNT(id) AS [Quantidade de Pedidos],
            SUM(valor_total) AS [Total Vendido (R$)]
        FROM Pedidos
        WHERE data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY CAST(data_pedido AS DATE)
        ORDER BY [Data]";
            return conexao.executarSQL(sql);
        }

        public DataTable VendasPorCategoria(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            i.categoria AS [Categoria],
            SUM(pi.quantidade) AS [Quantidade Vendida],
            SUM(pi.quantidade * pi.preco_unitario) AS [Total Vendido (R$)]
        FROM Pedido_Itens pi
        INNER JOIN Pedidos p ON p.id = pi.pedido_id
        INNER JOIN Itens i ON i.id = pi.item_id
        WHERE p.data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY i.categoria
        ORDER BY [Total Vendido (R$)] DESC";
            return conexao.executarSQL(sql);
        }

        public DataTable ItensMaisVendidos(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT TOP 10
            i.nome AS [Item],
            SUM(pi.quantidade) AS [Quantidade Vendida],
            SUM(pi.quantidade * pi.preco_unitario) AS [Total (R$)]
        FROM Pedido_Itens pi
        INNER JOIN Pedidos p ON p.id = pi.pedido_id
        INNER JOIN Itens i ON i.id = pi.item_id
        WHERE p.data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY i.nome
        ORDER BY [Quantidade Vendida] DESC";
            return conexao.executarSQL(sql);
        }

        public DataTable ItensMenosVendidos(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            i.nome AS [Item],
            SUM(ISNULL(pi.quantidade, 0)) AS [Quantidade Vendida],
            SUM(ISNULL(pi.quantidade * pi.preco_unitario, 0)) AS [Total (R$)]
        FROM Itens i
        LEFT JOIN Pedido_Itens pi ON pi.item_id = i.id
        LEFT JOIN Pedidos p ON p.id = pi.pedido_id AND p.data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY i.nome
        ORDER BY [Quantidade Vendida] ASC";
            return conexao.executarSQL(sql);
        }

        public DataTable ClientesQueMaisCompram(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            c.nome AS [Cliente],
            COUNT(p.id) AS [Quantidade de Pedidos],
            SUM(p.valor_total) AS [Total Gasto (R$)]
        FROM Pedidos p
        INNER JOIN Clientes c ON c.id = p.cliente_id
        WHERE p.data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY c.nome
        ORDER BY [Total Gasto (R$)] DESC";
            return conexao.executarSQL(sql);
        }

        public DataTable FrequenciaDePedidosPorCliente(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            c.nome AS [Cliente],
            COUNT(p.id) AS [Quantidade de Pedidos]
        FROM Pedidos p
        INNER JOIN Clientes c ON c.id = p.cliente_id
        WHERE p.data_pedido BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY c.nome
        ORDER BY [Quantidade de Pedidos] DESC";
            return conexao.executarSQL(sql);
        }

        public DataTable ClientesInativos(int diasSemCompra)
        {
            string sql = $@"
        SELECT 
            c.nome AS [Cliente],
            c.telefone AS [Telefone],
            MAX(p.data_pedido) AS [Ultima Compra]
        FROM Clientes c
        LEFT JOIN Pedidos p ON p.cliente_id = c.id
        GROUP BY c.nome, c.telefone
        HAVING ISNULL(MAX(p.data_pedido), '1900-01-01') <= DATEADD(DAY, -{diasSemCompra}, GETDATE())
        ORDER BY [Ultima Compra]";
            return conexao.executarSQL(sql);
        }

        public DataTable OrcamentosPorStatus(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        SELECT 
            status AS [Status],
            COUNT(id) AS [Quantidade],
            SUM(valor_total) AS [Total (R$)]
        FROM Orcamentos
        WHERE data_criacao BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        GROUP BY status";
            return conexao.executarSQL(sql);
        }

        public DataTable TaxaDeConversaoDeOrcamentos(DateTime inicio, DateTime fim)
        {
            string sql = $@"
        WITH TotalOrcamentos AS (
            SELECT COUNT(*) AS total 
            FROM Orcamentos 
            WHERE data_criacao BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        ),
        OrcamentosAprovados AS (
            SELECT COUNT(*) AS aprovados 
            FROM Orcamentos 
            WHERE status = 'Aprovado' AND data_criacao BETWEEN '{inicio:yyyy-MM-dd}' AND '{fim:yyyy-MM-dd}'
        )
        SELECT 
            (SELECT total FROM TotalOrcamentos) AS [Total Orcamentos],
            (SELECT aprovados FROM OrcamentosAprovados) AS [Aprovados],
            CAST((SELECT aprovados FROM OrcamentosAprovados) AS FLOAT) / 
            (SELECT total FROM TotalOrcamentos) * 100 AS [Taxa de Conversão (%)];";
            return conexao.executarSQL(sql);
        }


    }
}
