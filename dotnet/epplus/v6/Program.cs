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

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage index = new ExcelPackage(File.OpenRead("../../../../index_error.xlsx"));

            var worksheet = index.Workbook.Worksheets[0];

            Console.WriteLine($"Index OK => {worksheet.Name}");

            using ExcelPackage github = new ExcelPackage(File.OpenRead("../../../../github_example.xlsx"));

            Console.WriteLine($"GITHUB");

            github.Workbook.Calculate();

            Console.WriteLine($"C29: {github.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            Console.WriteLine($"C29: {github.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            Console.WriteLine($"S6123: {github.Workbook.Worksheets["Details"].Cells["S6123"].Value}");

            using ExcelPackage getnet = new ExcelPackage(File.OpenRead("../../../../getnet_errors.xlsx"));

            Console.WriteLine($"GETNET");

            getnet.Workbook.Calculate();

            Console.WriteLine($"B1: {getnet.Workbook.Worksheets["Plan1"].Cells["B1"].Value}");
            Console.WriteLine($"B2: {getnet.Workbook.Worksheets["Plan1"].Cells["B2"].Value}");

            Console.WriteLine($"E1: {getnet.Workbook.Worksheets["Plan1"].Cells["E1"].Value}");
            Console.WriteLine($"E2: {getnet.Workbook.Worksheets["Plan1"].Cells["E2"].Value}");

            Console.WriteLine($"H1: {getnet.Workbook.Worksheets["Plan1"].Cells["H1"].Value}");
            Console.WriteLine($"H2: {getnet.Workbook.Worksheets["Plan1"].Cells["H2"].Value}");

            Console.WriteLine($"K1: {getnet.Workbook.Worksheets["Plan1"].Cells["K1"].Value}");
            Console.WriteLine($"K2: {getnet.Workbook.Worksheets["Plan1"].Cells["K2"].Value}");
            Console.WriteLine($"K3: {getnet.Workbook.Worksheets["Plan1"].Cells["K3"].Value}");
            Console.WriteLine($"K4: {getnet.Workbook.Worksheets["Plan1"].Cells["K4"].Value}");

            using ExcelPackage motor = new ExcelPackage(File.OpenRead("../../../../motor.xlsm"));

            Console.WriteLine($"MOTOR");

            motor.Workbook.Calculate();

            Console.WriteLine($"B13: {motor.Workbook.Worksheets["Output"].Cells["B13"].Value}");
            Console.WriteLine($"B14: {motor.Workbook.Worksheets["Output"].Cells["B14"].Value}");
            Console.WriteLine($"B15: {motor.Workbook.Worksheets["Output"].Cells["B15"].Value}");

            Console.ReadKey();
        }
    }
}
