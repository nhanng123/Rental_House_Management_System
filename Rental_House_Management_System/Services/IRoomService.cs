using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface IRoomService
    {
        List<Room> GetRoom();

        Room GetOneRoom(string roomId);
        Boolean AddRoom (Room room);
        Boolean RemoveRoom(string roomId);
        Boolean UpdateRoom(Room room);
    }
}
