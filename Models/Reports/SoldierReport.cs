using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class SoldierReport : Reports.Report
    {
        private string _soldierName;
        private string _soldierID;
        private string _unit;
        private int _confidenceLevel;

        public string SoldierName { get; set; }
        public string SoldierID { get; set; }
        public string Unit { get; set; }
        public int ConfidenceLevel { get; set; }

    }
}
