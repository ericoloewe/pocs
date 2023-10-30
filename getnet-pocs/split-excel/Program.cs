// See https://aka.ms/new-console-template for more information
using OfficeOpenXml;

Console.WriteLine("Hello, World!");

var nomeArquivo = "SOLICITACOES_CLIENTE_DATA_TABLE";
var quantidadeArquivos = 4;

var stream = File.OpenRead(@$"C:\Temp\oracle-test\{nomeArquivo}.xlsx");

using (var p = new ExcelPackage(stream))
{
    //Get the Worksheet created in the previous codesample. 
    Console.WriteLine($"lendo arquivo");
    var ws = p.Workbook.Worksheets["pricing"];

    //var header = ws.Rows[0];

    Console.WriteLine($"lendo dimensão");
    var linhasPorArquivo = ws.Dimension.End.Row / quantidadeArquivos;

    for (var i = 0; i < quantidadeArquivos; i++)
    {
        Console.WriteLine($"Iniciando arquivo {i}");

        using (var fileSplit = new ExcelPackage())
        {
            fileSplit.Workbook.Worksheets.Add("pricing");

            var newWs = fileSplit.Workbook.Worksheets["pricing"];
            var nextContentStart = i * linhasPorArquivo;
            var nextContentEnd = i * linhasPorArquivo + linhasPorArquivo;

            for (var j = nextContentStart; j < nextContentEnd; j++)
            {
                var row = nextContentStart - j + 1;

                for (var k = 0; k < ws.Dimension.End.Column; k++)
                {
                    newWs.Cells[j, k].Value = ws.Cells[row, k].Value;
                }
            }

            fileSplit.SaveAs(new FileInfo(@$"C:\Temp\oracle-test\{nomeArquivo}_{i}.xlsx"));
        }
    }
}