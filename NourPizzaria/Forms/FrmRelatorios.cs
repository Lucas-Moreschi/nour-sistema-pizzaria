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
    public partial class FrmRelatorios : Form
    {
        DateTime dataFim;
        DateTime dataInicio;
        public FrmRelatorios()
        {
            InitializeComponent();
            dataFim = DateTime.Now;
            dataInicio = dataFim.AddDays(-30);
            ConfigurarDatePickers();
        }

        private void ConfigurarDatePickers()
        {
            dtInicio.Value = dataInicio;
            dtLimite.Value = dataFim;
            dtInicio.MaxDate = DateTime.Now.AddDays(-1);
            dtLimite.MaxDate = DateTime.Now;
            dtLimite.MinDate = new DateTime(2025, 1, 1);
            dtInicio.MinDate = new DateTime(2025, 1, 1);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            Relatorios rel = new Relatorios();
            int diasInativos = 90;
            string opcao = lucasComboBox1.SelectedItem + "";

            DateTime dataInicio = this.dataInicio.AddDays(-1);
            DateTime dataFim = this.dataFim.AddDays(1);

            switch (opcao)
            {
                case "Vendas por Período":
                    resultado = rel.VendasPorPeriodo(dataInicio, dataFim);
                    break;

                case "Vendas por Categoria de Item":
                    resultado = rel.VendasPorCategoria(dataInicio, dataFim);
                    break;

                case "Ranking de Itens Mais Vendidos":
                    resultado = rel.ItensMaisVendidos(dataInicio, dataFim);
                    break;

                case "Itens Menos Vendidos":
                    resultado = rel.ItensMenosVendidos(dataInicio, dataFim);
                    break;

                case "Clientes que Mais Compram":
                    resultado = rel.ClientesQueMaisCompram(dataInicio, dataFim);
                    break;

                case "Frequência de Pedidos por Cliente":
                    resultado = rel.FrequenciaDePedidosPorCliente(dataInicio, dataFim);
                    break;

                case "Clientes Inativos":
                    resultado = rel.ClientesInativos(diasInativos);
                    break;

                case "Orçamentos por Status":
                    resultado = rel.OrcamentosPorStatus(dataInicio, dataFim);
                    break;

                case "Taxa de Conversão de Orçamentos":
                    resultado = rel.TaxaDeConversaoDeOrcamentos(dataInicio, dataFim);
                    break;

                default:
                    MessageBox.Show("Selecione um relatório válido.");
                    return;
            }

            dgvResultados.DataSource = resultado;
            btnPDF.Visible = true;
            btnExcel.Visible = true;

        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = dtInicio.Value;
        }

        private void dtLimite_ValueChanged(object sender, EventArgs e)
        {
            dataFim = dtLimite.Value;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Relatorio_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Salvar Relatório como PDF";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Relatorio_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Salvar Relatório como Excel";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        { 
            if (saveFileDialog.FileName.EndsWith(".pdf"))
            {
                ExportadorRelatorios.ExportarParaPDF(dgvResultados, saveFileDialog.FileName);
            }
            else if (saveFileDialog.FileName.EndsWith(".xlsx"))
            {
                ExportadorRelatorios.ExportarParaExcel(dgvResultados, saveFileDialog.FileName);
            }
        }
    }
}
