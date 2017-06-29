using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Domain
{
    public class Client : ClientChangeTracker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double PhoneNumber { get; set; }
        //public int RoomId { get; set; }
        public List<ClientRoom> ClientRooms { get; set; }



    }
}
