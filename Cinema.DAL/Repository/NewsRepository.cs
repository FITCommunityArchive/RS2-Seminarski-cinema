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
    public class NewsRepository : Repository<News, int>, INewsRepository
    {
        public NewsRepository(ICinemaDbContext context) : base(context) { }

        public async Task<IPagedList<News>> GetPagedAsync(ISearchRequest searchRequest, string title, string author, int? typeId)
        {
            var query = _dbSet.AsQueryable();

            if (!searchRequest.ReturnAll)
            {
                query = ApplyFilter(query, title, author, typeId);
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

        private IQueryable<News> ApplyFilter(IQueryable<News> query, string title, string author, int? typeId)
        {
            if (!string.IsNullOrEmpty(title))
            {
                title = title.ToLower();

                query = query.Where(x => x.Title.ToLower().StartsWith(title));
            }

            if (!string.IsNullOrEmpty(author))
            {
                author = author.ToLower();
                query = query.Where(x => (x.Author.FirstName + ' ' + x.Author.LastName).ToLower().StartsWith(author));
            }

            if (typeId.HasValue)
            {
                query = query.Where(x => x.TypeId == typeId);
            }

            return query;
        }

        protected override Expression<Func<News, bool>> GetByIdExpression(int id)
        {
            return x => x.Id == id;
        }

        protected override IQueryable<News> ApplySorting(IQueryable<News> query, ISearchRequest searchRequest)
        {
            Expression<Func<News, object>> expression = GetSortExpression(searchRequest);

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

        protected override Expression<Func<News, object>> GetSortExpression(ISearchRequest searchRequest)
        {
            switch (searchRequest.SortColumn)
            {
                case nameof(News.Title):
                    return x => x.Title;
                case nameof(News.Author):
                    return x => x.Author.FirstName + ' ' + x.Author.LastName;
                case nameof(News.Type):
                    return x => x.Type.Name;
                default:
                    return x => x.Id;
            }
        }

    }
}
