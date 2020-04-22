using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customer_employee_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3d465173-3ccd-4e20-b514-b8a4658c4c24", "542434b4-b0f5-4772-9bb2-df507603354d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67b96cf2-9f2e-44e8-adaf-5b7cfe579ece", "f2af12c9-4e71-41ec-9536-1e10ce973eee", "Customer", "CSTMR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f9d2063-dbdc-482f-956b-ea34998ade7b", "651866f1-3aee-4dc3-b2f2-f9380697ec00", "Employee", "EMPLY" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d465173-3ccd-4e20-b514-b8a4658c4c24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67b96cf2-9f2e-44e8-adaf-5b7cfe579ece");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f9d2063-dbdc-482f-956b-ea34998ade7b");

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
    }
}
