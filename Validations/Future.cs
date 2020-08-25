using System;
using System.ComponentModel.DataAnnotations;

namespace Office.Validations
{
    public class FutureAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime)
            {
                DateTime check = (DateTime)value;
                if(DateTime.Now < check)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Can't schedule something in the Past");
                }
            }
            else
            {
                return new ValidationResult("Please enter a valid Date.");
            }
        }
    }
}