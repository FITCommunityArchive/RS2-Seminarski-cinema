using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using Cinema.Utilities.Interfaces.Dal;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Dal.Repository
{
    public class ReservationRepository : Repository<Reservation, int>, IReservationRepository
    {
        public ReservationRepository(ICinemaDbContext context) : base(context) { }
                
        public async Task<IPagedList<Reservation>> GetPagedAsync(ISearchRequest searchRequest, int? reservationId, int? customerId, decimal? price, DateTime? createdAt, ReservationStatus? status)
        {
            var query = _dbSet.AsQueryable();

            query = ApplyFilter(query, reservationId, customerId, price, createdAt, status);

            query = ApplySorting(query, searchRequest);

            if (searchRequest.Includes.Count() > 0)
            {
                query = AddIncludes(query, searchRequest.Includes);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize);
            return pagedList;
        }

        protected override Expression<Func<Reservation, bool>> GetByIdExpression(int id)
        {
            return x => x.Id == id;
        }

        private IQueryable<Reservation> ApplyFilter(IQueryable<Reservation> query, int? reservationId, int? customerId, decimal? price, DateTime? createdAt, ReservationStatus? status)
        {
            
            if (reservationId.HasValue)
            {
                query = query.Where(x => x.Id == reservationId.Value);
            }

            if (customerId.HasValue)
            {
                //TODO
                //query = query.Where(x => x.UserId == customerId.Value);
            }

            if (price.HasValue)
            {
                query = query.Where(x => x.Invoice.Price == price.Value);
            }

            if (createdAt.HasValue)
            {
                query = query.Where(x => x.CreatedAt.Date == createdAt.Value.Date);
            }

            if (status.HasValue)
            {
                switch (status.Value)
                {
                    case ReservationStatus.BOOKED:
                        query = query.Where(x => x.InvoiceId == null);
                        break;
                    case ReservationStatus.PAID:
                        query = query.Where(x => x.InvoiceId != null && !x.IsCancelled);
                        break;
                    case ReservationStatus.CANCELED:
                        query = query.Where(x => x.IsCancelled);
                        break;
                    default:
                        break;
                }
            }

            return query;
        }

        protected override IQueryable<Reservation> ApplySorting(IQueryable<Reservation> query, ISearchRequest searchRequest)
        {
            if (searchRequest.SortOrder == null || searchRequest.SortColumn == null)
            {
                searchRequest.SortOrder = SortOrder.DESC;
                searchRequest.SortColumn = nameof(Reservation.Id);
            }

            Expression<Func<Reservation, object>> expression = GetSortExpression(searchRequest);

            if (searchRequest.SortOrder == SortOrder.ASC)
            {
                query = query.OrderBy(expression);
            }
            else
            {
                query = query.OrderByDescending(expression);
            }

            return query;
        }

        protected override Expression<Func<Reservation, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            switch (searchRequest.SortColumn)
            {
                case nameof(Reservation.Id):
                    return x => x.Id;
                case nameof(Reservation.User.FullName):
                    return x => x.User.FullName;
                case nameof(Reservation.Invoice.Price):
                    return x => x.Invoice.Price;
                case nameof(Reservation.CreatedAt):
                    return x => x.CreatedAt;
                default:
                    return x => x.Id;
            }
        }
    }
}
