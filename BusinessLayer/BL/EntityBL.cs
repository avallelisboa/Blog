using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessLayer.BL
{
    public abstract class EntityBL<T> where T : class
    {
        public virtual EntityValidationResult IsValid(T theEntity)
        {
            EntityValidationResult aValidationResult = Validate(theEntity);
            return aValidationResult;
        }
        protected EntityValidationResult Validate(T theEntity)
        {
            EntityValidationResult aEntityResult = new EntityValidationResult
            {
                isValid = true,
                message = ""
            };

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext aContext = new ValidationContext(theEntity, serviceProvider: null, items: null);
            
            if(!Validator.TryValidateObject(theEntity, aContext, results, true))
            {
                aEntityResult.isValid = false;
                foreach(ValidationResult aValidationResult in results)
                {
                    aEntityResult.message += aValidationResult.ErrorMessage + " ";
                }
            }

            return aEntityResult;            
        }
    }
}
