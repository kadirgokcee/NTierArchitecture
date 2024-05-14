﻿
using Microsoft.AspNetCore.Identity;

namespace NTierArchitecture.Entities.Models
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public int LastName { get; set; }
    }



}
