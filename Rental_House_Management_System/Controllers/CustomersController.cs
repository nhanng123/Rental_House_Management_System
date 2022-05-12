using Microsoft.AspNetCore.Mvc;
using Rental_House_Management_System.Models;
using Rental_House_Management_System.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_House_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(customerService.GetCustomers());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(customerService.GetCustomer(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            return Ok(customerService.AddCustomer(customer));
        }

        // PUT api/<ValuesController>
        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            return Ok(customerService.UpdateCustomer(customer));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,string roomId)
        {
            return Ok(customerService.ChangeRoom(id,roomId));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(customerService.RemoveCustomer(id));
        }
    }
}
