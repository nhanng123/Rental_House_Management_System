using Microsoft.AspNetCore.Mvc;
using Rental_House_Management_System.Models;
using Rental_House_Management_System.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_House_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService billService;

        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        // GET: api/<BillController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(billService.GetBills());
        }

        // GET api/<BillController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(billService.GetBill(id));
        }

        // POST api/<BillController>
        [HttpPost]
        public IActionResult Post(Bill bill)
        {
            return Ok(billService.AddBill(bill));
        }

        // PUT api/<BillController>
        [HttpPut]
        public IActionResult Put(Bill bill)
        {
            return Ok(billService.UpdateBill(bill));
        }

        // DELETE api/<BillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(billService.RemoveBill(id));
        }
    }
}
