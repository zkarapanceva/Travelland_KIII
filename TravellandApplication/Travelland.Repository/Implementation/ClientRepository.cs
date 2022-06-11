using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travelland.Domain.Identity;
using Travelland.Repository.Interface;

namespace Travelland.Repository.Implementation
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<TravellandApplicationUser> entities;
        string errorMessage = string.Empty;

        public ClientRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<TravellandApplicationUser>();
        }
        public IEnumerable<TravellandApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public TravellandApplicationUser Get(string id)
        {
            return entities
                .Include(z => z.UserReservations)
                .Include("UserReservations.OfferInUserReservations")
                .Include("UserReservations.OfferInUserReservations.Offer")
                .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(TravellandApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(TravellandApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(TravellandApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
