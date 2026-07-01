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

        public string SoldierName 
        {
            get => _soldierName;
            set
            {
                _soldierName = value
            }
        }
        public string SoldierID 
        {
            get => _soldierID;
            set
            {
                _soldierID = value
            }
        }
        public string Unit 
        {
            get => _unit;
            set
            {
                _unit = value
            }
        }
        public int ConfidenceLevel 
        {
            get => _confidenceLevel;
            set
            {
                _confidenceLevel = value
            }
        }

    }
}
