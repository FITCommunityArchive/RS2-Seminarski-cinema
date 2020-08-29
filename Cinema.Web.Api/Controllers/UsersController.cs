﻿using Cinema.Models.Dtos;
using Cinema.Models.Requests.Users;
using Cinema.Utilities.Interfaces;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cinema.Web.Api.Controllers
{
    public class UsersController : BaseCRUDController<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        private readonly IUserService _userService;
        public UsersController(ICRUDService<ApplicationUserDto, UserSearchRequest, UserUpsertRequest, UserUpsertRequest> service, IUserService userService) : base(service)
        {
            _userService = userService;
        }


        [HttpPut("{id}/resetPassword")]
        public async Task<IActionResult> ResetPassword(int id, [FromBody] UserPasswordResetRequest data)
        {
            IActionResult response;
            var passwordReset = await _userService.ResetPassword(id, data.NewPassword, data.Token);
            if (passwordReset)
            {
                response = Ok(new { Message = "Password changed Succesfully." });
            }
            else
            {
                response = BadRequest(new { Message = "Error. Passwords Mismatch." });
            }

            return response;
        }

        [HttpGet("{id}/resetPasswordToken")]
        public async Task<string> ResetPasswordToken(int id)
        {
            return await _userService.ResetPasswordToken(id);
        }

        [HttpPost("register"), AllowAnonymous]
        public async Task<ApplicationUserDto> RegisterAsync(UserRegisterRequest model)
        {
            return await _userService.RegisterAsync(model);
        }
    }
}
