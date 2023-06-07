using BusinessLayer.BL;
using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Strategies
{
    public class PostStrategyValidator : IEntityStrategyValidator
    {
        public void Validate(Entity theEntity)
        {
            var postBL = PostBL.GetInstance();
            var post = (Post)theEntity;

            post.AddValidationResult(postBL.validateId(post.Id));
            post.AddValidationResult(postBL.validateTitle(post.Tittle));
            post.AddValidationResult(postBL.validateContent(post.Content));
            post.AddValidationResult(postBL.validateWrittenDate(post.WrittenDate));
            post.AddValidationResult(postBL.validateModifiedDate(post.ModifiedDate));
        } 
    }
}
