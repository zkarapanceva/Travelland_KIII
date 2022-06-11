using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Travelland.Domain.DomainModels
{
    public class Offer : BaseEntity
    {
        
        //public Guid id { get; set; }
        [Required]
        public string OfferDestination { get; set; }
        [Required]
        public string OfferImage { get; set; }
        [Required]
        public string OfferDescription { get; set; }
        [Required]
        public int OfferPrice { get; set; }
        [Required] 
        public int OfferRecommendation { get; set; }
        public virtual ICollection<OfferInUserReservations> UserReservations{ get; set; }
        public virtual ICollection<OfferInReservation> Reservations { get; set; }
        public Offer() { }
    }
}
