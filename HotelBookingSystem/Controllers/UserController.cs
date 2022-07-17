using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBS.ServiceLayer;
using HBS.DomainlLayer.Models;
using Microsoft.Extensions.Logging;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly InterfaceHotelService HotelServices;
        private readonly ILogger<UserController> _logger;

        public UserController(InterfaceHotelService HotelServices , ILogger<UserController> logger)
        {
            _logger = logger;
            _logger.LogInformation("User Added");
            this.HotelServices = HotelServices;
        }

        [HttpPost(nameof(RegisterNewUser))]
        public ActionResult RegisterNewUser(User user)
        {
            try
            {
                HotelServices.RegisterNewUser(user);

                return Ok("User Registered");
            }
            catch (Exception e)
            {
                _logger.LogError("Exception Occured", e.InnerException);
            }
            return BadRequest("Not found");

        }

        [HttpPost(nameof(AddBookingRequest))]
        public ActionResult AddBookingRequest(BookingRequest booking)
        {
            try
            {
                HotelServices.AddBookingRequest(booking);

                return Ok("Booking Request has been made");
            }
            catch (Exception e)
            {
                _logger.LogError("Exception Occured", e.InnerException);
            }
            return BadRequest("Not found");

        }


        [HttpGet(nameof(RoomList))]
        public ActionResult RoomList()
        {
            try
            {
                var RoomDetails = HotelServices.RoomList();
                if (RoomDetails != null)
                {
                    return Ok(RoomDetails);
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Exception Occured", e.InnerException);
            }

            return BadRequest("Not found");
        }
        [HttpGet(nameof(HotelList))]
        public ActionResult HotelList()
        {
            try
            {
                var Hotel = HotelServices.HotelList();
                if (Hotel != null)
                {
                    return Ok(Hotel);
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Exception Occured", e.InnerException);
            }

            return BadRequest("Not found");
        }





    }
}
