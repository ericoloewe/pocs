using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace interop
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World interop!");

            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            //using ExcelPackage index = new ExcelPackage(File.OpenRead("../../../../index_error.xlsx"));

            //var worksheet = index.Workbook.Worksheets[0];

            //Console.WriteLine($"Index OK => {worksheet.Name}");

            //using ExcelPackage github = new ExcelPackage(File.OpenRead("../../../../github_example.xlsx"));

            //Console.WriteLine($"GITHUB");

            //github.Workbook.Calculate();

            //Console.WriteLine($"C29: {github.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            //Console.WriteLine($"C29: {github.Workbook.Worksheets["Summary"].Cells["C29"].Value}");
            //Console.WriteLine($"S6123: {github.Workbook.Worksheets["Details"].Cells["S6123"].Value}");

            //using ExcelPackage getnet = new ExcelPackage(File.OpenRead("../../../../getnet_errors.xlsx"));

            //Console.WriteLine($"GETNET");

            //getnet.Workbook.Calculate();

            //Console.WriteLine($"B1: {getnet.Workbook.Worksheets["Plan1"].Cells["B1"].Value}");
            //Console.WriteLine($"B2: {getnet.Workbook.Worksheets["Plan1"].Cells["B2"].Value}");

            //Console.WriteLine($"E1: {getnet.Workbook.Worksheets["Plan1"].Cells["E1"].Value}");
            //Console.WriteLine($"E2: {getnet.Workbook.Worksheets["Plan1"].Cells["E2"].Value}");

            //Console.WriteLine($"H1: {getnet.Workbook.Worksheets["Plan1"].Cells["H1"].Value}");
            //Console.WriteLine($"H2: {getnet.Workbook.Worksheets["Plan1"].Cells["H2"].Value}");

            //Console.WriteLine($"K1: {getnet.Workbook.Worksheets["Plan1"].Cells["K1"].Value}");
            //Console.WriteLine($"K2: {getnet.Workbook.Worksheets["Plan1"].Cells["K2"].Value}");
            //Console.WriteLine($"K3: {getnet.Workbook.Worksheets["Plan1"].Cells["K3"].Value}");
            //Console.WriteLine($"K4: {getnet.Workbook.Worksheets["Plan1"].Cells["K4"].Value}");

            //using ExcelPackage motor = new ExcelPackage(File.OpenRead("../../../../motor.xlsm"));

            Console.WriteLine($"start ALL motor");

            Run($"RUN:SERIAL:{1}", "motor.xlsm").Wait();
            Run($"RUN:SERIAL:{2}", "motor.xlsm").Wait();

            var tasks = new List<Task>();

            tasks.Add(Run($"RUN:PARALLEL:{1}", "motor.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{2}", "motor-2.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{3}", "motor-3.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{4}", "motor-4.xlsm"));

            Task.WhenAll(tasks.ToArray()).Wait();

            var tasksSameFile = new List<Task>();

            var vXlApp = new Excel.Application();
            var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", "motor.xlsm"));
            var vXlWorkBook = vXlApp.Workbooks.Open(path);

            tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{1}", "motor.xlsm", vXlWorkBook));
            tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{2}", "motor.xlsm", vXlWorkBook));
            tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{3}", "motor.xlsm", vXlWorkBook));
            tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{4}", "motor.xlsm", vXlWorkBook));

            Task.WhenAll(tasksSameFile.ToArray()).Wait();

            vXlWorkBook.Close(false);
            Console.WriteLine($"end excel close");

            Console.WriteLine($"end ALL motor");
            Console.ReadKey();

            System.Threading.Thread.Sleep(1000);
        }

        private static async Task Run(string code, string fileName, Excel.Workbook vXlWorkBook = null)
        {
            await Task.Delay(random.Next(100, 500));
            var stopWatch = new Stopwatch();
            var needToClose = false;

            stopWatch.Start();

            Console.WriteLine($"{code} start excel");

            if (vXlWorkBook == null)
            {
                var vXlApp = new Excel.Application();
                var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", fileName));
                vXlWorkBook = vXlApp.Workbooks.Open(path);
                needToClose = true;
            Console.WriteLine($"{code} end excel load in {stopWatch.ElapsedMilliseconds}ms");
            }

            await Task.Delay(random.Next(100, 500));

            //motor.Workbook.Calculate();

            Excel.Worksheet ws = vXlWorkBook.Worksheets["Output"];

            Console.WriteLine($"{code} B13: {ws.Cells[13, "B"].Value}");
            Console.WriteLine($"{code} B14: {ws.Cells[14, "B"].Value}");
            Console.WriteLine($"{code} B15: {ws.Cells[15, "B"].Value}");

            Console.WriteLine($"{code} end excel print in {stopWatch.ElapsedMilliseconds}ms");

            Console.WriteLine($"{code} setting new values");

            Excel.Worksheet wsInput = vXlWorkBook.Worksheets["Input"];

            wsInput.Cells[12, "B"].Value = 10000;

            //ws.Calculate();

            Console.WriteLine($"{code} B13: {ws.Cells[13, "B"].Value}");
            Console.WriteLine($"{code} B14: {ws.Cells[14, "B"].Value}");
            Console.WriteLine($"{code} B15: {ws.Cells[15, "B"].Value}");

            Console.WriteLine($"{code} end excel new print in {stopWatch.ElapsedMilliseconds}ms");

            if (needToClose)
            {
                vXlWorkBook.Close(false);
                Console.WriteLine($"{code} end excel close in {stopWatch.ElapsedMilliseconds}ms");
            }
        }
    }
}
