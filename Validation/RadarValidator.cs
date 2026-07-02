using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Validation
{
    public class RadarValidator : BaseValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is not RadarReport radarReport)
            {
                return ValidationResult.Failure("Invalid droneReport");
            }
            if (radarReport.Speed < 0 || radarReport.Speed > 2000)
            {
                return ValidationResult.Failure("Invalid Speed");
            }
            else if (radarReport.Direction < 0 || radarReport.Direction > 360)
            {
                return ValidationResult.Failure("Invalid Direction");
            }
            else if (radarReport.Distance < 100 || radarReport.Distance > 100000)
            {
                return ValidationResult.Failure("Invalid Distance");
            }
            else
            {
                return ValidationResult.Success();
            }
        }
    }
}
