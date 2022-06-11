using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travelland.Domain.DomainModels;
using Travelland.Domain.DTO;
using Travelland.Repository.Interface;
using Travelland.Services.Interface;

namespace Travelland.Services.Implementation
{
    public class UserReservationsService : IUserReservationsService
    {
        private readonly IRepository<UserReservations> _userReservationsRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IRepository<Reservation> _reservationsRepository;
        private readonly IRepository<OfferInReservation> _offerInReservationRepository;
        private readonly IRepository<EmailMessage> _mailRepository;
        public UserReservationsService(IRepository<UserReservations> userReservationsRepository, IClientRepository clientRepository, IRepository<Reservation> reservationsRepository, IRepository<OfferInReservation> offerInReservationRepository, IRepository<EmailMessage> mailRepository)
        {
            _userReservationsRepository = userReservationsRepository;
            _clientRepository = clientRepository;
            _reservationsRepository = reservationsRepository;
            _offerInReservationRepository = offerInReservationRepository;
            _mailRepository = mailRepository;
        }

        public void deleteOfferFromUserReservations(string clientId, Guid id)
        {

            var loggedInClient = this._clientRepository.Get(clientId);

            var clientReservations = loggedInClient.UserReservations;

            var offerToDelete = clientReservations.OfferInUserReservations.Where(z => z.id == id).FirstOrDefault();

            clientReservations.OfferInUserReservations.Remove(offerToDelete);

            this._userReservationsRepository.Update(clientReservations);
        }

        public UserReservationsDto getUserReservationsInfo(string clientId)
        {
            var loggedInClient = this._clientRepository.Get(clientId);

            var clientReservations = loggedInClient.UserReservations;

            var offerPrice = clientReservations.OfferInUserReservations.Select(z => new
            {
                OfferPrice = z.Offer.OfferPrice,
                Quantity = z.Quantity
            }).ToList();

            double totalPrice = 0;
            foreach (var item in offerPrice)
            {
                totalPrice += item.OfferPrice * item.Quantity;
            }

            UserReservationsDto userReservationsDtoItem = new UserReservationsDto
            {
                OfferInUserReservations = clientReservations.OfferInUserReservations.ToList(),
                TotalPrice = totalPrice
            };
            return userReservationsDtoItem;
        }

        public bool reserveNow(string clientId)
        {
            var loggedInClient = this._clientRepository.Get(clientId);
            var clientReservation = loggedInClient.UserReservations;

            EmailMessage mail = new EmailMessage();
            mail.MailTo = loggedInClient.Email;
            mail.Subject = "Successfully created order";
            mail.Status = false;

            Reservation reservationItem = new Reservation
            {
                id = Guid.NewGuid(),
                ClientId = clientId,
                Client = loggedInClient
            };

            this._reservationsRepository.Insert(reservationItem);

            List<OfferInReservation> offerInReservations = new List<OfferInReservation>();

            var result = clientReservation.OfferInUserReservations.Select(z => new OfferInReservation
            {
               
                id = z.Offer.id,
                SelectedOffer = z.Offer,
                ReservationId = reservationItem.id,
                ClientReservation = reservationItem
            }).ToList();

            StringBuilder sb = new StringBuilder();

            var totalPrice = 0;

            sb.AppendLine("Your reservation is completed. The reservation contains: ");

            for (int i = 1; i <= result.Count(); i++)
            {
                var item = result[i - 1];

                totalPrice += item.Quantity * item.SelectedOffer.OfferPrice;

                sb.AppendLine(i.ToString() + ". " + item.SelectedOffer.OfferDestination + " with price of: " + item.SelectedOffer.OfferPrice + " and quantity of: " + item.Quantity);
            }

            sb.AppendLine("Total price: " + totalPrice.ToString());


            mail.Content = sb.ToString();


            offerInReservations.AddRange(result);

            foreach (var item in offerInReservations)
            {
                this._offerInReservationRepository.Insert(item);
            }

            loggedInClient.UserReservations.OfferInUserReservations.Clear();

            this._clientRepository.Update(loggedInClient);
            this._mailRepository.Insert(mail);

            return true;
        }
        }

}
