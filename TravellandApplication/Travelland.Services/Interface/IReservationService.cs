using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DomainModels;

namespace Travelland.Services.Interface
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservationDetails(BaseEntity model);
    }
}
