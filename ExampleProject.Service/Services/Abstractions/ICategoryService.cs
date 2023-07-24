using ExampleProject.Entity.DTOs.Categories;
using ExampleProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		public Task<List<CategoryDto>> GetAllCategoriesNoneDeleted();
		Task CreatedCategoryAsync(CategoryAddDto categoryAddDto);
		Task<Category> GetCategoryByGuidAsync(Guid categoryId);
		Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdate);
		Task<string> SafeDeleteCategoryAsync(Guid categoryId);
    }
}
