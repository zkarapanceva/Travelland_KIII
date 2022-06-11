using System;

namespace TravellandAdminApplication.Models
{
    public class OfferInReservation
    {
        public Guid id { get; set; }
        public Offer SelectedOffer { get; set; }
        public Guid ReservationId { get; set; }
        public Reservation ClientReservation { get; set; }
        public int Quantity { get; set; }
    }
}
