using MicroSocialMedia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroSocialMedia.WriteModels
{
    public class Profile : Entity<Guid>
    {
        public AppUser User { get; private set; }
        public string ProfilePicUrl { get; private set; }
        

        [Obsolete("EF Core constructor")]
        public Profile() { }

        public Profile(AppUser user, string profilePicUrl)
        {
            User = user;
            ProfilePicUrl = profilePicUrl;
        }
    }
}
