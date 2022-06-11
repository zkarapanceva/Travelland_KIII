using System;


namespace Travelland.Domain.DomainModels
{
    public class OfferInUserReservations : BaseEntity
    {
        public Guid id { get; set; }
        public Guid UserReservationsId { get; set; }
        public Offer Offer { get; set; }
        public UserReservations UserReservations { get; set; }
        public int Quantity { get; set; }
    }
}
