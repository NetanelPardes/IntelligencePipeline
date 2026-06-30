using IntelligencePipeline.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class SignalReport : Reports.Report
    {
        private double _frequency;
        private string _content;
        private Language _language;
        private int _signalStrength;

        public double Frequency { get; set; } 
        public string Content { get; set; } 
        public Language Language { get; set; } 
        public int SignalStrength { get; set; }


    }
}
