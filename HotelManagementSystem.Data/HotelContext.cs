using HotelManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    public class HotelContext : DbContext
    {

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientRoom>()
                .HasKey(s => new { s.ClientId, s.RoomId });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server = (localdb)\\MSSQLLocalDB; Database = HotelManagement; Trusted_Connection = True; ",
               options=>options.MaxBatchSize(30));
            
        }
    }
}
