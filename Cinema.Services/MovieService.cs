using AutoMapper;
using Cinema.Domain.Entities;
using Cinema.Models.Dtos;
using Cinema.Models.Requests.Movies;
using Cinema.MovieRecommenderService;
using Cinema.Shared.Pagination;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Services;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class MovieService : IMovieService
    {
        protected readonly IMovieRepository _movieRepo;
        protected readonly IScreeningRepository _screeningRepo;
        protected readonly IRepository<GenreMovie, int> _genreMovieRepo;
        protected readonly IRepository<Review, int> _reviewsRepo;
        protected readonly IUnitOfWork _unit;
        protected readonly IMapper _mapper;
        protected readonly IMovieRecommender _movieRecommender;

        public MovieService(IUnitOfWork unit, IMapper mapper, IMovieRecommender movieRecommender)
        {
            _unit = unit;
            _mapper = mapper;
            _movieRepo = unit.Movies;
            _screeningRepo = unit.Screenings;
            _genreMovieRepo = unit.Repository<GenreMovie, int>();
            _movieRecommender = movieRecommender;
        }

        public async Task<MovieDto> GetByIdAsync(int id, ICollection<string> includes = null)
        {
            var entity = await _movieRepo.GetByIdWithGenresAsync(id);
            return _mapper.Map<MovieDto>(entity);
        }

        public async Task<IPagedList<MovieDto>> GetPagedAsync(MovieSearchRequest search)
        {
            var list = await _movieRepo.GetPagedAsync(search, search.SearchTerm, search.Year, search.Duration);
            var dtoList = PagedList<MovieDto>.Map<Movie>(_mapper, list);

            return dtoList;
        }

        public async Task<List<MovieDto>> GetNowShowingAsync()
        {
            List<string> screeningIncludes = new List<string> { nameof(Screening.Movie) };
            var screenings = await _screeningRepo.GetAsync(x => x.DateAndTime >= DateTime.UtcNow, screeningIncludes);

            List<Movie> moviesList = screenings.Select(x => x.Movie).Distinct().ToList();

            List<MovieDto> dtoList = _mapper.Map<List<MovieDto>>(moviesList);
            return dtoList;
        }

        public async Task<List<MovieDto>> GetRecommendedAsync(int userId)
        {
            var movies = _movieRepo.Get();
            List<Movie> moviesList = new List<Movie>();
            foreach (var movie in movies)
            {
                var score = _movieRecommender.PredictScore(userId, movie.Id);
                if (Math.Round(score, 1) > 3.5)
                {
                    moviesList.Add(movie);
                }
            }
            //objListOrder.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));

            List<MovieDto> dtoList = _mapper.Map<List<MovieDto>>(moviesList);
            await Task.CompletedTask;
            return dtoList;
        }

        public async Task<MovieDto> InsertAsync(MovieUpsertRequest req)
        {
            var movie = _mapper.Map<Movie>(req);

            await _movieRepo.InsertAsync(movie);
            await InsertGenreMovies(req, movie);

            await _unit.SaveAsync();

            var dto = _mapper.Map<MovieDto>(movie);
            return dto;
        }

        private async Task InsertGenreMovies(MovieUpsertRequest req, Movie movie)
        {
            foreach (var genreId in req.Genres)
            {
                await _genreMovieRepo.InsertAsync(new GenreMovie
                {
                    GenreId = genreId,
                    Movie = movie
                });
            }
        }

        public async Task<MovieDto> UpdateAsync(int id, MovieUpsertRequest req)
        {
            Movie movie = _mapper.Map<Movie>(req);
            movie.Id = id;

            await _unit.Movies.UpdateAsync(movie, id);
            await UpdateGenreMovieAsync(id, req, movie);

            movie = await _movieRepo.GetByIdWithGenresAsync(id);

            await ClearGenreMoviesAsync(req, movie);
            await _unit.SaveAsync();

            var dto = _mapper.Map<MovieDto>(movie);
            return dto;
        }

        private async Task<bool> UpdateGenreMovieAsync(int id, MovieUpsertRequest req, Movie movie)
        {
            movie = await _unit.Movies.GetByIdWithGenresAsync(id);

            foreach (var genreId in req.Genres)
            {
                GenreMovie genreMovie = movie.GenreMovies.FirstOrDefault(x => x.GenreId == genreId);

                if (genreMovie == null)
                {
                    await _genreMovieRepo.InsertAsync(new GenreMovie
                    {
                        MovieId = id,
                        GenreId = genreId
                    });
                }
            }

            return true;
        }

        private async Task<bool> ClearGenreMoviesAsync(MovieUpsertRequest req, Movie movie)
        {
            List<GenreMovie> deletableGenreMovies = movie.GenreMovies.Where(x => !req.Genres.Contains(x.GenreId)).ToList();

            foreach (var deletableGenreMovie in deletableGenreMovies)
            {
                await _genreMovieRepo.DeleteAsync(deletableGenreMovie.Id);
            }

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await _movieRepo.DeleteAsync(id);
            await _unit.SaveAsync();

            return true;
        }

        public double GetMovieReviewScore(int id)
        {
            return _movieRepo.GetMovieReviewScore(id);
        }
    }
}
