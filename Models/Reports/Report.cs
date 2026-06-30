using IntelligencePipeline.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class Report
    {
        private int _reportId;
        public int ReportId 
        {
            get => _reportId; 
        }

        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
            }
        }
        private double _latitude;
        public double Latitude 
        {
            get => _latitude;
            set
            {
                _latitude = value;
            } 
        }
        private double _longitude;
        public double Longitude 
        {
            get => _longitude; 
            set 
            {
                _longitude = value; 
            } 
        }
        private string _description;
        public string Description 
        {
            get => _description;
            set
            {
                    _description = value;
            } 
        }
        private ReportStatus _status;
        public ReportStatus Status { get; set; }
        private Priority _priority;
        public Priority Prioraty{ get; set; }
        private Classification _classification;
        public Classification Classification { get; set; }
        private int _reliabilityScore;
        public int ReliabilityScore { get; set; }
        private string _rejectionReason;
        public string RejectionReason { get; set; }


    }
}
