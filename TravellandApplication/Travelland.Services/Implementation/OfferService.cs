using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Travelland.Domain.DomainModels;
using Travelland.Domain.DTO;
using Travelland.Repository.Interface;
using Travelland.Services.Interface;

namespace Travelland.Services.Implementation
{
    public class OfferService : IOfferService
    {

        private readonly IRepository<Offer> _offerRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IRepository<OfferInUserReservations> _offerInUserReservationsRepository;
        private readonly ILogger<OfferService> _logger;

        public OfferService(IRepository<Offer> offerRepository, IClientRepository clientRepository, IRepository<OfferInUserReservations> offerInUserReservationsRepository, ILogger<OfferService> logger)
        {
            _offerRepository = offerRepository;
            _clientRepository = clientRepository;
            _offerInUserReservationsRepository = offerInUserReservationsRepository;
            _logger = logger;
        }

        public bool AddToUserReservations(AddOfferToReservationsDto item, string clientId)
        {
            var client = this._clientRepository.Get(clientId);
            var UserReservations = client.UserReservations;
            if (item.id != null && UserReservations != null)
            {
                var offer = this.GetDetailsForOffer(item.id);

                if (offer != null)
                {
                    OfferInUserReservations itemToAdd = new OfferInUserReservations
                    {
                        id = Guid.NewGuid(),
                        Offer = offer,
                        UserReservations = UserReservations,
                        UserReservationsId = UserReservations.ReservationsId,
                        Quantity = item.Quantity
                    };
                    this._offerInUserReservationsRepository.Insert(itemToAdd);
                    _logger.LogInformation("Offer was successfully added to Reservations!");
                    return true;
                }
                return false;
            }
            _logger.LogInformation("Error occured! OfferId or UserReservations may be unavailable.");
            return false;
        }

        public void CreateNewOffer(Offer o)
        {
            //o.id = Guid.NewGuid();
            this._offerRepository.Insert(o);
        }

        public void DeleteOffer(Guid id)
        {
            var offer = this.GetDetailsForOffer(id);
            this._offerRepository.Delete(offer);
        }

        public List<Offer> GetAllOffers()
        {
            _logger.LogInformation("GetAllOffers executing..");
            return this._offerRepository.GetAll().ToList();
        }

        public Offer GetDetailsForOffer(Guid? id)
        {
            return this._offerRepository.Get(id);
        }

        public AddOfferToReservationsDto GetUserReservationsInfo(Guid? id)
        {
            var offer = this.GetDetailsForOffer(id);
            AddOfferToReservationsDto model = new AddOfferToReservationsDto
            {
                SelectedOffer = offer,
                id = offer.id,
                Quantity = 1
            };
            return model;

        }

        public void UpdeteExistingOffer(Offer o)
        {
            this._offerRepository.Update(o);
        }
    }
}
