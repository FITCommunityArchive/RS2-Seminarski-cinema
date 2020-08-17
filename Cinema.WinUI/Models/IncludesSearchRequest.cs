using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.WinUI
{
    public class IncludesSearchRequest
    {
        public IncludesSearchRequest()
        {
            Includes = new List<string>();
        }

        public ICollection<string> Includes { get; set; }
    }
}
