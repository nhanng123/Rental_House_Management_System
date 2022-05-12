using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class RoomService : IRoomService
    {
        private readonly RoomDbContext _roomDbContext;

        public RoomService(RoomDbContext roomDbContext)
        {
            _roomDbContext = roomDbContext;
        }
        public bool AddRoom(Room room)
        {
            _roomDbContext.Rooms.Add(room);
            _roomDbContext.SaveChanges();
            return true;
        }

        public List<Room> GetRoom()
        {
            return _roomDbContext.Rooms.ToList();
        }

        public Room GetOneRoom(string id)
        {
            Room room = _roomDbContext.Rooms.Find(id);
            return room;
        }

        public bool RemoveRoom(string id)
        {
            Room room = _roomDbContext.Rooms.Find(id);
            _roomDbContext.Rooms.Remove(room);
            _roomDbContext.SaveChanges();
            return true;
        }

        public bool UpdateRoom(Room room)
        {
            _roomDbContext.Rooms.Update(room);
            _roomDbContext.SaveChanges();
            return true;
        }
    }
}
