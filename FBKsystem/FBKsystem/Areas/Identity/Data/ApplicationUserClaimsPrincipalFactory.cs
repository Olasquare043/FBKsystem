using FBKsystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FBKsystem.Areas.Identity.Data
{
    public class ApplicationUserClaimsPrincipalFactory:UserClaimsPrincipalFactory<ApplicationUser>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> UserManager,IOptions<IdentityOptions> options):base (UserManager,options)
        {

        }
        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("FullName", user.FullName));
            identity.AddClaim(new Claim("RegDate", user.RegDate.ToString()));
            return identity;
        }
    }
}
