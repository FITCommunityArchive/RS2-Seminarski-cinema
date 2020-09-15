using System.Collections.Generic;

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
