using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Calculators
{
    internal class ReliabilityCalculator
    {
        public int Calculate(Report report)
        {
            int score = report.CalculateReliabilityScore();
            if (score < 1)
            {
                return 1;
            }
            if(score > 10)
            {
                return 10;
            }
            return score;
        }
    }
}
