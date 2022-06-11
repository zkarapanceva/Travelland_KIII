using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DTO;

namespace Travelland.Services.Interface
{
    public interface IUserReservationsService
    {
        UserReservationsDto getUserReservationsInfo(string clientId);
        void deleteOfferFromUserReservations(string clientId, Guid id);
        bool reserveNow(string clientId);
    }
}
