namespace Rental_House_Management_System.Models
{
    public class Bill
    {
        public string Id { get; set; }
        public string Room { get; set; }
        public DateTime Time { get; set; }
        public int Electric_Num { get; set; }
        public int Water_Num { get; set; }
        public int Garbage_Fee { get; set; }
        public int Wifi_Fee { get; set; }
        public int Total { get; set; }

    }
}
