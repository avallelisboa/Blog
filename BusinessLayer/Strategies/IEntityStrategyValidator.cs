using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Strategies
{
    public interface IEntityStrategyValidator
    {
        public abstract void Validate(Entity theEntity);
    }
}
