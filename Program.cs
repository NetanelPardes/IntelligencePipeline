using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;

namespace IntelligencePipeline
{
    public class program
    {
        static void Main()
        {
            Console.WriteLine("hello world");

            SignalReport sr = new SignalReport(new DateTime(2021 / 1 / 1), 20.0, 20.0, "good", 15.0, "bla", Language.Hebrew, 12);
            Console.WriteLine(sr.ToString());
            SoldierReport slr = new SoldierReport(DateTime.Now, 20.5, 35.8, "bad", "Netaenl", "318799517", "8200", 2);
            Console.WriteLine(slr.ToString());
        }
    }
}
