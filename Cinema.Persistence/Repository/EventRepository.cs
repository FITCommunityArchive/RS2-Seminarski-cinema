using Cinema.Common.Interfaces.Dal;
using Cinema.Domain.Entities;
using Cinema.Shared.Enums;
using Cinema.Shared.Pagination;
using Cinema.Shared.Search;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cinema.Persistence.Repository
{
    public class EventRepository : Repository<Event, int>, IEventRepository
    {
        public EventRepository(ICinemaDbContext context) : base(context) { }

        public async Task<IPagedList<Event>> GetPagedAsync(ISearchRequest searchRequest, string title, string author, string promoter, int? typeId, DateTime? eventDate)
        {
            var query = _dbSet.AsQueryable();

            if (!searchRequest.ReturnAll)
            {
                query = ApplyFilter(query, title, author, promoter, typeId, eventDate);
            }

            if (searchRequest.SortOrder != null && searchRequest.SortColumn != null)
            {
                query = ApplySorting(query, searchRequest);
            }

            if (searchRequest.Includes.Count() > 0)
            {
                query = AddIncludes(query, searchRequest.Includes);
            }

            var pagedList = await ApplyPaginationAsync(query, searchRequest.PageIndex, searchRequest.PageSize, searchRequest.ReturnAll);
            return pagedList;
        }

        private IQueryable<Event> ApplyFilter(IQueryable<Event> query, string title, string author, string promoter, int? typeId, DateTime? eventDate)
        {
            if (!string.IsNullOrEmpty(title))
            {
                title = title.ToLower();

                query = query.Where(x => x.Title.ToLower().StartsWith(title));
            }

            if (eventDate.HasValue)
            {
                query = query.Where(x => x.DateAndTime.Date == eventDate.Value.Date);
            }

            if (!string.IsNullOrEmpty(author))
            {
                author = author.ToLower();
                query = query.Where(x => (x.Author.FirstName + ' ' + x.Author.LastName).ToLower().StartsWith(author));
            }

            if (!string.IsNullOrEmpty(promoter))
            {
                promoter = promoter.ToLower();
                query = query.Where(x => x.Promoter.ToLower().StartsWith(promoter));
            }

            if (typeId.HasValue)
            {
                query = query.Where(x => x.TypeId == typeId);
            }

            return query;
        }

        protected override Expression<Func<Event, bool>> GetByIdExpression(int id)
        {
            return x => x.Id == id;
        }

        protected override IQueryable<Event> ApplySorting(IQueryable<Event> query, ISearchRequest searchRequest)
        {
            Expression<Func<Event, object>> expression = GetSortExpression(searchRequest);

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

        protected override Expression<Func<Event, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            switch (searchRequest.SortColumn)
            {
                case nameof(Event.Title):
                    return x => x.Title;
                case nameof(Event.Description):
                    return x => x.Description;
                case nameof(Event.Author):
                    return x => x.Author.FirstName + ' ' + x.Author.LastName;
                case nameof(Event.Type):
                    return x => x.Type.Name;
                case nameof(Event.DateAndTime):
                    return x => x.DateAndTime;
                case nameof(Event.Promoter):
                    return x => x.Promoter;
                default:
                    return x => x.Id;
            }
        }
    }
}
