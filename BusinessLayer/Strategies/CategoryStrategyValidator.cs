using BusinessLayer.BL;
using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Strategies
{
    public class CategoryStrategyValidator : IEntityStrategyValidator
    {
        public void Validate(Entity theEntity)
        {
            var categoryBL = CategoryBL.GetInstance();
            var category = (Category)theEntity;

            category.AddValidationResult(categoryBL.validateId(category.Id));
            category.AddValidationResult(categoryBL.validateName(category.Name));
        }
    }
}
