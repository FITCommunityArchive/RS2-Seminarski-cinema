using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Cinema.Authorization.Handlers.IsAdminHandler;

namespace Cinema.Authorization.Handlers
{
    public class IsAdminHandler : AuthorizationHandler<OperationAuthorizationRequirement, Movie>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement, Movie movie)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }

            if (context.User.IsInRole(Roles.Administrator))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

        public class IsAdminRequirement : IAuthorizationRequirement { }
    }
}
