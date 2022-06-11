using System;
using System.Collections.Generic;
using System.Text;
using Travelland.Domain.Identity;

namespace Travelland.Repository.Interface
{
    public interface IClientRepository
    {
        IEnumerable<TravellandApplicationUser> GetAll();
        TravellandApplicationUser Get(string id);
        void Insert(TravellandApplicationUser entity);
        void Update(TravellandApplicationUser entity);
        void Delete(TravellandApplicationUser entity);
    }
}
