using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v4legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World v4!");

            using (ExcelPackage index = new ExcelPackage(File.OpenRead("../../../index_error.xlsx")))
            {
                var worksheet = index.Workbook.Worksheets[1];

                Console.WriteLine($"Index OK => {worksheet.Name}");
            }

            Console.ReadKey();
        }
    }
}
