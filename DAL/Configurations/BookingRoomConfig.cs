using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class BookingRoomConfig : EntityTypeConfiguration<BookingRoom>
    {
        public BookingRoomConfig()
        {
            this.HasKey(k => new { k.bookingId, k.roomId });
            this.HasRequired(br => br.Room)
                .WithMany(r => r.BookingRooms)
                .HasForeignKey(br => br.roomId)
                .WillCascadeOnDelete(false);
        }
    }
}
