﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vedly.Models
{
    public class Min18YsIfaMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Date == null)
                return new ValidationResult("Birth date is required.");
            var age = DateTime.Today.Year - customer.Date.Value.Year;

            return (age >= 18) ? ValidationResult.Success
                : new ValidationResult("Customer should be atleast 18 years to go on a membership");
        }
    }
}