using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cinema.Services.Helpers
{
    public static class FileHelper
    {
        public static string GetUniqueName(string fileName)
        {
            fileName = Path.GetFileName(fileName);

            return Path.GetFileNameWithoutExtension(fileName)
                   + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
    }
}
