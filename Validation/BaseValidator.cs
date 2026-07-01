using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;
using IntelligencePipeline.Validation;

namespace IntelligencePipeline.Validation
{
    public abstract class BaseValidator : IValidator
    {
        public ValidationResult Validate(Report report)
        {
            var commonResult = ValidateCommonFields(report);
            if (!commonResult.IsValid)
            {
                return commonResult;
            }
            return ValidateSpecificFields(report);
        }
        protected ValidationResult ValidateCommonFields(Report report)
        {
            if (report.Timestamp > DateTime.Now || report.Timestamp < new DateTime(2020, 01, 01))
            {
                return ValidationResult.Failure("Invalid time");
            }
            else if (report.Latitude < 29.5000 || report.Latitude > 33.5000)
            {
                return ValidationResult.Failure("Invalid Latitude");
            }
            else if (report.Longitude < 34.0000 || report.Longitude > 360000)
            {
                return ValidationResult.Failure("Invalid Longitude");
            }
            else if (report.Description.Length > 500 || report.Description.Length < 10)
            {
                return ValidationResult.Failure("Invalid Description");
            }
            else return ValidationResult.Success();
        }
        protected abstract ValidationResult ValidateSpecificFields(Report report);
    }
}