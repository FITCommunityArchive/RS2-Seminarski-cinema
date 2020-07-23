using Cinema.Domain.Entities;
using Cinema.Shared.Constants;
using Cinema.Shared.Enums;
using Cinema.Utilities.Interfaces;
using System.Linq;

namespace Cinema.Dal.Repository
{
    public class PricingRepository : Repository<Pricing, int>
    {
        public PricingRepository(ICinemaDbContext context) : base(context) { }

        public bool ValidatePrice(Pricing pricing)
        {
            return pricing.Price >= 0 && pricing.Price <= PricingLimits.MAX_PRICE;
        }

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
                        query = query.OrderBy(s => s.CreatedAt);
                        break;
                    case "TimeCreated":
                        query = query.OrderBy(s => s.CreatedAt.TimeOfDay);
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
                        query = query.OrderByDescending(s => s.CreatedAt);
                        break;
                    case "TimeCreated":
                        query = query.OrderByDescending(s => s.CreatedAt.TimeOfDay);
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
