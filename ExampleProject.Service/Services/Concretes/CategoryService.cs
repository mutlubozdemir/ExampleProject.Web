using AutoMapper;
using ExampleProject.Data.UnitOfWorks;
using ExampleProject.Entity.DTOs.Categories;
using ExampleProject.Entity.Entities;
using ExampleProject.Service.Extensions;
using ExampleProject.Service.Halpers.Images;
using ExampleProject.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ExampleProject.Service.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContext;
        private readonly ClaimsPrincipal _user;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContext, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContext = httpContext;
            _user = httpContext.HttpContext.User;
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNoneDeleted()
        {
            var category = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(category);
            return map;
        }

        public async Task CreatedCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var userEmail = _user.GetLoggedInUserEmail();

            Category category = new(categoryAddDto.Name,userEmail);
            await unitOfWork.GetRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();
        }

        public async Task<Category> GetCategoryByGuidAsync(Guid categoryId)
        {
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);
            return category;
        }


        public async Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdate)
        {
            var userEmail = _user.GetLoggedInUserEmail();
            var category = await unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdate.Id);

            category.Name = categoryUpdate.Name;
            category.ModifiedBy = userEmail;
            category.ModifiedDate = DateTime.Now;

            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }

        public async Task<string> SafeDeleteCategoryAsync(Guid categoryId)
        {
            var userName = _user.GetLoggedInUserEmail();
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);

            category.IsDeleted = true;
            category.DeletedBy = userName;
            category.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepository<Category>().DeleteAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }
    }
}
