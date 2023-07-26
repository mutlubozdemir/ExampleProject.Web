using ExampleProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExampleProject.Data.Mapping
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("A14B14F8-A193-4940-A67F-ABFEF7E542A0"),
                FileName = "images/testimage",
                FileType = ".jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
               new Image
               {
                   Id = Guid.Parse("5447D768-E04D-4EE3-8CB7-CD9522DF5465"),
                   FileName = "images/vstest",
                   FileType = ".png",
                   CreatedBy = "Admin Test",
                   CreatedDate = DateTime.Now,
                   IsDeleted = false,
               });
        }
    }
}
