using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomosAlkemy.Migrations
{
    public partial class version5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "user_role",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_role",
                table: "Users");
        }
    }
}
