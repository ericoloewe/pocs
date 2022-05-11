using OfficeOpenXml;
using System;
using System.IO;

namespace v6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World v6!");

            using ExcelPackage excel = new ExcelPackage(File.OpenRead("../../../../github_example.xlsx"));

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            Console.WriteLine($"C29: {excel.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            Console.WriteLine($"S6123: {excel.Workbook.Worksheets["Details"].Cells["S6123"].Value}");

            Console.ReadKey();
        }
    }
}
