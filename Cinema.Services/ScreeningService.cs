using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.Models.Requests.Screenings;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class ScreeningService : ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>, IScreeningService
    {
        protected readonly IMovieRepository _movieRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ScreeningService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _movieRepo = unit.Movies;
        }

        public Task<ScreeningDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<ScreeningDto>> GetPagedAsync(ScreeningSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<ScreeningDto> InsertAsync(ScreeningUpsertRequest req)
        {
            throw new NotImplementedException();
        }

        public Task<ScreeningDto> UpdateAsync(int id, ScreeningUpsertRequest req)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
