//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using IntelligencePipeline.Models.Reports;
//using IntelligencePipeline.Storage;
//using IntelligencePipeline.Validation;

//namespace IntelligencePipeline.Pipeline
//{
//    public class ReportPipeline
//    {
//        private ReportRepository _validatedReports;
//        private RejectedReportRepository _rejectedReports;

//        public ReportPipeline()
//        {
//            _validatedReports = ReportRepository();
//            _rejectedReports = RejectedReportRepository();
//        }
//        public void ProcessReport(Report report)
//        {

//        }
//        public ReportRepository GetValidatedReports()
//        {
//            return _validatedReports;
//        }
//        public RejectedReportRepository GetRejectedReports()
//        {
//            return _rejectedReports;
//        }
//        public void DisplayStatistics()
//        {

//        }
//        private IValidator? GetValidator(Report report)
//        {
//            if(report is DroneReport) { return new DroneValidator(); }
//            if(report is RadarReport) { return new RadarValidator(); }
//            if(report is SignalReport) { return new SignalValidator(); }
//            if(report is SoldierReport) { return new SoldierValidator(); }
//            return null;
//        }
//        private void ValidateReport(Report report)
//        {

//        }
//        private void CalculateMetrics(Report report)
//        {

//        }
//        private void StoreReport(Report report)
//        {

//        }

//    }
//}
//}
