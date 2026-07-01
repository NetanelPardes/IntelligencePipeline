using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Validation;
using IntelligencePipeline.Models.Reports;

namespace IntelligencePipeline.Validation
{
    public class SoldierValidator: BaseValidator
    {
        protected override ValidationResult ValidateSpecificFields(Report report)
        {
            if(report is not SoldierReport soldierReport)
            {
                return ValidationResult.Failure("Invalid soldierReport");
            }
            if (soldierReport.SoldierName.Length < 2 || soldierReport.SoldierName.Length > 50)
            {
                return ValidationResult.Failure("Invalid SoldierName");
            }
            else if(soldierReport.SoldierID.Length != 7)
            {
                return ValidationResult.Failure("Invalid SoldierID");
            }
            else if(soldierReport.Unit.Length < 2 || soldierReport.Unit.Length > 50)
            {
                return ValidationResult.Failure("Invalid Unit");
            }
            else if (soldierReport.ConfidenceLevel > 5 || soldierReport.ConfidenceLevel < 1)
            {
                return ValidationResult.Failure("Invalid ConfidenceLevel");
            }
            else
            {
                return ValidationResult.Success();
            }
        }
    }
}
