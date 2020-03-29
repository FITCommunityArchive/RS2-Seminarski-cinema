using Cinema.Authorization.Requirements;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Authorization.Handlers
{
    public class ReviewAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Review>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Review resource)
        {
            var userId = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

            if (userId == resource.UserId)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
