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

        public double Frequency 
        {
            get => _frequency;
            set
            {
                _frequency = value
            }
        } 
        public string Content 
        {
            get => _content;
            set
            {
                _content = value
            }
        } 
        public Language Language 
        {
            get => _language;
            set
            {
                _language = value
            }
        } 
        public int SignalStrength 
        {
            get => _signalStrength;
            set
            {
                _signalStrength = value
            }
        }


    }
}
