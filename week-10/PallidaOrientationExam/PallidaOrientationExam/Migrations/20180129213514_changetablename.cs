using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PallidaOrientationExam.Migrations
{
    public partial class changetablename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.CreateTable(
                name: "LicensePlates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrand = table.Column<string>(nullable: true),
                    CarModel = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Plate = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePlates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicensePlates");

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrand = table.Column<string>(nullable: true),
                    CarModel = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Plate = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                });
        }
    }
}
