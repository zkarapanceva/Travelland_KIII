using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Travelland.Domain.DomainModels;
using Travelland.Domain.Identity;
using Travelland.Services.Interface;

namespace Travelland.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly UserManager<TravellandApplicationUser> _userManager;


        public AdminController(IReservationService reservationService, UserManager<TravellandApplicationUser> userManager)
        {
            _reservationService = reservationService;
            _userManager = userManager;
        }

        [HttpGet("[action]")]
        public List<Reservation> GetAllActiveReservations()
        {
            return this._reservationService.GetAllReservations();
        }

        [HttpPost("[action]")]
        public Reservation GetDetailsForOffer(BaseEntity model)
        {
            return this._reservationService.GetReservationDetails(model);
        }

        [HttpPost("[action]")]
        public bool ImportAllUsers(List<UserRegistrationDto> model)
        {
            bool status = true;

            foreach (var item in model)
            {
                var userCheck = _userManager.FindByEmailAsync(item.Email).Result;

                if (userCheck == null)
                {
                    var user = new TravellandApplicationUser
                    {
                        UserName = item.Email,
                        NormalizedUserName = item.Email,
                        Email = item.Email,
                        EmailConfirmed = true,
                        PhoneNumberConfirmed = true,
                        UserReservations = new UserReservations()
                    };
                    var result = _userManager.CreateAsync(user, item.Password).Result;

                    status = status && result.Succeeded;
                }
                else
                {
                    continue;
                }
            }

            return status;
        } 
    }
}
