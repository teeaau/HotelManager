using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BookingRepository : GenericRepository<Booking>
    {
        public BookingRepository() : base() { }

        public async Task<ICollection<Room>> GetRoomsIncludeAsync()
        {
            return await Context.Rooms.Include("BookingRooms.Booking.Customer").ToListAsync();
        }

        public async Task<ICollection<Floor>> GetFloorsAsync()
        {
            return await Context.Floors.ToListAsync();
        }

        public Customer GetCustomerById(string customerId)
        {
            return Context.Customers.FirstOrDefault(c => c.customerId == customerId);
        }

        public List<Booking> GetBookingsByRoom(Room room)
        { 
            return room.BookingRooms
                .Select(br => br.Booking)
                //.Where(b => b.checkin > DateTime.Now)
                .ToList();            
        }

        public void AddBooking(Booking booking)
        {
            Context.Bookings.Add(booking);
            Context.BookingRooms.Add(new BookingRoom()
            {
                bookingId = booking.bookingId,
                roomId = booking.roomId
            });
        }
    }
}
