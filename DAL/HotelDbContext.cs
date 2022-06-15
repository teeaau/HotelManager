using DAL.Configurations;
using Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext() : base("name=HotelDb")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RolePermissionConfig());
            modelBuilder.Configurations.Add(new BookingConfig());
            modelBuilder.Configurations.Add(new BookingRoomConfig());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}