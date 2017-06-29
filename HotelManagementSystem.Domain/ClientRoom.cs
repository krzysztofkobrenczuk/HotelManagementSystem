using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Domain
{
    public class ClientRoom
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
