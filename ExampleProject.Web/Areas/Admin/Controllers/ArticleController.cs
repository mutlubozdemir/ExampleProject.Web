using AutoMapper;
using ExampleProject.Entity.DTOs.Articles;
using ExampleProject.Entity.Entities;
using ExampleProject.Service.Extensions;
using ExampleProject.Service.Services.Abstractions;
using ExampleProject.Web.ResultMessage;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace ExampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;
        private readonly IToastNotification toast;

        public ArticleController(IArticleService articleService,ICategoryService categoryService,IMapper mapper,IValidator<Article> validator,IToastNotification toast)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }


        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNoneDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var category = await categoryService.GetAllCategoriesNoneDeleted();
            return View(new ArticleAddDto { Categories = category });
        }


        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map = mapper.Map<Article>(articleAddDto);
            var result = await validator.ValidateAsync(map);

            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                var category = await categoryService.GetAllCategoriesNoneDeleted();
                return View(new ArticleAddDto { Categories = category });
                
            }
            else
            {
                await articleService.CreateArticleAsync(articleAddDto);
                toast.AddSuccessToastMessage(Messages.Artilce.Add(articleAddDto.Title), new ToastrOptions { Title = "Başarılı" });
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article = await articleService.GetArticlesWithCategoryNoneDeletedAsync(articleId);
            var categories = await categoryService.GetAllCategoriesNoneDeleted();

            var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            var map = mapper.Map<Article>(articleUpdateDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                var title = await articleService.UpdateArticleAsync(articleUpdateDto);
                toast.AddSuccessToastMessage(Messages.Artilce.Update(title), new ToastrOptions { Title = "Başarılı" });
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);
            }
            await articleService.UpdateArticleAsync(articleUpdateDto);
            var categories = await categoryService.GetAllCategoriesNoneDeleted();
            articleUpdateDto.Categories = categories;

            return View(articleUpdateDto);
        }

        public async Task<IActionResult> Delete(Guid articleId)
        {
            var title = await articleService.SafeDeleteArticleAsync(articleId);
            toast.AddSuccessToastMessage(Messages.Artilce.Delete(title), new ToastrOptions { Title = "Başarılı" });
            return RedirectToAction("Index", "Article", new {Area ="Admin"});
        }

    }
}
