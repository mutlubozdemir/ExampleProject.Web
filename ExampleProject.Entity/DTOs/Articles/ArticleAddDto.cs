using ExampleProject.Entity.DTOs.Categories;
using Microsoft.AspNetCore.Http;

namespace ExampleProject.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IFormFile Photo { get; set; }
        public ICollection<CategoryDto> Categories { get; set; }
    }
}
