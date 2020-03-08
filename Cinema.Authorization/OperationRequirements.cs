using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Authorization
{
    public class OperationRequirements
    {
        public static OperationAuthorizationRequirement Create =
          new OperationAuthorizationRequirement { Name = Operations.Create };

        public static OperationAuthorizationRequirement Read =
          new OperationAuthorizationRequirement { Name = Operations.Read };

        public static OperationAuthorizationRequirement Update =
          new OperationAuthorizationRequirement { Name = Operations.Update };

        public static OperationAuthorizationRequirement Delete =
          new OperationAuthorizationRequirement { Name = Operations.Delete };
    }
}
