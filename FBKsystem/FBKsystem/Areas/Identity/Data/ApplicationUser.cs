using Microsoft.AspNetCore.Identity;
using System;

namespace FBKsystem.Models
{
    public class ApplicationUser:IdentityUser
    {
       public DateTime RegDate { get; set; }
        public string FullName { get; set; }

     }
}
