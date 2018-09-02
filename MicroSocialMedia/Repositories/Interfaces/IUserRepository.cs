using MicroSocialMedia.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.Repositories.Interfaces
{
    interface IUserRepository : IRepository<string, AppUser>
    {
    }
}
