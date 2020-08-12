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
        protected readonly IScreeningRepository _screeningRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;

        public ScreeningService(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
            _screeningRepo = unit.Screenings;
        }

        public Task<ScreeningDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IPagedList<ScreeningDto>> GetPagedAsync(ScreeningSearchRequest search)
        {
            var list = await _screeningRepo.GetPagedAsync(search, search.SearchTerm, search.Date);
            var dtoList = PagedList<ScreeningDto>.Map<Screening>(_mapper, list);

            return dtoList;
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

        /*
        private bool ValidateScreeningDate(Screening screening)
        {
            return screening.DateAndTime >= DateTime.UtcNow;
        }

        private async Task<bool> ValidateScreeningHallAvailabilityAsync(Screening validatedScreening)
        {
            Hall hall = await _context.Halls.FindAsync(validatedScreening.HallId);
            Movie movie = await _context.Movies.FindAsync(validatedScreening.MovieId);

            if (hall == null || movie == null) return false;

            DateTime validatedStartTime = validatedScreening.DateAndTime;
            DateTime validatedEndTime = validatedScreening.DateAndTime.AddMinutes(movie.Duration);

            var hallScreenings = hall.Screenings.Where(x => x.DateAndTime.Date == validatedStartTime.Date).ToList();

            foreach (var screening in hallScreenings)
            {
                DateTime startTime = screening.DateAndTime;
                DateTime endTime = screening.DateAndTime.AddMinutes(screening.Movie.Duration);

                if (validatedStartTime >= startTime && validatedStartTime <= endTime) return false;
                if (validatedEndTime >= startTime && validatedEndTime <= endTime) return false;
            }

            return true;
        }*/
    }
}
