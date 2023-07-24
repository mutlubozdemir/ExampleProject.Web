using AutoMapper;
using ExampleProject.Entity.DTOs.Articles;
using ExampleProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Service.AutoMapper.Articles
{
	public class ArticleProfile:Profile
	{
		public ArticleProfile()
		{
			CreateMap<ArticleDto,Article>().ReverseMap();	
			CreateMap<ArticleUpdateDto,Article>().ReverseMap();	
			CreateMap<ArticleUpdateDto,ArticleDto>().ReverseMap();	
			CreateMap<ArticleAddDto,Article>().ReverseMap();	
		}
	}
}
