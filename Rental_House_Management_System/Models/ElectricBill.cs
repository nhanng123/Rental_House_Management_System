namespace Rental_House_Management_System.Models
{
    public class ElectricBill
    {
        public int Id { get; set; }
        public string RoomId { get; set; }
        public int Electric_Number { get; set; }
        public DateTime Electric_Date { get; set; }
    }
}
