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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {

                Id = Guid.Parse("50FA1CA4-6559-4543-B545-033BDD167C2D"),
                Name = "Asp.net Corew",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
           new Category
           {
               Id = Guid.Parse("282DD9B5-E65D-44CA-B319-26505DE1795B"),
               Name = "Visual Studio 2022",
               CreatedBy = "Admin Test",
               CreatedDate = DateTime.Now,
               IsDeleted = false,
           });
        }
    }
}
