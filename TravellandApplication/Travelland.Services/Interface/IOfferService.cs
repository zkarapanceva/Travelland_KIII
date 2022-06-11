using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DomainModels;
using Travelland.Domain.DTO;

namespace Travelland.Services.Interface
{
    public interface IOfferService
    {
        List<Offer> GetAllOffers();
        Offer GetDetailsForOffer(Guid? id);
        void CreateNewOffer(Offer o);
        void UpdeteExistingOffer(Offer o);
        AddOfferToReservationsDto GetUserReservationsInfo(Guid? id);
        void DeleteOffer(Guid id);
        bool AddToUserReservations(AddOfferToReservationsDto item, string userID);
    }
}
