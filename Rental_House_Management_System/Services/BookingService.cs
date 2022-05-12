using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingDbContext bookingDbContext;

        public BookingService(BookingDbContext bookingDbContext)
        {
            this.bookingDbContext = bookingDbContext;
        }
        public bool AddBooking(Booking booking)
        {
            bookingDbContext.Bookings.Add(booking);
            bookingDbContext.SaveChanges();
            return true;
        }

        public bool DeleteBooking(int id)
        {
            Booking booking = bookingDbContext.Bookings.Find(id);
            bookingDbContext.Bookings.Remove(booking);
            bookingDbContext.SaveChanges();
            return true;
        }

        public Booking GetBooking(int id)
        {
            return bookingDbContext.Bookings.Find(id);
        }

        public List<Booking> GetBookings()
        {
            return bookingDbContext.Bookings.ToList();
        }

        public bool UpdateBooking(Booking booking)
        {
            bookingDbContext.Bookings.Update(booking);
            bookingDbContext.SaveChanges();
            return true;
        }
    }
}
