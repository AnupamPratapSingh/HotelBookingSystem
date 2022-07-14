using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBS.DomainlLayer.Models;



namespace HBS.RepositaryLayer
{
    public class HBMSDBContext : DbContext
    {
        public HBMSDBContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<User> User { get; set; }
        DbSet<Hotel> Hotel { get; set; }

        DbSet<RoomDetails> RoomDetails { get; set; }

        DbSet<BookingDetails> BookingDetails{ get; set; }

    }
}
