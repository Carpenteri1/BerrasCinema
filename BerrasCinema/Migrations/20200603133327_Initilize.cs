using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BerrasCinema.Migrations
{
    public partial class Initilize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(nullable: true),
                    SeatsLeft = table.Column<int>(nullable: false),
                    MovieStart = table.Column<DateTime>(nullable: false),
                    MovieDuration = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "TicketOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmountOfTickets = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ConfirmEmail = table.Column<string>(nullable: false),
                    MovieName = table.Column<string>(nullable: false),
                    MovieID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOrders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_TicketOrders_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketOrders_MovieID",
                table: "TicketOrders",
                column: "MovieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketOrders");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
