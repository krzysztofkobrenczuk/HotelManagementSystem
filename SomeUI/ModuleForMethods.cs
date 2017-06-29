using HotelManagementSystem.Data;
using HotelManagementSystem.Data.EFLogging;
using HotelManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeUI
{
    public class ModuleForMethods
    {
        private static HotelContext _context = new HotelContext();

        public static void RunAll() {


           // QueryWithNonSql();
            Console.ReadKey();
        }
        private static void QueryWithNonSql()
        {
            Console.WriteLine(ReverseString("apple"));

            var clients = _context.Clients
                .Select(c => new { newName = ReverseString(c.FirstName) })
                .ToList();
            clients.ForEach(c => Console.WriteLine(c.newName));
            Console.WriteLine();
        }
        private static string ReverseString(string value)
        {
            var s = value.AsEnumerable();

            var stringChar = value.AsEnumerable();

            // return string.Concat(stringChar.Reverse());
            return string.Concat(s.Reverse());
        }

        private static void RawSqlQuery()
        {
            var clients = _context.Clients.FromSql("Select * from Clients").ToList();
            clients.ForEach(c => Console.WriteLine(c.FirstName));
            Console.WriteLine();
        }

        private static void DeleteWhileTracked()
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == 1);
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

        private static void AddMoreClients()
        {
            _context.AddRange(
                 new Client { FirstName = "siema", LastName = "elo" },
                 new Client { FirstName = "Jan", LastName = "Paz" },
                 new Client { FirstName = "Elon", LastName = "Musk" },
                 new Client { FirstName = "Andrzej", LastName = "Andrzej" }

                );
            _context.SaveChanges();
        }

        private static void AddClient()
        {
            var client = new Client { FirstName = "James", LastName = "Frank"};
            using (var context = new HotelContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        private static void QueryAndUpdateDisconnectedClient()
        {
            var client = _context.Clients.FirstOrDefault();
            client.FirstName = "Yolo";

            using (var contextNewAppInstance = new HotelContext())
            {
                contextNewAppInstance.Clients.Update(client);
                contextNewAppInstance.SaveChanges();
            }
        }

        private static void QueryAndUpdateRoomDisconnected()
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Capacity == 3);
            room.Description += " Dodaj 3";
            using (var contextNewAppInstance = new HotelContext())
            {
                contextNewAppInstance.Rooms.Update(room);
                contextNewAppInstance.SaveChanges();
            }
        }

        private static void MultipleOperations()
        {
            var room = _context.Rooms.FirstOrDefault();
            room.Description += "Test";
            _context.Rooms.Add(new Room { Description = "Pokoj testowy" });
            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateMultipleRooms()
        {
            var rooms = _context.Rooms.ToList();
            rooms.ForEach(r => r.Description += "Dodawaj");
            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateRoom()
        {
            var room = _context.Rooms.FirstOrDefault();
            room.Description += "Siema";
            _context.SaveChanges();
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
            var roomForThree = new Room { Capacity = 3, Description = "For 3 People" };
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
