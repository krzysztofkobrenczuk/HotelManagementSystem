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
        public DbSet<ClientRoom> ClientRooms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientRoom>()
                .HasKey(s => new { s.ClientId, s.RoomId });

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModified");
                modelBuilder.Entity(entityType.Name).Ignore("IsDirty");
            }
            {

            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server = (localdb)\\MSSQLLocalDB; Database = HotelRelatedData; Trusted_Connection = True; ",
               options=>options.MaxBatchSize(30));
            
        }

        //Override to current date time
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                e.State == EntityState.Modified))
            {
                entry.Property("LastModified").CurrentValue = DateTime.Now;             
            }
            return base.SaveChanges();
        }
    }
}
