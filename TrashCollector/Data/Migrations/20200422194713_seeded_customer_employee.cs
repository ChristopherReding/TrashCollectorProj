using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class seeded_customer_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30d531b4-2e40-4dca-ab6f-d40845346c9b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef605286-d53a-4b33-a63c-e3822ab0c124", "b2edcbf0-c919-4119-9723-c37c0a6c29b0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b6e8625-548c-4866-8a09-d6172c553385", "f55349e9-2a27-4d21-bc5d-aa640d028f7c", "Customer", "CSTMR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eca0c881-59af-4a57-bba6-802a7924bde7", "9d27435e-329c-4edf-b35b-c2cb9015b5c6", "Employee", "EMPLY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b6e8625-548c-4866-8a09-d6172c553385");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eca0c881-59af-4a57-bba6-802a7924bde7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef605286-d53a-4b33-a63c-e3822ab0c124");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30d531b4-2e40-4dca-ab6f-d40845346c9b", "58970605-d4e1-491b-876e-b3cedf3064e5", "Admin", "ADMIN" });
        }
    }
}
