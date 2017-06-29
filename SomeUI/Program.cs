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
    class Program
    {
        private static HotelContext _context = new HotelContext();
        static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
            _context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            // InsertNewPkFkGraph();
            // ModuleForMethods.RunAll();
            //AddRooms();
            // AddManyToManyWithFks();
            //AddManyToManyWithObjects();
            // Console.WriteLine("test");

            //AnonymousTypeViaProjectiom();
            DisconnectedMethods.AddGraphAllNew();
            Console.ReadKey();
           
        }

        private static void AnonymousTypeViaProjectiom()
        {
            _context = new HotelContext();
            var clients = _context.Clients
                .Select(c => new { c.Id, c.FirstName }).ToList();
        }

        private static void AddManyToManyWithObjects()
        {
            _context = new HotelContext();
            var client = _context.Clients.FirstOrDefault();
            var room = _context.Rooms.FirstOrDefault();

            _context.ClientRooms.Add(new ClientRoom { Client = client, Room = room });
            _context.SaveChanges();
        }

        private static void AddManyToManyWithFks()
        {
            _context = new HotelContext();
            var sb = new ClientRoom { ClientId = 1, RoomId = 1, DateStarded = new DateTime(2017,05,05), DateEnded = new DateTime(2017,06,12) };
            _context.ClientRooms.Add(sb);
            _context.SaveChanges();
        }

        private static void InsertNewPkFkGraph()
        {
            _context.Clients.AddRange(new Client
            {
                FirstName = "John",
                LastName = "Eclipse"
            },
            new Client { FirstName = "Elon", LastName = "Musk" }
            );
            _context.SaveChanges();
        }
        private static void AddRooms()
        {
            _context.Rooms.AddRange(
                 new Room { Capacity = 4, Description = "Yolo"} ,
                 new Room { Capacity = 5, Description = "Siemko"}

                );
            _context.SaveChanges();
        }


    }
}
