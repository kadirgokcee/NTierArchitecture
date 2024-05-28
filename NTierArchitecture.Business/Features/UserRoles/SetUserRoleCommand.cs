using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Features.UserRoles
{
    public sealed record SetUserRoleCommand(
    Guid UserId,
    Guid RoleId) : IRequest<Unit>;
}
