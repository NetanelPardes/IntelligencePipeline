using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class DroneReport: Reports.Report
    {
        private int _altitude;
        private int _imageQuality;

        public int Altitude { get; set; } 
        public int ImageQuality { get; set; }

    }
}
