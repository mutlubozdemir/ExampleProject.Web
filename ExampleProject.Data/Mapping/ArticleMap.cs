using ExampleProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Data.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {

            builder.HasData(
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Deneme Makalesi",
                Content = ".........................",
                ViewCount = 15,
                CategoryId = Guid.Parse("50FA1CA4-6559-4543-B545-033BDD167C2D"),
                ImageId = Guid.Parse("A14B14F8-A193-4940-A67F-ABFEF7E542A0"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("6168A092-56D5-439D-A0B8-940FBDA81950")

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi",
                Content = "Visual Studio.........................",
                ViewCount = 15,
                CategoryId = Guid.Parse("282DD9B5-E65D-44CA-B319-26505DE1795B"),
                ImageId = Guid.Parse("5447D768-E04D-4EE3-8CB7-CD9522DF5465"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("4083029D-7624-44D6-ACFA-4A54DEEFBD3F")

            });
        }
    }
}
