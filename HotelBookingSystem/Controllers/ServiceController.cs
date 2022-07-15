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
    public class ServiceController : ControllerBase
    {
        private readonly InterfaceHotelService HotelServices;

        public ServiceController(InterfaceHotelService HotelServices)
        {
            this.HotelServices = HotelServices;
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
                return BadRequest("Not found");
            }

            return BadRequest("Not found");
        }


        [HttpPut(nameof(UpdateHotel))]
        public ActionResult UpdateHotel(Hotel hotel)
        {
            try
            {
                HotelServices.UpdateHotel(hotel);

                return Ok("Hotel Updated");
            }
            catch (Exception e)
            {
                return BadRequest("Not found");
            }
            return BadRequest("Not found");

        }

        [HttpPut(nameof(DeleteHotel))]
        public ActionResult DeleteHotel(int hotel_id)
        {
            try
            {
                HotelServices.DeleteHotel(hotel_id);

                return Ok("Hotel Deleted");

            }
            catch (Exception e)
            {
                return BadRequest("Not found");
            }
            return BadRequest("Not found");
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

    }
}
