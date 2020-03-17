using Microsoft.EntityFrameworkCore;

namespace BookingHotel.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins {get;set;}
        public DbSet<Room> Rooms {get;set;}
        public DbSet<Booking> Bookings {get;set;}
        public DbSet<Guest> Guests {get;set;}
        public DbSet<Account> Accounts {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
        public DbSet<AccountPage> AccountPages {get;set;}
        public AppDbContext (DbContextOptions options):base(options)
        {
            
        }
    }
}