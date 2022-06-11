using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Travelland.Domain.Identity;



namespace Travelland.Domain.DomainModels
{
    public class UserReservations : BaseEntity
    {
        
        public Guid ReservationsId { get; set; }
        public string ClientId { get; set; }
        public TravellandApplicationUser Client { get; set; }
        public virtual ICollection<OfferInUserReservations> OfferInUserReservations { get; set;}
    }
}
