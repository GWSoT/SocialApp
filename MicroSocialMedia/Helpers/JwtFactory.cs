using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MicroSocialMedia.Helpers
{
    public class JwtFactory : IJwtFactory
    {
        public Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity)
        {
            throw new NotImplementedException();
        }

        public ClaimsIdentity GetClaimsIdentity(string userName, string id)
        {
            throw new NotImplementedException();
        }
    }
}
