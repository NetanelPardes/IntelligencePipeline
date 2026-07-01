using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligencePipeline.Validation
{
    public class ValidationResult
    {
        private bool _isValid;
        private string _errorMessage;

        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResult(bool isValid , string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }

        public static ValidationResult Success()
        {
            ValidationResult success = new ValidationResult(true, "");
            return success;

        }
        public static ValidationResult Failure(string errorMessage)
        {
            ValidationResult failure = new ValidationResult(false, errorMessage);
            return failure;
        }
    }
}
