using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingHotel.Migrations
{
    public partial class databaruok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    RoomNumber = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    BookPrice = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    checkin = table.Column<DateTime>(nullable: false),
                    checkout = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
