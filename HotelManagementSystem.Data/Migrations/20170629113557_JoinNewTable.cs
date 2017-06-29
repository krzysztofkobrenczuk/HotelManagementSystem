using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagementSystem.Data.Migrations
{
    public partial class JoinNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Clients_ClientId",
                table: "ClientRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientRoom_Rooms_RoomId",
                table: "ClientRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom");

            migrationBuilder.RenameTable(
                name: "ClientRoom",
                newName: "ClientRooms");

            migrationBuilder.RenameIndex(
                name: "IX_ClientRoom_RoomId",
                table: "ClientRooms",
                newName: "IX_ClientRooms_RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientRooms",
                table: "ClientRooms",
                columns: new[] { "ClientId", "RoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRooms_Clients_ClientId",
                table: "ClientRooms",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRooms_Rooms_RoomId",
                table: "ClientRooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientRooms_Clients_ClientId",
                table: "ClientRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientRooms_Rooms_RoomId",
                table: "ClientRooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientRooms",
                table: "ClientRooms");

            migrationBuilder.RenameTable(
                name: "ClientRooms",
                newName: "ClientRoom");

            migrationBuilder.RenameIndex(
                name: "IX_ClientRooms_RoomId",
                table: "ClientRoom",
                newName: "IX_ClientRoom_RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientRoom",
                table: "ClientRoom",
                columns: new[] { "ClientId", "RoomId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Clients_ClientId",
                table: "ClientRoom",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientRoom_Rooms_RoomId",
                table: "ClientRoom",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
