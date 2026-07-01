using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class SoldierReport : Reports.Report
    {
        public string SoldierName { get; protected set; }
        public string SoldierID { get; }
        public string Unit { get; protected set; }
        public int ConfidenceLevel { get; protected set; }

        public SoldierReport(DateTime timestamp, double latitude, double longitude, string description, string soldierName, string soldierID, string unit, int confidenceLevel) : base( timestamp, latitude, longitude, description)
        {
            SoldierName = soldierName;
            SoldierID = soldierID;
            Unit = unit;
            ConfidenceLevel = confidenceLevel;
        }
        public override string GetSourceType() => "Soldier";
        public override int CalculateReliabilityScore()
        {
            int score = 4;
            score += ConfidenceLevel;
            string my_description = Description.ToLower();
            if(my_description.Contains("weapon") || my_description.Contains("vehicle") || my_description.Contains("movement") || my_description.Contains("explosion"))
            {
                score += 1;
            }
            return score;

        }
    }
}
