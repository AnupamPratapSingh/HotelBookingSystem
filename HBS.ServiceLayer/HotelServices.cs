using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBS.RepositaryLayer;
using HBS.DomainlLayer.Models;

namespace HBS.ServiceLayer
{
    public class HotelServices : InterfaceHotelService
    {

        public HBMSDBContext HBMSDBContext;

        public HotelServices(HBMSDBContext hbmsdbcontext)
        {
            this.HBMSDBContext = hbmsdbcontext;
        }

        public IList<Hotel> HotelList()
        {
            return HBMSDBContext.Set<Hotel>().ToList();
        }

        void InterfaceHotelService.UpdateHotel(Hotel hotel)
        {
            HBMSDBContext.Update<Hotel>(hotel);
            HBMSDBContext.SaveChanges();

        }
        public void DeleteHotel(int hotel_id)
        {
            Hotel hotel = GetHotel(hotel_id);
            if (hotel != null)
            {
                HBMSDBContext.Remove<Hotel>(hotel);
                HBMSDBContext.SaveChanges();
            }

        }
        private Hotel GetHotel(int hotel_id)
        {
            return HBMSDBContext.Find<Hotel>(hotel_id);


        }

        public void RegisterNewUser(User user)
        {
            HBMSDBContext.Add<User>(user);
            HBMSDBContext.SaveChanges();

        }

        public void AddBookingRequest(BookingRequest booking)
        {
            HBMSDBContext.Add<BookingRequest>(booking);
            HBMSDBContext.SaveChanges();

        }

        public IList<BookingRequest> BookingRequestsList()
        {
            return HBMSDBContext.Set<BookingRequest>().ToList();
        }



        public void ApproveBooking(BookingDetails booking)
        {
            HBMSDBContext.Add<BookingDetails>(booking);
            HBMSDBContext.SaveChanges();

        }

        public IList<BookingDetails> Report()
        {
            return HBMSDBContext.Set<BookingDetails>().ToList();
        }

        public IList<RoomDetails> RoomList()
        {
            return HBMSDBContext.Set<RoomDetails>().ToList();
        }


    }
}
