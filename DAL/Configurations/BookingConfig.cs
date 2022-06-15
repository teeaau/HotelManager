using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class BookingConfig : EntityTypeConfiguration<Booking>
    {
        public BookingConfig()
        {
            this.HasOptional(b => b.Customer)
                .WithMany()
                .WillCascadeOnDelete(false);
            this.HasRequired(b => b.Room)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }
}
