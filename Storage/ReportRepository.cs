using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Models.Enums;

namespace IntelligencePipeline.Storage
{
    public class ReportRepository
    {
        private List<Report> _reports;

        public ReportRepository()
        {
            _reports = new List<Report>();
        }

        public void Add(Report report)
        {
            _reports.Add(report);
        }
        public List<Report> GetAll()
        {
            return _reports;
        }
        public List<Report> GetByStatus(ReportStatus status)
        {
            List<Report> statusListReport = new List<Report>();
            foreach (var report in _reports)
            {
                if (report.Status == status)
                {
                    statusListReport.Add(report);
                }
            }
            return statusListReport;
        }
        public List<Report> GetByPriority(Priority priority)
        {
            List<Report> priorityListReport = new List<Report>();
            foreach (var report in _reports)
            {
                if (report.Priority == priority)
                {
                    priorityListReport.Add(report);
                }
            }
            return priorityListReport;
        }
        public List<Report> Search(string keyword)
        {
            List<Report> SearchListReport = new List<Report>();
            foreach (var report in _reports)
            {
                if (report.Description.Contains(keyword))
                {
                    SearchListReport.Add(report);
                }
            }
            return SearchListReport;
        }
        public Report? GetById(int reportId)
        {
            foreach (var report in _reports)
            {
                if (report.ReportId == reportId)
                {
                    return report;
                }
            }
            return null;
        }
        public void UpdateStatus(int reportId, ReportStatus newStatus)
        {
            foreach (var report in _reports)
            {
                if (report.ReportId == reportId)
                {
                    report.Status = newStatus;
                    return;
                }
            }
        }
        public int GetTotalCount()
        {
            return _reports.Count;
        }
        public int GetCountByStatus(ReportStatus status)
        {
            return GetByStatus(status).Count;
        }

    }
}
