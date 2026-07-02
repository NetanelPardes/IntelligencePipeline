using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Calculators
{
    public class ClassificationCalculator
    {
        public Classification Calculate(Report report)
        {
            if (report.Priority == Priority.Critical) { return Classification.TopSecret; }
            if (report is SignalReport signal)
            {
                if (containsWords(signal.Content, "target", "attack", "missile"))
                {
                    return Classification.TopSecret;
                }
                return Classification.Secret;
            }
            if (report.Priority == Priority.High)
            {
                return Classification.Secret;
            }
            if (containsWords(report.Description, "border ", "weapon"))
            {
                return Classification.Secret;
            }
            if(report.Priority == Priority.Medium)
            {
                return Classification.Restricted;
            }
            if(report is SoldierReport soldier)
            {
                return Classification.Restricted;
            }
            return Classification.Unclassified;
        }

        private bool containsWords(string text, params string[] words)
        {
            foreach (string word in words)
            {
                if (text.Contains(word)) { return true; }
            }
            return false;
        }
    }
}
