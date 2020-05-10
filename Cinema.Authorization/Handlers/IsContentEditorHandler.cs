using Cinema.Authorization.Constants;
using Cinema.Authorization.Requirements;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Movies;
using Microsoft.AspNetCore.Authorization;
using Cinema.Domain.Entities.Identity;
using Cinema.DTO.ViewModels.Movies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Cinema.Authorization.Handlers.IsContentEditorHandler;

namespace Cinema.Authorization.Handlers
{
    public class IsContentEditorHandler : AuthorizationHandler<IsContentEditorRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                   IsContentEditorRequirement requirement)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }

            if (context.User.IsInRole(Roles.ContentEditor))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
