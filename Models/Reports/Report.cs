using IntelligencePipeline.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public abstract class Report
    {
        private static int idcounter = 0;
        public int ReportId { get; }
        public DateTime Timestamp { get; protected set; }
        public double Latitude { get; protected set; }
        public double Longitude { get; protected set; }
        public string Description { get; protected set; }
        public ReportStatus Status { get; set; }
        public Priority Priority { get; set; }
        public Classification Classification { get; set; }
        public int ReliabilityScore { get; set; }
        public string RejectionReason { get; set; }

        protected Report(DateTime timestamp, double latitude,double longitude, string description)
        {
            idcounter++;
            ReportId = idcounter;
            Timestamp = timestamp;
            Latitude = latitude;
            Longitude = longitude;
            Description = description;
        }
        public abstract string GetSourceType();
        public abstract int CalculateReliabilityScore();
        public virtual string GetSummary()
        {
            return $" Report #{ReportId} | Status: {Status} | Priority: {Priority} | Classification: {Classification} | Reliability: {ReliabilityScore}";
        }
        public override string ToString()
        {
            return $"Report ID: {ReportId}\nSource Type: {GetSourceType()}\nTimestamp: {Timestamp}\nLocation: ({Latitude}, {Longitude})\nDescription: {Description}\nStatus: {Status}\n" +
          $"Priority: {Priority}\nClassification: {Classification}\nReliability Score: {ReliabilityScore}\nRejection Reason: {RejectionReason}";
        }
    }
}
