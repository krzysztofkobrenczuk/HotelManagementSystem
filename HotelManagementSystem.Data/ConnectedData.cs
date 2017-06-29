using HotelManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    public class ConnectedData
    {
        private HotelContext _context;

        public ConnectedData()
        {
            _context = new HotelContext();
            _context.Database.EnsureCreated();
        }

        public Client CreateNewClient()
        {
            var client = new Client { FirstName = "New client" };
            _context.Clients.Add(client);
            return client;
        }

        public LocalView<Client> ClientsListInMemory()
        {
            if(_context.Clients.Local.Count == 0)
            {
                _context.Clients.ToList();
            }
            return _context.Clients.Local;
        }

                                                     
        public Client LoadClientGraph(int clientId)
        {
            var client = _context.Clients.Find(clientId);
           // _context.Entry(client).Reference(c => c.ClientRooms).Load();
            return client;
        }
        public void SaveChanges(Type typeBeingEdited)
        {
            _context.SaveChanges();
            if (typeBeingEdited == typeof(Client))
            {
                if (_context.Clients.Local.Any())
                {
                    ClientsListInMemory().ToList().ForEach(s => s.IsDirty = false);
                }
            }
            if (typeBeingEdited == typeof(Room))
            {
                if (_context.Rooms.Local.Any())
                {
                    RoomsListInMemory().ToList().ForEach(s => s.IsDirty = false);
                }
            }

        }

        public LocalView<Room> RoomsListInMemory()
        {
            if (_context.Rooms.Local.Count == 0)
            {
                _context.Rooms.ToList();
            }
            return _context.Rooms.Local;
        }

        public List<Client> ClientsNotInRoom(int roomId)
        {
            var existingClients = _context.ClientRooms
                .Where(cr => cr.RoomId == roomId)
                .Select(cr => cr.ClientId).ToList();
            var clients = _context.Clients.AsNoTracking()
                .Where(c => !existingClients.Contains(c.Id))
                .ToList();

            return clients;
        }

        public Room LoadRoomGraph(int roomId)
        {
            var room = _context.Rooms.Find(roomId);

            _context.Entry(room).Collection(r => r.ClientRooms).Query().Include(cr => cr.Client).Load();
            return room;
        }

        public void AddClientRoom(ClientRoom clientRoom)
        {
            _context.Entry(clientRoom).State = EntityState.Added;
        }

        public void RevertRoomChanges(int id)
        {
            _context = new HotelContext();
        }
        public Room CreateNewRoom()
        {
            var room = new Room { Capacity = 1, Description = "New Room" };
            _context.Rooms.Add(room);
            return room;
        }

        public LocalView<ClientRoom> ClientRoomListInMemory()
        {
            if (_context.ClientRooms.Local.Count == 0)
            {
                _context.ClientRooms.ToList();
            }
            return _context.ClientRooms.Local;
        }

    }
}
