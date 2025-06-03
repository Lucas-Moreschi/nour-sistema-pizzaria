using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace NourPizzaria.Classes
{
    public class ExportadorRelatorios
    {

        public static void ExportarParaPDF(DataGridView dgv, string caminho, string titulo = "Relatório")
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                doc.Open();

                Paragraph paragrafo = new Paragraph(titulo, new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD));
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.SpacingAfter = 20f;
                doc.Add(paragrafo);

                PdfPTable table = new PdfPTable(dgv.Columns.Count)
                {
                    WidthPercentage = 100
                };
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
        }

        public static void ExportarParaExcel(DataGridView dgv, string caminho, string nomePlanilha = "Relatorio")
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var dataTable = new DataTable(nomePlanilha);

                    foreach (DataGridViewColumn coluna in dgv.Columns)
                    {
                        dataTable.Columns.Add(coluna.HeaderText);
                    }

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;

                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            dataRow[i] = row.Cells[i].Value?.ToString() ?? "";
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    var worksheet = workbook.Worksheets.Add(dataTable);

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(caminho);

                    MessageBox.Show("Excel gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Excel: " + ex.Message);
            }
        }
    }
}
