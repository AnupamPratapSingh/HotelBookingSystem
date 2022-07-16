using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBS.RepositaryLayer;
using HBS.DomainlLayer.Models;

namespace HBS.ServiceLayer
{
    public interface InterfaceHotelService
    {
        IList<Hotel> HotelList();
        void UpdateHotel(Hotel hotel);

        void DeleteHotel(int hotel_id);

        void RegisterNewUser(User user);

        void AddBookingRequest(BookingRequest booking);

        IList<BookingRequest> BookingRequestsList();

        void ApproveBooking(BookingDetails booking);

        IList<BookingDetails> Report();


        IList<RoomDetails> RoomList();

        void AddHotel(Hotel hotel);

    }
}
