using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Reviews;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ReviewService : IReviewService
    {
        protected readonly IReviewRepository _reviewRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;
        public ReviewService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _reviewRepo = unit.Reviews;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _reviewRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }

        public Task<ReviewDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<ReviewDto>> GetPagedAsync(ReviewSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public async Task<ReviewDto> InsertAsync(ReviewUpsertRequest req)
        {
            var review = _mapper.Map<Review>(req);

            await _reviewRepo.InsertAsync(review);
            await _unit.SaveAsync();

            var dto = _mapper.Map<ReviewDto>(review);
            return dto;
        }

        public Task<ReviewDto> UpdateAsync(int id, ReviewUpsertRequest req)
        {
            throw new NotImplementedException();
        }

        public bool UserCanVote(int userid, int movieid)
        {
            return _reviewRepo.UserCanVote(userid, movieid);
        }
    }
}
