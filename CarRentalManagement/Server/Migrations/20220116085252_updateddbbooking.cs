using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbbooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "fbe4e0a7-e34a-4dd3-b8ff-92d25a20e907");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "24bb0f93-8634-4e68-97a9-5fbe8f7cf45e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d24f13-ff0c-4985-a8a4-0abdcfee5214", "AQAAAAEAACcQAAAAEOG6ygHiQHR8lsp/j7tFc7pfZ7kzwaJvkYN54eu42sNE1zoPFTvfPbSnTgfREYue9A==", "8a0e34d4-3676-472c-8e40-846c5d1b75fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3642a37-05f0-402a-90a9-f8704972f748", "AQAAAAEAACcQAAAAEF6Sljc2mfhkj2gAOHn5F6tMGo8Q98O3M+wH1Wd4PQ1INFJZHAEyqXC6Vte6/sk97A==", "52215688-f86f-4682-8e33-bcf5e1409edb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 619, DateTimeKind.Local).AddTicks(7437), new DateTime(2022, 1, 9, 23, 22, 41, 623, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 623, DateTimeKind.Local).AddTicks(8926), new DateTime(2022, 1, 9, 23, 22, 41, 623, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(2121), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8366), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8381), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8385), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 1, 9, 23, 22, 41, 626, DateTimeKind.Local).AddTicks(8391) });
        }
    }
}
