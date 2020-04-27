using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class made_datetime_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartServiceHold",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndServiceHold",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "StartServiceHold",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndServiceHold",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

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
    }
}
