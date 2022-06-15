using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>
    {
        public PaymentRepository() : base() { }
        public async Task<ICollection<Room>> GetRoomsIncludeAsync()
        {
            return await Context.Rooms.Include("BookingRooms.Booking.Customer").ToListAsync();
        }

        public async Task<ICollection<Floor>> GetFloorsAsync()
        {
            return await Context.Floors.ToListAsync();
        }

        public List<Booking> GetBookingsByRoom(Room room)
        {
            return room.BookingRooms
                .Select(br => br.Booking)
                //.Where(b => b.checkin > DateTime.Now)
                .ToList();
        }

        public void RemoveBooking(Payment payment)
        {
            var booking = Context.Bookings.FirstOrDefault(b => b.bookingId == payment.Booking.bookingId);
            Context.Bookings.Remove(booking);
        }

        public void AddBill(Payment payment)
        {
            var bill = new Bill()
            {
                checkin = payment.Booking.checkin,
                checkout = payment.Booking.checkout,
                customerName = payment.Booking.Customer.customerName,
                displayRoom = payment.Booking.Room.displayRoom,
                dateOfPayment = payment.dateOfPayment.Value,
                total = payment.total
            };
            Context.Bills.Add(bill);
        }
    }
}
