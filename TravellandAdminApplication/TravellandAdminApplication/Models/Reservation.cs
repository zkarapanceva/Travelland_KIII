using System;
using System.Collections.Generic;

namespace TravellandAdminApplication.Models
{
    public class Reservation
    {
        public Guid id { get; set; }
        public string ClientId { get; set; }
        public TravellandApplicationUser Client { get; set; }
        public ICollection<OfferInReservation> Offers { get; set; }
    }
}
