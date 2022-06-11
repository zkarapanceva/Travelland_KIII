using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DomainModels;
using Travelland.Repository.Interface;
using Travelland.Services.Interface;

namespace Travelland.Services.Implementation
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }
        public List<Reservation> GetAllReservations()
        {
            return _reservationRepository.GetAllReservations();
        }

        public Reservation GetReservationDetails(BaseEntity model)
        {
            return _reservationRepository.GetReservationDetails(model);
        }
    }
}
