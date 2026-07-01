using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class DroneReport: Reports.Report
    {
        public int Altitude { get; protected set; }
        public int ImageQuality { get; protected set; }

        public DroneReport(DateTime timestamp, double latitude,double longitude, string description,int altitude, int imageQuality): base (timestamp, latitude, longitude, description)
        {
            Altitude = altitude;
            ImageQuality = imageQuality;
        }
        public override string GetSourceType() => "Drone";
        public override int CalculateReliabilityScore()
        {
            int score = 5;
            if(ImageQuality >= 80){ score += 3;}
            else if(ImageQuality >= 50) { score += 2; }

            if (Altitude >= 500 && Altitude <= 3000) { score += 2; }
            else if(Altitude > 7000) { score -= 2; }

            return score;

        }
    }
}
