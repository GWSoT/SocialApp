using AutoMapper;
using MicroSocialMedia.Services.Interfaces;
using MicroSocialMedia.WriteModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MicroSocialMedia.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;

        private UserService(
            UserManager<AppUser> userManager,
            IMapper mapper,
            SignInManager<AppUser> signInManager
            ) 
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
        }


        public async Task<ClaimsIdentity> GetClaimsIdentityAsync(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            var userToVerify = await _userManager.FindByNameAsync(userName);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {

            }

            return await Task.FromResult<ClaimsIdentity>(null);
        }

        public async Task<AppUser> CreateUser(string email, string pasword)
        {
            var user = new AppUser();
            var created = await _userManager.CreateAsync(user);

            if (created.Succeeded)
            {
                return user;
            }

            return null;
        }

        public AppUser Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        AppUser IUserService.CreateUser(string email, string pasword)
        {
            throw new NotImplementedException();
        }
    }
}
