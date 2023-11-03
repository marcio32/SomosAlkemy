using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomosAlkemy.Migrations
{
    public partial class Version4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2,
                column: "user_firstName",
                value: "Pepe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2,
                column: "user_firstName",
                value: "Oeoe");
        }
    }
}
