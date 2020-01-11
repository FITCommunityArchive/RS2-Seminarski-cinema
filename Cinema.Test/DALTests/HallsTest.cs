using Cinema.Domain.Entities;
using Cinema.Web.Pages.Halles;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    public class HallsTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllHalls()
        {
            //Arrange
            int hallsCount = unit.Halls.Get().Count();
                                             
            //Act

            //Assert
            //There are 2 halls in the test database
             Assert.AreEqual(2, hallsCount);

            /*
            IndexModel indexModel = new IndexModel(context);

            await indexModel.OnGetAsync();
            var result = indexModel.Hall;

            Assert.AreEqual(2, result.Count);*/
        }

        [Test, Order(2)]
        [TestCase(2)]
        public void GetHallById(int id)
        {
            //Try to get Hall with id
            Hall hall = unit.Halls.Get(id);       

            Assert.AreEqual("Movie Hall 2", hall.Name);            
        }


        [Test, Order(3)]
        [TestCase(5)]
        public void GetNonExistingHall(int id)
        {
            //Try to get non-existing Hall

            var ex = Assert.Throws<ArgumentException>(() => unit.Halls.Get(id));

            Assert.AreEqual(ex.Message, $"There is no object with id: {id} in the database");
        }

        [Test, Order(4)]
        public void InsertHall()
        {
            Hall hall = new Hall
            {
                Name = "New Hall"
            };

            unit.Halls.Insert(hall);
            unit.Save();

            //id of the new hall will be 3
            Hall newHall = unit.Halls.Get(3);

            Assert.AreEqual("New Hall", newHall.Name);
        }

        [Test, Order(5)]
        public void ChangeHallName()
        {
            //Try to change the hall 
            int id = 2;

            Hall hall = unit.Halls.Get(id);
            hall.Name = "New Hall";

            unit.Halls.Update(hall, id);
            unit.Save();

            Assert.AreEqual("New Hall", hall.Name);
        }

        [Test, Order(6)]
        public void DeleteHall()
        {
            //Try to delete the hall 
            int id = 2;

            Hall hall = unit.Halls.Get(id); 
            
            unit.Halls.Delete(hall);

            Hall hallAfterDelete = unit.Halls.Get(id);

            Assert.AreEqual(true, hallAfterDelete.Deleted);
        }

        /*
        [Test, Order(7)]
        public void DeleteHall()
        {
            //Try to delete the hall 
            int id = 2;

            Hall hall = unit.Halls.Get(id);

            //First delete all screenings and all child entities of each screening
            var screenings = context.Screenings.Where(x => x.Hall.Id == hall.Id);

            foreach(Screening screening in screenings)
            {
                var reservations = context.Reservations.Where(x => x.Screening.Id == screening.Id);

                foreach(Reservation reservation in reservations)
                {
                    var invoices = context.Invoices.Where(x => x.Reservation.Id == reservation.Id);
                    context.Invoices.RemoveRange(invoices);

                    var seatReservations = context.SeatReservations.Where(x => x.Reservation.Id == reservation.Id);
                    context.SeatReservations.RemoveRange(seatReservations);
                }
                
                context.Reservations.RemoveRange(reservations);
            }
            
            context.Screenings.RemoveRange(screenings);
            unit.Save();

            //Delete all seats and all child entities of each seat
            var seats = context.Seats.Where(x => x.Hall.Id == hall.Id);
            foreach(Seat seat in seats)
            {
                var seatReservations = context.SeatReservations.Where(x => x.Seat.Id == seat.Id);
                context.SeatReservations.RemoveRange(seatReservations);
            }

            context.Seats.RemoveRange(seats);
            unit.Save();        

            context.Halls.Remove(hall);
            unit.Save();

            Hall hallAfterDelete = unit.Halls.Get(id);            
            Assert.IsNull(hallAfterDelete);
        }*/
    }
}
