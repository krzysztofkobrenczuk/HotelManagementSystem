using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Data.Migrations
{
    public partial class changeTableClientRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnded",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateStarded",
                table: "Clients");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnded",
                table: "ClientRooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarded",
                table: "ClientRooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEnded",
                table: "ClientRooms");

            migrationBuilder.DropColumn(
                name: "DateStarded",
                table: "ClientRooms");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnded",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarded",
                table: "Clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
