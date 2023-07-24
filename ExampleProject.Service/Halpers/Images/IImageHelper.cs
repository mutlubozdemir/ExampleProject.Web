using ExampleProject.Entity.DTOs.Images;
using ExampleProject.Entity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Service.Halpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadDto> Upload(string name, IFormFile imageFile, ImageType ımageType, string folderName = null);

        void Dlete(string imageName);
    }
}
