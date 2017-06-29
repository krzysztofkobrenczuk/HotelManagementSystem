using HotelManagementSystem.Data;
using HotelManagementSystem.Data.EFLogging;
using HotelManagementSystem.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeUI
{
    class Program
    {
        private static HotelContext _context = new HotelContext();
        static void Main(string[] args)
        {
            _context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            //AddRoom();
            //AddMultipleRooms();
            //SimpleRoomQuery();
            //
            MoreQueries();
            Console.ReadKey();
        }

        private static void MoreQueries()
        {
            var rooms = _context.Rooms.Where(r => r.Capacity == 3).ToList();
            foreach (var room in rooms)
            {
                Console.WriteLine(room.Description);
            }
        }

        private static void AddMultipleRooms()
        {
            var roomForThree = new Room {Capacity = 3, Description = "For 3 People" };
            var roomForFour = new Room { Capacity = 4, Description = "For 4 People" };

            using (var context = new HotelContext())
            {
                context.Rooms.AddRange(new List<Room> { roomForThree, roomForFour });
                context.SaveChanges();
            }
        }
        private static void AddRoom()
        {
            var roomForTwo = new Room { Description = "For 2 People" };

            using (var context = new HotelContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
                context.Rooms.Add(roomForTwo);
                context.SaveChanges();
            }
        }
        private static void SimpleRoomQuery()
        {
            using (var context = new HotelContext())
            {
                var rooms = context.Rooms.ToList();
                var query = context.Rooms;
                var roomsAgain = query.ToList();
                foreach (var room in rooms)
                {
                    Console.WriteLine(room.Description);
                }
            }
        }
    }
}
