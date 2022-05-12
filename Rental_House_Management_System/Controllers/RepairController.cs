using Microsoft.AspNetCore.Mvc;
using Rental_House_Management_System.Models;
using Rental_House_Management_System.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rental_House_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairController : ControllerBase
    {
        private readonly IRepairService repairService;

        public RepairController (IRepairService repairService)
        {
            this.repairService = repairService;
        }

        // GET: api/<RepairController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repairService.GetRepairs());  
        }

        // GET api/<RepairController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(repairService.GetRepair(id));
        }

        // POST api/<RepairController>
        [HttpPost]
        public IActionResult Post(Repair repair)
        {
            return Ok(repairService.AddRepair(repair));
        }

        // PUT api/<RepairController>/
        [HttpPut]
        public IActionResult Put(Repair repair)
        {
            return Ok(repairService.UpdateRepair(repair));  
        }

        // DELETE api/<RepairController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(repairService.RemoveRepair(id));
        }
    }
}
