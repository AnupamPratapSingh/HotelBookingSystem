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
    public class AdminController : ControllerBase
    {
        private readonly InterfaceHotelService HotelServices;

        public AdminController(InterfaceHotelService HotelServices)
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


        [HttpGet(nameof(BookingRequestList))]
        public ActionResult BookingRequestList()
        {
            try
            {
                var BookingRequest = HotelServices.BookingRequestsList();
                if (BookingRequest != null)
                {
                    return Ok(BookingRequest);
                }
            }
            catch (Exception e)
            {
                return BadRequest("Not found");
            }

            return BadRequest("Not found");
        }

        [HttpPost(nameof(ApproveBooking))]
        public ActionResult ApproveBooking(BookingDetails booking)
        {
            try
            {
                HotelServices.ApproveBooking(booking);

                return Ok("Booking Request has been Confirmed");
            }
            catch (Exception e)
            {
                return BadRequest("Not found");
            }
            return BadRequest("Not found");

        }


    }
}
