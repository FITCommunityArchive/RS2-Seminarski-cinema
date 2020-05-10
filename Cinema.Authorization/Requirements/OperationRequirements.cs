using Cinema.Authorization.Constants;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Cinema.Authorization.Requirements
{
    public static class OperationRequirements
    {
        public static readonly OperationAuthorizationRequirement Create =
          new OperationAuthorizationRequirement { Name = Operations.CreateOperationName };

        public static readonly OperationAuthorizationRequirement Read =
          new OperationAuthorizationRequirement { Name = Operations.ReadOperationName };

        public static readonly OperationAuthorizationRequirement Update =
          new OperationAuthorizationRequirement { Name = Operations.UpdateOperationName };

        public static readonly OperationAuthorizationRequirement Delete =
          new OperationAuthorizationRequirement { Name = Operations.DeleteOperationName };
    }
}
