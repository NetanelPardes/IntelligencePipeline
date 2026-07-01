using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligencePipeline.Models.Reports;
namespace IntelligencePipeline.Validation
{
    public interface IValidator
    {
        public ValidationResult Validate(Report report);
    }
}
