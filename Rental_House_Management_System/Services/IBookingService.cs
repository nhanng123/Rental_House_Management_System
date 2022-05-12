using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        Booking GetBooking(int id);
        Boolean AddBooking(Booking booking);
        Boolean UpdateBooking(Booking booking);
        Boolean DeleteBooking(int id);
    }
}
