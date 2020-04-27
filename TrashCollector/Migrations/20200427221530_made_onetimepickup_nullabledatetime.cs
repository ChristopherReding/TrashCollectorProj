using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class made_onetimepickup_nullabledatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12912df2-aa3e-494e-abf3-c21a6969a29c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ec1d8ef-bf27-4455-8d2e-178466c7d745");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7bcb142-d924-4aa6-aa73-c34460f4274d");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OneTimePickup",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e6391eeb-0042-440e-8434-f6d566b68b11", "d851f8a3-2d3a-442d-8514-0098411c283a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85ab3b1a-a4ec-49f1-a940-92b1dd8208cd", "8a2d10d0-e5c2-4e4d-8155-979cc7f37120", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "981b2c2d-b5a6-46d4-b24c-e2e050b24ff0", "7b6430c8-57f0-476f-9ca0-37009e6006e8", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85ab3b1a-a4ec-49f1-a940-92b1dd8208cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "981b2c2d-b5a6-46d4-b24c-e2e050b24ff0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6391eeb-0042-440e-8434-f6d566b68b11");

            migrationBuilder.AlterColumn<string>(
                name: "OneTimePickup",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12912df2-aa3e-494e-abf3-c21a6969a29c", "768d1302-c81a-48cf-92a2-3fe1e1cbd579", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7bcb142-d924-4aa6-aa73-c34460f4274d", "5afcf537-47ba-4265-8aa0-8a594e2f1932", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ec1d8ef-bf27-4455-8d2e-178466c7d745", "33a6f4b6-0d85-47eb-b915-3f0ce6ca9533", "Employee", "Employee" });
        }
    }
}
