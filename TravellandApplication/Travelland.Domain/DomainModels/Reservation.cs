using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Travelland.Domain.Identity;



namespace Travelland.Domain.DomainModels 
{
    public class Reservation : BaseEntity
    {
        //public Guid id { get; set; }
        public string ClientId { get; set; }
        public TravellandApplicationUser Client { get; set; }
        public virtual ICollection<OfferInReservation> Offers { get; set; }
    }
}
