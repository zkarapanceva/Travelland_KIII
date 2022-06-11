using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Travelland.Domain.DomainModels;
using Travelland.Domain.DTO;
using Travelland.Domain.Identity;
using Travelland.Repository;
using Travelland.Services.Interface;

namespace Travelland.Web.Controllers
{
    public class UserReservationsController : Controller
    {

        private readonly IUserReservationsService _userReservationsService;


        public UserReservationsController(IUserReservationsService userReservationsService)
        {
            _userReservationsService = userReservationsService;
        }
        public IActionResult Index()
        {
            var clientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            

            return View(this._userReservationsService.getUserReservationsInfo(clientId));
        }

        public IActionResult PayOrder(string stripeEmail, string stripeToken)
        {
            var customerService = new CustomerService();
            var chargeService = new ChargeService();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var order = this._userReservationsService.getUserReservationsInfo(userId);

            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = (Convert.ToInt32(order.TotalPrice) * 100),
                Description = "Travelland Application Payment",
                Currency = "eur",
                Customer = customer.Id
            });

            if (charge.Status == "succeeded")
            {
                var result = this.ReserveNow();

                if (result)
                {
                    return RedirectToAction("Index", "UserReservations");
                }
                else
                {
                    return RedirectToAction("Index", "UserReservations");
                }
            }

            return RedirectToAction("Index", "UserReservations");
        }

        public IActionResult DeleteOfferFromReservations(Guid id)
        {
            var clientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            this._userReservationsService.deleteOfferFromUserReservations(clientId, id);

            return RedirectToAction("Index", "UserReservations");

        }

        public Boolean ReserveNow()
        {

            var clientId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this._userReservationsService.reserveNow(clientId);

            return result;

        }


    }
}
