using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class NewsType : BaseType
    {
        public NewsType()
        {
            News = new List<News>();
        }
        public virtual IList<News> News { get; set; }
    }
}