// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using (var p = new ExcelPackage(@"C:\Temp\oracle-test\SOLICITACOES_CLIENTE_DATA_TABLE.xlsx"))
{
  //Get the Worksheet created in the previous codesample. 
  var ws = p.Workbook.Worksheets["pricing"];


}