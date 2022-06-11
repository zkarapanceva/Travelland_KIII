using System;
using Travelland.Domain.DomainModels;

namespace Travelland.Domain.DTO
{
    public class AddOfferToReservationsDto
    {
        public Offer SelectedOffer{ get; set; }
        public Guid id { get; set; }
        public int Quantity { get; set; }

    }
}
