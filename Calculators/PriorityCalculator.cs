using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;


namespace IntelligencePipeline.Calculators
{
    public class PriorityCalculator
    {
        public Priority Calculate(Report report)
        {
            if (containsWords(report.Description, "missile", "explosion", "attack", "fire"))
            {
                return Priority.Critical;
            }

            if (report is SignalReport signal)
            {
                if (containsWords(signal.Content, "missile", "explosion", "attack", "fire"))
                {
                    return Priority.Critical;
                }

                if (containsWords(signal.Content, "target") && containsWords(signal.Content, "attack"))
                {
                    return Priority.Critical;
                }
            }

            if (report is RadarReport radar)
            {
                if (radar.Speed >= 800)
                {
                    return Priority.Critical;
                }

                if (radar.Speed >= 400)
                {
                    return Priority.High;
                }

                if (radar.Speed >= 120)
                {
                    return Priority.Medium;
                }
            }

            if (containsWords(report.Description, "weapon", "suspicious", "border"))
            {
                return Priority.High;
            }

            if (report is DroneReport drone && drone.Altitude < 500)
            {
                return Priority.High;
            }

            if (report is SoldierReport soldier &&
                soldier.ConfidenceLevel >= 4 &&
                containsWords(soldier.Description, "movement"))
            {
                return Priority.High;
            }

            if (containsWords(report.Description, "movement", "vehicle", "activity"))
            {
                return Priority.Medium;
            }

            if (report.ReliabilityScore >= 7)
            {
                return Priority.Medium;
            }

            return Priority.Low;
        
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
