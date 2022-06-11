using System;

namespace TravellandAdminApplication.Models
{
    public class Offer
    {
        public Guid id { get; set; }
        public string OfferDestination { get; set; }
        public string OfferImage { get; set; }
        public string OfferDescription { get; set; }
        public int OfferPrice { get; set; }
        public int OfferRecommendation { get; set; }
    }
}
