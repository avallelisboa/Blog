using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using BusinessLayer.Strategies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessLayer.BL
{
    public abstract class EntityBL
    {
        public EntityValidationResult IsValid(Entity theEntity)
        {
            Validate(theEntity);
            SetValidationResults(theEntity);
            
            EntityValidationResult result = new EntityValidationResult();
            
            result.IsValid = theEntity.IsValid;
            result.Message = theEntity.Message;
            
            return result;
        }
        public void SetValidationResults(Entity theEntity)
        {
            bool isValid = true;
            string message ="";
            foreach(var validationResult in theEntity.ValidationResults)
            {
                if (validationResult.IsValid == false)
                    isValid = false;

                if (validationResult.Message.Length > 0)
                    message += validationResult.Message;
            }
            theEntity.IsValid = isValid;
            theEntity.Message = message;
        }
        private void Validate(Entity theEntity)
        {
            IEntityStrategyValidator strategy = StrategyFactory.GetStrategy(theEntity);
            strategy.Validate(theEntity);
        }
    }
}