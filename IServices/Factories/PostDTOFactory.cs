﻿using BusinessLayer.Entities;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IServices.Factories
{
    public class PostDTOFactory : DTOsAbstractFactory
    {
        private static PostDTOFactory _instance;
        private PostDTOFactory() { }
        public static PostDTOFactory GetInstance()
        {
            if (_instance == null)
                _instance = new PostDTOFactory();

            return _instance;
        }
        public override ActionResult makeValidDTO(Entity theEntity)
        {
            Post post = (Post)theEntity;
            return new PostResponse
            {
                isValid = true,
                message ="",
                Id = post.Id,
                Author = $"{post.Author.Name} {post.Author.LastName}",
                Tittle = post.Tittle,
                Content = post.Content,
                Categories = post.Categories.Select(c =>new CategoryResponse {Id = c.Id, Name = c.Name }).ToList(),
                WrittenDate = post.WrittenDate,
                ModifiedDate = post.ModifiedDate                
            };
        }
    }
}
