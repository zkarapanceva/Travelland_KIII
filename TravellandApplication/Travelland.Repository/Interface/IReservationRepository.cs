using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DomainModels;

namespace Travelland.Repository.Interface
{
    public interface IReservationRepository
    {
        List<Reservation> GetAllReservations();
        Reservation GetReservationDetails(BaseEntity model);
    }
}
