using Microsoft.AspNetCore.Mvc;
using Rental_House_Management_System.Models;
using Rental_House_Management_System.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_House_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricBillController : ControllerBase
    {
        private readonly IElectricBillService electricBillService;

        public ElectricBillController(ElectricBillService electricBillService)
        {
            this.electricBillService = electricBillService;
        }
        // GET api/<ElectricBillController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string RoomId)
        {
            return Ok(electricBillService.GetElectricBills(RoomId));
        }

        // POST api/<ElectricBillController>
        [HttpPost]
        public IActionResult Post(ElectricBill electricBill)
        {
            return Ok(electricBillService.AddElectricBill(electricBill));

        }
    }
}
