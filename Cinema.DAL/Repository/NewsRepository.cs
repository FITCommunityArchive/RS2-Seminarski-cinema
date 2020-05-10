using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Services.Enums;
using System.Linq;

namespace Cinema.DAL.Repository
{
    public class NewsRepository : Repository<News, int>
    {
        public NewsRepository(ApplicationDbContext context) : base(context) { }

        public override IQueryable<News> Sort(IQueryable<News> query, SortOrder? sortOrder, string sortProperty)
        {
            if (sortOrder == SortOrder.ASC)
            {
                switch (sortProperty)
                {
                    case "Title":
                        query = query.OrderBy(s => s.Title);
                        break;
                    case "Description":
                        query = query.OrderBy(s => s.Description);
                        break;
                    case "DateCreated":
                        query = query.OrderBy(s => s.Created);
                        break;
                    case "TimeCreated":
                        query = query.OrderBy(s => s.Created.TimeOfDay);
                        break;
                    case "Type":
                        query = query.OrderBy(s => s.Type.Name);
                        break;
                }
            }
            else
            {
                switch (sortProperty)
                {
                    case "Title":
                        query = query.OrderByDescending(s => s.Title);
                        break;
                    case "Description":
                        query = query.OrderByDescending(s => s.Description);
                        break;
                    case "DateCreated":
                        query = query.OrderByDescending(s => s.Created);
                        break;
                    case "TimeCreated":
                        query = query.OrderByDescending(s => s.Created.TimeOfDay);
                        break;
                    case "Type":
                        query = query.OrderByDescending(s => s.Type.Name);
                        break;
                }
            }

            return query;
        }

    }
}
