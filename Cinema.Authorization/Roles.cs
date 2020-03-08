using System;

namespace Cinema.Authorization
{
    public class Roles
    {
        // These static fields mirror the entries in the "Roles" database table
        public static readonly string User = nameof(User);
        public static readonly string ContentEditor = nameof(ContentEditor);
        public static readonly string Administrator = nameof(Administrator);
    }
}
