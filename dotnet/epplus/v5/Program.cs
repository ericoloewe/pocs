﻿using OfficeOpenXml;
using System;
using System.IO;

namespace v5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World v5!");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using ExcelPackage github = new ExcelPackage(File.OpenRead("../../../../github_example.xlsx"));

            Console.WriteLine($"C29: {github.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            Console.WriteLine($"S6123: {github.Workbook.Worksheets["Details"].Cells["S6123"].Value}");

            using ExcelPackage getnet = new ExcelPackage(File.OpenRead("../../../../getnet_errors.xlsx"));

            Console.WriteLine($"B1: {getnet.Workbook.Worksheets["Plan1"].Cells["B1"].Value}");
            Console.WriteLine($"B2: {getnet.Workbook.Worksheets["Plan1"].Cells["B2"].Value}");

            Console.WriteLine($"E1: {getnet.Workbook.Worksheets["Plan1"].Cells["E1"].Value}");
            Console.WriteLine($"E2: {getnet.Workbook.Worksheets["Plan1"].Cells["E2"].Value}");

            Console.WriteLine($"H1: {getnet.Workbook.Worksheets["Plan1"].Cells["H1"].Value}");
            Console.WriteLine($"H2: {getnet.Workbook.Worksheets["Plan1"].Cells["H2"].Value}");

            Console.ReadKey();
        }
    }
}
