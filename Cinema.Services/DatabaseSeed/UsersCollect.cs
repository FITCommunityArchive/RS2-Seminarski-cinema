using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Services.DatabaseSeed
{
    public class UsersCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                User user = new User
                {
                    Username = rawData.ReadString(row, 2),
                    Password = rawData.ReadString(row, 3),
                    FirstName = rawData.ReadString(row, 4),
                    LastName = rawData.ReadString(row, 5),
                    EmailAddress = rawData.ReadString(row, 6),
                    Role = context.AppRoles.Find(rawData.ReadInteger(row, 7))
                };

                context.Add(user);
                context.SaveChanges();
            }
        }
    }
}
