using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

            Console.WriteLine($"start ALL motor");

            Run($"RUN:SERIAL:{1}", "motor.xlsm").Wait();
            Run($"RUN:SERIAL:{2}", "motor.xlsm").Wait();

            var tasks = new List<Task>();

            tasks.Add(Run($"RUN:PARALLEL:{1}", "motor.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{2}", "motor-2.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{3}", "motor-3.xlsm"));
            tasks.Add(Run($"RUN:PARALLEL:{4}", "motor-4.xlsm"));

            Task.WhenAll(tasks.ToArray()).Wait();

            //RunAllSameFile();

            Console.WriteLine($"end ALL motor");
            Console.ReadKey();

            System.Threading.Thread.Sleep(1000);
        }

        private static void RunAllSameFile()
        {
            var tasksSameFile = new List<Task>();

            var vXlApp = new Excel.Application();
            var path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\", "motor.xlsm"));
            var vXlWorkBook = vXlApp.Workbooks.Open(path);

            try
            {
                tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{1}", "motor.xlsm", vXlWorkBook));
                tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{2}", "motor.xlsm", vXlWorkBook));
                tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{3}", "motor.xlsm", vXlWorkBook));
                tasksSameFile.Add(Run($"RUN:PARALLEL:SAMEFILE:{4}", "motor.xlsm", vXlWorkBook));

                Task.WhenAll(tasksSameFile.ToArray()).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            vXlWorkBook.Close(0);
            vXlApp.Quit();
            Marshal.ReleaseComObject(vXlWorkBook);
            Marshal.ReleaseComObject(vXlApp);
            Console.WriteLine($"end excel close");
        }

        private static async Task Run(string code, string fileName, Excel.Workbook vXlWorkBook = null)
        {
            await Task.Delay(random.Next(100, 500));
            var stopWatch = new Stopwatch();
            var needToClose = false;
            Excel.Application vXlApp = null;

            stopWatch.Start();

            Console.WriteLine($"{code} start excel");

            if (vXlWorkBook == null)
            {
                vXlApp = new Excel.Application();
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
                vXlWorkBook.Close(0);
                vXlApp?.Quit();
                Marshal.ReleaseComObject(vXlWorkBook);
                Marshal.ReleaseComObject(vXlApp);
                Console.WriteLine($"{code} end excel close in {stopWatch.ElapsedMilliseconds}ms");
            }
        }
    }
}
