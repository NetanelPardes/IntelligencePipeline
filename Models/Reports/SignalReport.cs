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
        public double Frequency { get; protected set; }
        public string Content { get; protected set; }
        public Language Language { get; protected set; }
        public int SignalStrength { get; protected set; }

        public SignalReport( DateTime timestamp, double latitude,double longitude, string description,double frequency, string content, Language language,int signalStrength): base( timestamp, latitude, longitude, description)
        {
            Frequency = frequency;
            Content = content;
            Language = language;
            SignalStrength = signalStrength;
        }
        public override string GetSourceType() => "Signal";
        public override int CalculateReliabilityScore()
        {
            int score = 5;
            if(SignalStrength >= -40) { score += 3; }
            else if (SignalStrength >= -70) { score += 2; }
            else if(SignalStrength < -100) { score -= 2; }
            if(Content.ToLower().Contains("attack") || Content.ToLower().Contains("target") || Content.ToLower().Contains("border") || Content.ToLower().Contains("vehicle"))
            {
                score += 1;
            }
            return score;

        }
        public override string ToString()
        {
            return $"Report ID: {ReportId}\nSource Type: {GetSourceType()}\nTimestamp: {Timestamp}\nLocation: ({Latitude}, {Longitude})\nDescription: {Description}\nStatus: {Status}\n" +
          $"Priority: {Priority}\nClassification: {Classification}\nReliability Score: {ReliabilityScore}\nRejection Reason: {RejectionReason}\nFrequency: {Frequency}\nContent: {Content}\nLanguage: {Language}\nSignalStrength: {SignalStrength}\n";
        }
    }
}
