﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_MVC.Models
{
    public class Min18YeasIfaMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cusomer = (Customer)validationContext.ObjectInstance;
            if (cusomer.MembershipTypeId == MembershipType.Unknown
                || cusomer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (cusomer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");
            var age = DateTime.Now.Year - cusomer.BirthDate.Value.Year;
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer must be atlest 18 years old to go on a memership");
        }
    }
}