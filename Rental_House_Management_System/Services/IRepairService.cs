using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface IRepairService
    {
        List<Repair> GetRepairs();
        Repair GetRepair(string id);

        Boolean AddRepair(Repair repair);
        Boolean RemoveRepair(string id);

        Boolean UpdateRepair(Repair repair);

    }
}
