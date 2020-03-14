using System.Collections.Generic;

namespace Cinema.Domain.Entities
{
    public class User : BaseClass
    {
        public User()
        {
            Reviews = new List<Review>();
            Reservations = new List<Reservation>();
            News = new List<News>();
            Events = new List<Event>();
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string FullName { get { return ($"{ FirstName } { LastName }"); } }
        public string EmailAddress { get; set; }
        public virtual AppRole Role { get; set; }
        public virtual IList<Review> Reviews { get; set; }
        //Both invoices and reservations will be here - due to polymorphism - Invoice inherits Reservation
        public virtual IList<Reservation> Reservations { get; set; }
        public virtual IList<News> News { get; set; }
        public virtual IList<Event> Events { get; set; }

    }
}