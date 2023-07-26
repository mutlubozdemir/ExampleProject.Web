﻿using AutoMapper;
using ExampleProject.Entity.DTOs.Users;
using ExampleProject.Entity.Entities;
using ExampleProject.Web.ResultMessage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace ExampleProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;

        public UserController(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager, IMapper mapper,IToastNotification toast)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.toast = toast;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);


            foreach (var item in map)
            {
                var findUser = await userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));
                item.Role = role;
            }
            return View(map);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(new UserAddDto { Roles = roles });
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var roles = await roleManager.Roles.ToListAsync();

            if (ModelState.IsValid)
            {
                map.UserName = userAddDto.Email;
                var result = await userManager.CreateAsync(map,String.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
                if (result.Succeeded)
                {
                    var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                    await userManager.AddToRoleAsync(map,findRole.ToString());
                    toast.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email),new ToastrOptions { Title  = "Başarılı"});
                    return RedirectToAction("Index", "User", new { Areas = "Admin" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(new UserAddDto { Roles = roles });

                }
            }
            return View(new UserAddDto { Roles = roles });
        }
    }
}
