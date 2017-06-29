using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Domain
{
    public class Room
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public  double PricePerDay { get; set; }
        public bool IsReserved { get; set; }
        public List<ClientRoom> ClientRooms { get; set; } 

    }
}
