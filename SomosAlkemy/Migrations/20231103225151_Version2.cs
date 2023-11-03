using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SomosAlkemy.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 1, "40073892", "Marcio@gmail.com", "Marcio", false, "Abriola", "1234" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "user_id", "user_DNI", "user_email", "user_firstName", "user_isDeleted", "user_lastName", "user_password" },
                values: new object[] { 2, "40073894", "Pepe@gmail.com", "Oeoe", false, "Abriola", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "user_id",
                keyValue: 2);
        }
    }
}
