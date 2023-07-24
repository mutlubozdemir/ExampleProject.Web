using AutoMapper;
using ExampleProject.Entity.DTOs.Articles;
using ExampleProject.Service.Services.Abstractions;
using ExampleProject.Service.Services.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExampleProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger,IArticleService articleService,IMapper mapper)
        {
            _logger = logger;
            this.mapper = mapper;
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesWithCategoryNoneDeletedAsync();
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}