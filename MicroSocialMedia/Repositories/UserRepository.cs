using MicroSocialMedia.Data;
using MicroSocialMedia.Repositories.Interfaces;
using MicroSocialMedia.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.Repositories
{
    public class UserRepository : Repository<string, AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext _dbContext) : base(_dbContext)
        { }


    }
}
