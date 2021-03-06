﻿using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AnuitexTraining.BusinessLogicLayer.Exceptions;
using AnuitexTraining.BusinessLogicLayer.Models.Base;
using AnuitexTraining.BusinessLogicLayer.Models.Users;
using AnuitexTraining.BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AnuitexTraining.PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("getPage")]
        public async Task<object> GetPageAsync(PageModel<UserModel> pageModel)
        {
            return await _userService.GetPageAsync(pageModel);
        }

        [Authorize]
        [HttpGet("get/{id}")]
        public async Task<UserModel> GetAsync(long id)
        {
            if (User.FindFirst("Id").Value == id.ToString() || User.FindFirst(ClaimTypes.Role).Value == "Admin")
            {
                return await _userService.GetAsync(id);
            }

            throw new UserException(HttpStatusCode.Unauthorized, new List<string>());
        }

        [Authorize]
        [HttpPut("update")]
        public async Task UpdateAsync(UserModel user)
        {
            bool isAdmin = User.FindFirst(ClaimTypes.Role).Value == "Admin";
            if (User.FindFirst("Id").Value == user.Id.ToString() || isAdmin)
            {
                await _userService.UpdateAsync(user, isAdmin);
            }
            else
            {
                throw new UserException(HttpStatusCode.Unauthorized, new List<string>());
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{id}")]
        public async Task DeleteAsync(long id)
        {
            await _userService.DeleteAsync(id);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("block/{id}")]
        public async Task BlockAsync(long id)
        {
            await _userService.BlockAsync(id);
        }
    }
}