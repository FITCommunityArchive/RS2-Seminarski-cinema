using Cinema.Domain.Entities;
using Cinema.Services.Exceptions;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    public class ScreeningsTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllScreenings()
        {
            //Arrange
            int screeningsCount = unit.Screenings.Get().Count();

            //Act

            //Assert
            //There are 42 screenings in the test database
            Assert.AreEqual(42, screeningsCount);
        }

        [Test, Order(2)]
        public async Task InsertScreening()
        {
            Screening screening = new Screening
            {
                Movie = await unit.Movies.GetAsync(1),
                Hall = await unit.Halls.GetAsync(1),
                Pricing = await unit.Pricings.GetAsync(1)
            };

            Movie movie = await unit.Movies.GetAsync(1);

            await unit.Screenings.InsertAsync(screening);
            await unit.SaveAsync();

            //Id of the new screening will be 43
            Screening newScreening = await unit.Screenings.GetAsync(43);

            Assert.AreEqual(movie.Title, newScreening.Movie.Title);
        }

        [Test, Order(3)]
        [TestCase(13)]
        public async Task GetScreeningById(int id)
        {
            //Try to get Screening with id
            Screening screening = await unit.Screenings.GetAsync(id);

            Assert.NotNull(screening);
            Assert.NotNull(screening.Movie.Title);
        }

        [Test, Order(4)]
        [TestCase(100)]
        public async Task GetNonExistingScreening(int id)
        {
            //Try to get non-existing Screening
            Screening screening = await unit.Screenings.GetAsync(id);

            Assert.IsNull(screening);
        }

        [Test, Order(5)]
        public async Task ChangeScreeningMovie()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = await unit.Screenings.GetAsync(id);
            Movie newMovie = await unit.Movies.GetAsync(3);
            Pricing pricing = await unit.Pricings.GetAsync(2);

            Screening updatedScreening = new Screening
            {
                Id = screening.Id,
                MovieId = newMovie.Id,
                HallId = screening.HallId,
                PricingId = pricing.Id,
                Reservations = screening.Reservations
            };

            await unit.Screenings.UpdateAsync(updatedScreening, id);
            unit.Save();

            Screening newScreening = await unit.Screenings.GetAsync(id);

            Assert.AreEqual(newMovie.Title, newScreening.Movie.Title);
            Assert.AreEqual(pricing.Id, newScreening.PricingId);
        }

        [Test, Order(6)]
        public void DeleteScreeningWithChildObjects()
        {
            //Try to delete the screening 
            int id = 39;
            var ex = Assert.ThrowsAsync<DependentObjectsPresentException>(async () => await unit.Screenings.DeleteAsync(id));
        }

        [Test, Order(7)]
        public async Task DeleteScreeningWithoutChildObjects()
        {
            Screening screening = new Screening
            {
                HallId = 1,
                MovieId = 1,
                PricingId = 1
            };

            await unit.Screenings.InsertAsync(screening);
            await unit.SaveAsync();
            int screeningId = screening.Id;

            await unit.Screenings.DeleteAsync(screeningId);
            await unit.SaveAsync();

            Screening deletedScreening = await unit.Screenings.GetAsync(screeningId);

            Assert.True(deletedScreening.Deleted);
        }
    }
}
