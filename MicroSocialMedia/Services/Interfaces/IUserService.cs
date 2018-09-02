using MicroSocialMedia.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.Services.Interfaces
{
    interface IUserService
    {
        AppUser Authenticate(string email, string password);
        AppUser CreateUser(string email, string pasword);
    }
}
