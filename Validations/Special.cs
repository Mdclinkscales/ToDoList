using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Office.Validations
{
    public class SpecialAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is string)
            {
                var pass = (string)value;
                var regexItem = new Regex("^(.{0,7}|[^0-9]*|[^A-Z]*|[^a-z]*|[a-zA-Z0-9]*)$");
                if(regexItem.IsMatch(pass))
                {
                    return new ValidationResult("Password must include a mix of uppercase and lowercase letters, a number, and a special character");
                    
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Please enter a valid Date.");
            }
        }
    }
}