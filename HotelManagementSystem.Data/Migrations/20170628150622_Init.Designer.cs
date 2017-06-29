using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HotelManagementSystem.Data;

namespace HotelManagementSystem.Data.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20170628150622_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelManagementSystem.Domain.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEnded");

                    b.Property<DateTime>("DateStarded");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<double>("PhoneNumber");

                    b.Property<int>("RoomId");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("HotelManagementSystem.Domain.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<string>("Description");

                    b.Property<bool>("IsReserved");

                    b.Property<double>("PricePerDay");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });
        }
    }
}
