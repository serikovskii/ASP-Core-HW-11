using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication14.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17c6292e-20ee-4536-b224-87cc76fdb1e1");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "MyHeaderKey", "Name", "Password" },
                values: new object[] { "409c68df-8784-459c-ba99-fbbe90e527db", "admin@admin.kz", "admin", "f89313a4-9ab7-4f5b-9cac-5364f0f20e53", "Azat", "1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "409c68df-8784-459c-ba99-fbbe90e527db");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "MyHeaderKey", "Name", "Password" },
                values: new object[] { "17c6292e-20ee-4536-b224-87cc76fdb1e1", "admin@admin.kz", "admin", "1a822e99-f9b2-4904-a730-0b97c98f0df5", "Azat", "1234" });
        }
    }
}
