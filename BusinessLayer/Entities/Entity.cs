using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Entities
{
    public abstract class Entity
    {
        public Entity(string theType)
        {
            this.Type = theType;
        }
        public bool IsValid;
        public string Message;
        public string Type { get; private set; }
        public List<EntityValidationResult> ValidationResults { get; private set; }
        
        
        public void AddValidationResult(EntityValidationResult theValidationResult)
        {
            ValidationResults.Add(theValidationResult);
        }
    }
}