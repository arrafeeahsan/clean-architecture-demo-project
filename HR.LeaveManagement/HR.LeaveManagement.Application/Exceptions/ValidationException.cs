using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errros { get; set; } = new List<string>();
        public ValidationException(ValidationResult validationResult) 
        { 
            foreach (var error in validationResult.Errors)
            {
                Errros.Add(error.ErrorMessage);
            }
        }
    }
}
