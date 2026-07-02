using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Storage
{
    public class RejectedReportRepository
    {
        private List<Report> _rejectedReports;
        public RejectedReportRepository()
        {
            _rejectedReports = new List<Report>();
        }
        public void Add(Report report)
        {
            _rejectedReports.Add(report);
        }
        public List<Report> GetAll()
        {
            return _rejectedReports;
        }
        public int GetTotalCount()
        {
            return _rejectedReports.Count;
        }
        public List<Report> GetByReason(string reasonKeyword)
        {
            List<Report> ReasonListRejectedReport = new List<Report>();
            foreach (var report in _rejectedReports)
            {
                if (report.RejectionReason == reasonKeyword)
                {
                    ReasonListRejectedReport.Add(report);
                }
            }
            return ReasonListRejectedReport;
        }

    }
}
