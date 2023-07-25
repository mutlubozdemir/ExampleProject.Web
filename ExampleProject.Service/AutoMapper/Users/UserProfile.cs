using AutoMapper;
using ExampleProject.Entity.DTOs.Users;
using ExampleProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Service.AutoMapper.Users
{
	public class UserProfile:Profile
	{
		public UserProfile()
		{
			CreateMap<AppUser,UserDto>().ReverseMap();
		}
	}
}
