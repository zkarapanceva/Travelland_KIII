using System.Collections.Generic;
using Travelland.Domain.DomainModels;

namespace Travelland.Domain.DTO
{
    public class UserReservationsDto
    {
        public List<OfferInUserReservations> OfferInUserReservations { get; set; }
        public double TotalPrice { get; set; }

    }
}
