using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Models.Enums
{
    public enum ReportStatus
    {
        New,
        Validating,
        Validated,
        Rejected,
        InProgress,
        Completed
    }

}
