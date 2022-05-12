using Microsoft.AspNetCore.Mvc;
using Rental_House_Management_System.Models;
using Rental_House_Management_System.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_House_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        // GET: api/<BookingController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(bookingService.GetBookings());
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(bookingService.GetBooking(id));
        }

        // POST api/<BookingController>
        [HttpPost]
        public IActionResult Post(Booking booking)
        {
            return Ok(bookingService.AddBooking(booking));
        }

        // PUT api/<BookingController>/5
        [HttpPut]
        public IActionResult Put(Booking booking) 
        {
            return Ok(bookingService.UpdateBooking(booking));
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           return Ok( bookingService.DeleteBooking(id));
        }
    }
}
