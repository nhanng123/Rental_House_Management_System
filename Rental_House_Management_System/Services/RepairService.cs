using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class RepairService : IRepairService
    {
        private readonly RepairDbContext repairDbContext;

        public RepairService(RepairDbContext repairDbContext)
        {
            this.repairDbContext = repairDbContext;
        }

        public bool AddRepair(Repair repair)
        {
            repairDbContext.repairs.Add(repair);
            repairDbContext.SaveChanges();
            return true;
        }

        public Repair GetRepair(string id)
        {
            return repairDbContext.repairs.FirstOrDefault(x => x.Id == id);
        }

        public List<Repair> GetRepairs()
        {
            return repairDbContext.repairs.ToList();
        }

        public bool RemoveRepair(string id)
        {
           Repair repair = GetRepair(id);
            repairDbContext.repairs.Remove(repair);
            repairDbContext.SaveChanges();
            return true;
        }

        public bool UpdateRepair(Repair repair)
        {
           repairDbContext.repairs.Update(repair);
            repairDbContext.SaveChanges();
            return true;
        }
    }
}
