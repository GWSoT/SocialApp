using MicroSocialMedia.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.WriteModels
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Guid ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
