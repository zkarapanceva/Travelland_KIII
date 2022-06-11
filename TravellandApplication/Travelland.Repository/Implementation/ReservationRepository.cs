using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.DomainModels;
using Travelland.Repository.Interface;

namespace Travelland.Repository.Implementation
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Reservation> entities;
        string errorMessage = string.Empty;

        public ReservationRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Reservation>();
        }
        public List<Reservation> GetAllReservations()
        {
            return entities
                .Include(z => z.Offers)
                .Include(z => z.Client)
                .Include("Offers.SelectedOffer")
                .ToListAsync().Result;
        }

        public Reservation GetReservationDetails(BaseEntity model)
        {
            return entities
               .Include(z => z.Client)
               .Include(z => z.Offers)
               .Include("Offers.SelectedOffer")
               .SingleOrDefaultAsync(z => z.id == model.id).Result;
        }
    }
}
