﻿using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Threading.Tasks;
using AnuitexTraining.BusinessLogicLayer.Exceptions;
using AnuitexTraining.BusinessLogicLayer.Models.Users;
using AnuitexTraining.BusinessLogicLayer.Services.Interfaces;
using AnuitexTraining.PresentationLayer.Providers;
using Microsoft.AspNetCore.Mvc;
using static AnuitexTraining.Shared.Constants.Constants;

namespace AnuitexTraining.PresentationLayer.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly JwtProvider _jwtProvider;
        private readonly IUserService _userService;

        public AccountController(IAccountService accountService, IUserService userService, JwtProvider jwtProvider)
        {
            _accountService = accountService;
            _userService = userService;
            _jwtProvider = jwtProvider;
        }

        [HttpGet("signIn")]
        public async Task<object> SignInAsync(string email, string password)
        {
            await _accountService.SignInAsync(email, password);
            var id = await _accountService.GetIdAsync(email);
            var accessToken = _jwtProvider.GenerateAccessToken(await _userService.GetAsync(id),
                await _accountService.GetRoleAsync(email));
            var refreshToken = _jwtProvider.GenerateRefreshToken();
            await _accountService.UpdateRefreshTokenAsync(email, refreshToken);
            return new {accessToken, refreshToken};
        }

        [HttpPost("signUp")]
        public async Task SignUpAsync(UserModel user)
        {
            await _accountService.SignUpAsync(user);
        }
        
        [HttpGet("signOut")]
        public async Task SignOutAsync()
        {
            await _accountService.SignOutAsync(User.FindFirst("Sub").Value);
        }

        [HttpGet("confirmEmail")]
        public async Task<object> ConfirmEmailAsync(long id, string code)
        {
            return await _accountService.ConfirmEmailAsync(id, code);
        }

        [HttpGet("changeEmail")]
        public async Task ChangeEmailAsync(long id, string email, string code)
        {
            await _accountService.ChangeEmailAsync(id, email, code);
        }

        [HttpGet("forgotPassword")]
        public async Task ForgotPasswordAsync(string email)
        {
            await _accountService.ForgotPasswordAsync(email);
        }

        [HttpGet("refreshToken")]
        public async Task<object> RefreshTokenAsync(string accessToken, string refreshToken)
        {
            JwtSecurityToken token;
            try
            {
                token = _jwtProvider.GetValidatedExpiredAccessToken(accessToken);
            }
            catch
            {
                throw new UserException(HttpStatusCode.BadRequest,
                    new List<string> {ExceptionsInfo.InvalidAccessToken});
            }

            var email = token.Payload.Sub;
            await _accountService.VerifyRefreshTokenAsync(email, refreshToken);
            var role = await _accountService.GetRoleAsync(email);
            var id = await _accountService.GetIdAsync(email);
            accessToken = _jwtProvider.GenerateAccessToken(await _userService.GetAsync(id), role);
            refreshToken = _jwtProvider.GenerateRefreshToken();
            await _accountService.UpdateRefreshTokenAsync(email, refreshToken);
            return new {accessToken, refreshToken};
        }
    }
}