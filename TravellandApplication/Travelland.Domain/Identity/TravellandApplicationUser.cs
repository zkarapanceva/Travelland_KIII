using System.Collections;
using System.Collections.Generic;
using Travelland.Domain.DomainModels;


namespace Travelland.Domain.Identity
{
    public class TravellandApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual UserReservations UserReservations { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
