using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Enums;
using IntelligencePipeline.Models.Reports;


namespace IntelligencePipeline.Validation
{
    public class SignalValidator : BaseValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if (report is not SignalReport signalReport)
            {
                return ValidationResult.Failure("Invalid soldierReport");
            }
            if (signalReport.Frequency < 1.0 || signalReport.Frequency > 3000.0)
            {
                return ValidationResult.Failure("Invalid Frequency");
            }
            else if (signalReport.Content.Length < 5 || signalReport.Content.Length > 1000)
            {
                return ValidationResult.Failure("Invalid Content");
            }
            else if (!Enum.IsDefined(typeof(Language), signalReport.Language))
            {
                return ValidationResult.Failure("Invalid Language");
            }
            else if (signalReport.SignalStrength < 0 || signalReport.SignalStrength > 120)
            {
                return ValidationResult.Failure("Invalid SignalStrength");
            }
            else
            {
                return ValidationResult.Success();
            }
        }
    }
}
