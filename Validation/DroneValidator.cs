using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Validation
{
    public class DroneValidator : BaseValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is not DroneReport droneReport)
            {
                return ValidationResult.Failure("Invalid droneReport");
            }
            if(droneReport.Altitude < 100 || droneReport.Altitude > 10000)
            {
                return ValidationResult.Failure("Invalid Altitude");
            }
            else if (droneReport.ImageQuality < 1 || droneReport.ImageQuality > 100)
            {
                return ValidationResult.Failure("Invalid ImageQuality");
            }
            else
            {
                return ValidationResult.Success();
            }
        }
    }
}
