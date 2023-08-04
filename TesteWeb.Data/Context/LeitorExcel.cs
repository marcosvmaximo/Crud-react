using TesteWeb.Domain.Entities;
using TesteWeb.Domain.Enum;
using ClosedXML.Excel;
using TesteWeb.Domain;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TesteWeb.Data.Context;

public static class LeitorExcel
{
    public static void DeletarPagamento(Guid pagamentoId)
    {
        string caminhoDoArquivo = "dados.xlsx";

        List<Pagamento> listaDeDados = new List<Pagamento>();

        using (var workbook = new XLWorkbook(caminhoDoArquivo))
        {
            var worksheet = workbook.Worksheet(1);

            for (int linha = 2; linha <= worksheet.RowsUsed().Count(); linha++)
            {
                var id = Guid.Parse(worksheet.Cell(linha, 1).GetValue<string>());

                if (id == pagamentoId)
                {
                    var row = worksheet.Row(linha);
                    row.Delete();
                    break;
                }
            }

            workbook.Save();
        }
    }

    public static IEnumerable<Pagamento> Pagamentos()
    {
        string caminhoDoArquivo = "dados.xlsx";

        List<Pagamento> listaDeDados = new List<Pagamento>();

        using (var workbook = new XLWorkbook(caminhoDoArquivo))
        {
            var worksheet = workbook.Worksheet(1);

            for (int linha = 2; linha <= worksheet.RowsUsed().Count(); linha++)
            {
                Pagamento dados = new Pagamento(
                    (ETipoPagamento)worksheet.Cell(linha, 2).GetValue<int>(),
                    worksheet.Cell(linha, 3).GetValue<DateTime>(),
                    worksheet.Cell(linha, 4).GetValue<decimal>(),
                    Guid.Parse(worksheet.Cell(linha, 5).GetValue<string>()))
                { Id = Guid.Parse(worksheet.Cell(linha, 1).GetValue<string>()) };

                listaDeDados.Add(dados);
            }
        }

        return listaDeDados;
    }

    public static IEnumerable<Pagamento> Pagamentos(Guid usuarioId)
    {
        string caminhoDoArquivo = "dados.xlsx";

        List<Pagamento> listaDeDados = new List<Pagamento>();

        using (var workbook = new XLWorkbook(caminhoDoArquivo))
        {
            var worksheet = workbook.Worksheet(1);

            for (int linha = 2; linha <= worksheet.RowsUsed().Count(); linha++)
            {
                Pagamento dados = new Pagamento(
                    (ETipoPagamento)worksheet.Cell(linha, 2).GetValue<int>(),
                    worksheet.Cell(linha, 3).GetValue<DateTime>(),
                    worksheet.Cell(linha, 4).GetValue<decimal>(),
                    Guid.Parse(worksheet.Cell(linha, 5).GetValue<string>()))
                { Id = Guid.Parse(worksheet.Cell(linha, 1).GetValue<string>()) };

                listaDeDados.Add(dados);
            }
        }

        var result = listaDeDados.Where(x => x.UsuarioId == usuarioId);

        return result;
    }

    public static IEnumerable<Usuario> Usuarios()
    {
        string caminhoDoArquivo = "dados.xlsx";

        List<Usuario> listaDeDados = new List<Usuario>();

        using (var workbook = new XLWorkbook(caminhoDoArquivo))
        {
            var worksheet = workbook.Worksheet(2);

            for (int linha = 2; linha <= worksheet.RowsUsed().Count(); linha++)
            {
                Usuario dados = new Usuario(worksheet.Cell(linha, 2).GetValue<string>())
                {
                    Id = Guid.Parse(worksheet.Cell(linha, 1).GetValue<string>())
                };

                listaDeDados.Add(dados);
            }
        }

        return listaDeDados;
    }

    public static Usuario Usuarios(Guid usuarioId)
    {
        string caminhoDoArquivo = "dados.xlsx";

        List<Usuario> listaDeDados = new List<Usuario>();

        using (var workbook = new XLWorkbook(caminhoDoArquivo))
        {
            var worksheet = workbook.Worksheet(2);

            for (int linha = 2; linha <= worksheet.RowsUsed().Count(); linha++)
            {
                Usuario dados = new Usuario(worksheet.Cell(linha, 2).GetValue<string>())
                {
                    Id = Guid.Parse(worksheet.Cell(linha, 1).GetValue<string>())
                };

                listaDeDados.Add(dados);
            }
        }

        var result = listaDeDados.FirstOrDefault(x => x.Id == usuarioId);

        return result;
    }
}