using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnimalName = table.Column<string>(nullable: true),
                    AnimalType = table.Column<string>(nullable: true),
                    ArrivalDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AnimalName", "AnimalType", "ArrivalDate" },
                values: new object[,]
                {
                    { 1, "Tom", "Dog", new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Jerry", "Cat", new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lessy", "Cat", new DateTime(2017, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Jim", "Dog", new DateTime(2016, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Trace", "Cat", new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
