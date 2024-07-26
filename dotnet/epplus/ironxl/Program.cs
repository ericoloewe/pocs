using IronXL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ironxl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"start motor");

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            WorkBook workbook = WorkBook.Load(File.OpenRead("../../../motor.xlsm"));
            WorkSheet sheet = workbook.GetWorkSheet("Output");

            Console.WriteLine($"B13: {sheet["B13"].Value}");
            Console.WriteLine($"B14: {sheet["B14"].Value}");
            Console.WriteLine($"B15: {sheet["B15"].Value}");

            Console.WriteLine($"end motor in {stopWatch.ElapsedMilliseconds}ms");
            Console.ReadKey();
        }
    }
}
