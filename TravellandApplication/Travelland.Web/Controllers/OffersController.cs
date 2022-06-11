using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Travelland.Domain.DomainModels;
using Travelland.Domain.DTO;
using Travelland.Repository.Interface;
using Travelland.Services.Interface;

namespace Travelland.Web.Controllers
{
    public class OffersController : Controller
    {
        private readonly IOfferService _offerService;
        //private readonly IClientRepository _clientRepository;

        public OffersController(IOfferService offerService)//, IClientRepository clientRepository)
        {
            _offerService = offerService;
            //_clientRepository = clientRepository;
        }

        // GET: Offers
        public IActionResult Index()
        {
            var allOffers = this._offerService.GetAllOffers();
            return View(allOffers);
        }

        public IActionResult AddOfferToReservations(Guid? id)
        {
            var model = this._offerService.GetUserReservationsInfo(id);
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOfferToReservations([Bind("id", "Quantity")] AddOfferToReservationsDto item)
        {
            var clientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this._offerService.AddToUserReservations(item, clientId);

            if(result)
                return RedirectToAction("Index", "Offers");

            return View(item);
        }


        // GET: Offers/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = this._offerService.GetDetailsForOffer(id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,OfferDestination,OfferImage,OfferDescription,OfferPrice,OfferRecommendation")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                //offer.id = Guid.NewGuid();
                this._offerService.CreateNewOffer(offer);
                return RedirectToAction(nameof(Index));
            }
            return View(offer);
        }

        // GET: Offers/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = this._offerService.GetDetailsForOffer(id);
            if (offer == null)
            {
                return NotFound();
            }
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("id,OfferDestination,OfferImage,OfferDescription,OfferPrice,OfferRecommendation")] Offer offer)
        {
            if (id != offer.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._offerService.UpdeteExistingOffer(offer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferExists(offer.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(offer);
        }

        // GET: Offers/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = this._offerService.GetDetailsForOffer(id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._offerService.DeleteOffer(id);
            return RedirectToAction(nameof(Index));
        }

        private bool OfferExists(Guid id)
        {
            return this._offerService.GetDetailsForOffer(id) != null;
        }
    }
}
