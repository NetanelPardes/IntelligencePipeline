using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Reports
{
    public class RadarReport : Reports.Report
    {
        private int _speed;
        private int _direction;
        private int _distance;

        public int Speed { get; set; }
        public int Direction { get; set; }
        public int Distance { get; set; }
    }
}
