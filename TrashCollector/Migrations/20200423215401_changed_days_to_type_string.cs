using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class changed_days_to_type_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "027f05f7-1639-476e-b4a7-3b81a3ab37c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29996b9c-a917-4f1b-bd6d-3915f1e36003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7024e8e1-5750-4d1c-ab61-5620c6c33551");

            migrationBuilder.AlterColumn<string>(
                name: "WeeklyPickupDay",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OneTimePickup",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickupDay",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OneTimePickup",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7024e8e1-5750-4d1c-ab61-5620c6c33551", "b9d1355e-c23f-40f3-b456-25cde58f77ff", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29996b9c-a917-4f1b-bd6d-3915f1e36003", "90b1da11-3a2e-4c85-b0ca-8dbfb2de9bab", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "027f05f7-1639-476e-b4a7-3b81a3ab37c6", "e65e3961-8b7b-454b-8602-3d2d1010ef05", "Employee", "Employee" });
        }
    }
}
