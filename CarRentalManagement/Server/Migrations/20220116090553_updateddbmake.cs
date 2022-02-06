using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbmake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "2717dd23-3284-4e49-b450-ca3370d0c751");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3f14a701-d603-4f04-9c83-75aec09267ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a054a1b7-efd2-4592-ab45-c579b9e295ad", "AQAAAAEAACcQAAAAEFcK7J7vIVClkYxmghWczYylP3nRsTWUt5SGY5CtzOa7/9+d6D2MmNkNGy3eDsYNaA==", "140c90ce-9add-4335-9684-d7d3653b2939" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76eb9afe-1d30-4063-84e5-2997a070d068", "AQAAAAEAACcQAAAAENFvdTee8HTV75CJCTQHBvogtORhgBBv64U5LMh6D68vQxLPTbz/GfDb/RIUGxUEQw==", "1e2255de-0cc4-4669-8836-66c8099a34ae" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 938, DateTimeKind.Local).AddTicks(92), new DateTime(2022, 1, 16, 17, 5, 52, 941, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 941, DateTimeKind.Local).AddTicks(7987), new DateTime(2022, 1, 16, 17, 5, 52, 941, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 943, DateTimeKind.Local).AddTicks(8511), new DateTime(2022, 1, 16, 17, 5, 52, 943, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 943, DateTimeKind.Local).AddTicks(8538), new DateTime(2022, 1, 16, 17, 5, 52, 943, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4364), new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4367), new DateTime(2022, 1, 16, 17, 5, 52, 944, DateTimeKind.Local).AddTicks(4369) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "1d758b06-1445-44c7-b04e-37c53f19748a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "203ae368-1482-4be1-b9cb-0ec38fa7de0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc7b9bc4-f839-43fb-8544-634d1e1598d1", "AQAAAAEAACcQAAAAEJA/2SQ9va0RK/GWhjKA/lhNmKUmwmbdw+dM/bYBQNnkwj7q1082FodF3kySaSWxFQ==", "1e5cc94b-9bb8-4647-b0ce-b856a3af03cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab718f7c-99d4-43b3-8488-8eface3c376a", "AQAAAAEAACcQAAAAEI1HZipzCFtYhuJ3Pkj+IPpjlTL53o75dp4VLjXyBWO4RkvUKHbf4ZEq9a5lxBKy3A==", "af1e2629-4f8d-4664-8ff7-f8f93074ae7c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 138, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 1, 16, 16, 52, 51, 141, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 141, DateTimeKind.Local).AddTicks(7549), new DateTime(2022, 1, 16, 16, 52, 51, 141, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 143, DateTimeKind.Local).AddTicks(5734), new DateTime(2022, 1, 16, 16, 52, 51, 143, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 143, DateTimeKind.Local).AddTicks(5757), new DateTime(2022, 1, 16, 16, 52, 51, 143, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1179), new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1192), new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1196), new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1199), new DateTime(2022, 1, 16, 16, 52, 51, 144, DateTimeKind.Local).AddTicks(1200) });
        }
    }
}
