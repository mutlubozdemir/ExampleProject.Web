﻿using ExampleProject.Entity.DTOs.Categories;
using ExampleProject.Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace ExampleProject.Entity.DTOs.Articles
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Image Image { get; set; }
        public IFormFile? Photo { get; set; }
        public Guid CategoryId { get; set; }
        public ICollection<CategoryDto> Categories { get; set; }
    }
}
