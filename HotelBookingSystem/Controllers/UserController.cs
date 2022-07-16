using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HBS.ServiceLayer;
using HBS.DomainlLayer.Models;

namespace HotelBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly InterfaceHotelService HotelServices;

        public UserController(InterfaceHotelService HotelServices)
        {
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
                return BadRequest("Not found");
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
                return BadRequest("Not found");
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
                return BadRequest("Not found");
            }

            return BadRequest("Not found");
        }





    }
}
