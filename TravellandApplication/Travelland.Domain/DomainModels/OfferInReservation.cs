using System;


namespace Travelland.Domain.DomainModels
{
    public class OfferInReservation : BaseEntity
    {
        public Guid id { get; set; }
        public Offer SelectedOffer { get; set; }
        public Guid ReservationId { get; set; }
        public Reservation ClientReservation { get; set; }

        public int Quantity { get; set; }

    }
}
