using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class added_hold_date_properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01b2a7bc-13dd-438a-bbaa-72c09f12671d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd939240-137a-4644-aa05-1377a1789cf9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d656a1b8-b7f1-4918-9602-5b1be5f80496");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndServiceHold",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartServiceHold",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a4cd775-6f3a-4839-8693-3a698bd12e51", "29e32514-6bec-4adf-b20d-ca4ec3177df0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08c646f6-9758-4850-a393-077d53f7b358", "9418ffa0-3db5-4318-aa52-99ff6d0533ac", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95c58b2b-2dab-4767-b4c5-8c8beec99441", "b22f9be5-a54f-463e-b299-e34d56097dd5", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08c646f6-9758-4850-a393-077d53f7b358");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a4cd775-6f3a-4839-8693-3a698bd12e51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95c58b2b-2dab-4767-b4c5-8c8beec99441");

            migrationBuilder.DropColumn(
                name: "EndServiceHold",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartServiceHold",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d656a1b8-b7f1-4918-9602-5b1be5f80496", "38ee9d0d-1bd9-4d2f-b7d1-18304013191c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd939240-137a-4644-aa05-1377a1789cf9", "8fdf1c71-a534-4937-b612-e6ec03387013", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01b2a7bc-13dd-438a-bbaa-72c09f12671d", "97d7a88d-8b0f-44ec-a14a-23340d9b64cd", "Employee", "Employee" });
        }
    }
}
