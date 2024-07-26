using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace npoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            Console.WriteLine($"start excel");

            IWorkbook wb = new HSSFWorkbook(File.OpenRead("../../../motor.xlsm"));

            HSSFFormulaEvaluator formula = new HSSFFormulaEvaluator(wb);

            formula.EvaluateAll();

            //Console.WriteLine($"B13: {ws.Cells[13, "B"].Value}");
            //Console.WriteLine($"B14: {ws.Cells[14, "B"].Value}");
            //Console.WriteLine($"B15: {ws.Cells[15, "B"].Value}");

            Console.WriteLine($"end excel print in {stopWatch.ElapsedMilliseconds}ms");
        }
    }
}
