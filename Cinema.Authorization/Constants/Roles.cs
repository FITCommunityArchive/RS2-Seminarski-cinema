using System;

namespace Cinema.Authorization.Constants
{
    public static class Roles
    {
        // These static fields mirror the entries in the "Roles" database table.
        public const string User = "User";
        public const string ContentEditor = "ContentEditor";
        public const string Administrator = "Administrator";
    }
}
