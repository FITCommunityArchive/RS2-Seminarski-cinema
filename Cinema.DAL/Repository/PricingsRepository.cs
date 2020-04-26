using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.Services.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.DAL.Repository
{
    public class PricingsRepository : Repository<Pricing, int>
    {
        public PricingsRepository(ApplicationDbContext context) : base(context) { }

        public override IQueryable<Pricing> Sort(IQueryable<Pricing> query, SortOrder? sortOrder, string sortProperty)
        {
            if (sortOrder == SortOrder.ASC)
            {
                switch (sortProperty)
                {
                    case "Name":
                        query = query.OrderBy(s => s.Name);
                        break;
                    case "Price":
                        query = query.OrderBy(s => s.Price);
                        break;
                    case "DateCreated":
                        query = query.OrderBy(s => s.Created);
                        break;
                    case "TimeCreated":
                        query = query.OrderBy(s => s.Created.TimeOfDay);
                        break;
                    default:
                        query = query.OrderBy(s => s.Name);
                        break;
                }
            }
            else
            {
                switch (sortProperty)
                {
                    case "Name":
                        query = query.OrderByDescending(s => s.Name);
                        break;
                    case "Price":
                        query = query.OrderByDescending(s => s.Price);
                        break;
                    case "DateCreated":
                        query = query.OrderByDescending(s => s.Created);
                        break;
                    case "TimeCreated":
                        query = query.OrderByDescending(s => s.Created.TimeOfDay);
                        break;
                    default:
                        query = query.OrderByDescending(s => s.Name);
                        break;
                }
            }

            return query;
        }

    }
}
