﻿using MediatR;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Entities.Event
{
    public sealed class UserDomainEvent : INotification
    {
        public AppUser AppUser { get; }

        public UserDomainEvent(AppUser appUser)
        {
            AppUser = appUser;
        }
    }
}
