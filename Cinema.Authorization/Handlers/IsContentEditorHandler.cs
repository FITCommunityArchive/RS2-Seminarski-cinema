using Cinema.Authorization.Constants;
using Cinema.Authorization.Requirements;
using Cinema.Shared.Constants;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

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
