using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "ed83ed07-6fb5-4a68-b6d4-4e6b9345cad1", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f5a6dcac-33fc-4a58-b479-aa09d0147bc3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e79ba3c9-0d0c-4258-a523-ffaeab763cd4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEC5v2MFAaGUUfhqCC2226ddQCs0rXtpyn2MmkqGnA86TGJ3nQG8n7tPFEzHztxCIow==", null, false, "e495160b-9bb1-47ef-8ad1-5bcacb848c8a", false, "Admin" },
                    { "s6d9f4v0-e72c-12es-0971-es2d21f0e898", 0, "05106ecc-7f65-4d01-90a2-be2f506b02cc", "user@localhost.com", false, "User", "User2", false, null, "USER@LOCALHOST.COM", "USER", "AQAAAAEAACcQAAAAEJmcPlGLeS2lZarOpOq9hhcKhbG7PBcVWzNDG4J6dXdAKs4JkCMpBcbqS8vq9Hw7+Q==", null, false, "7cf565ae-29eb-4eb1-98f2-eecfa3bfbc53", false, "User" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 3, 42, 36, 446, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 12, 5, 3, 42, 36, 449, DateTimeKind.Local).AddTicks(5404), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 3, 42, 36, 449, DateTimeKind.Local).AddTicks(6869), new DateTime(2021, 12, 5, 3, 42, 36, 449, DateTimeKind.Local).AddTicks(6878), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 3, 42, 36, 455, DateTimeKind.Local).AddTicks(7788), new DateTime(2021, 12, 5, 3, 42, 36, 455, DateTimeKind.Local).AddTicks(7811), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 3, 42, 36, 455, DateTimeKind.Local).AddTicks(7815), new DateTime(2021, 12, 5, 3, 42, 36, 455, DateTimeKind.Local).AddTicks(7816), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1918), new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1929), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1933), new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1934), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1936), new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1937), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1938), new DateTime(2021, 12, 5, 3, 42, 36, 458, DateTimeKind.Local).AddTicks(1939), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "s6d9f4v0-e72c-12es-0971-es2d21f0e898" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "s6d9f4v0-e72c-12es-0971-es2d21f0e898" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898");
        }
    }
}
