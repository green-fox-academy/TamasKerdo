using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TripChat.Migrations
{
    public partial class triplocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripLocation_Trips_TripId",
                table: "TripLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripLocation",
                table: "TripLocation");

            migrationBuilder.RenameTable(
                name: "TripLocation",
                newName: "TripLocations");

            migrationBuilder.RenameIndex(
                name: "IX_TripLocation_TripId",
                table: "TripLocations",
                newName: "IX_TripLocations_TripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripLocations",
                table: "TripLocations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripLocations_Trips_TripId",
                table: "TripLocations",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripLocations_Trips_TripId",
                table: "TripLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TripLocations",
                table: "TripLocations");

            migrationBuilder.RenameTable(
                name: "TripLocations",
                newName: "TripLocation");

            migrationBuilder.RenameIndex(
                name: "IX_TripLocations_TripId",
                table: "TripLocation",
                newName: "IX_TripLocation_TripId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TripLocation",
                table: "TripLocation",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripLocation_Trips_TripId",
                table: "TripLocation",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
