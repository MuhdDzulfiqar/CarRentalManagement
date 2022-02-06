using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbcolour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "942c5b9e-bda3-4781-ac8f-117996d29031");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "6ba1bb7e-2133-4b31-b11d-156f1dbccc74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cf0dc7-d1ac-4e9f-95dd-10616414964d", "AQAAAAEAACcQAAAAEBZF63zS+zNGaJOFFsjgn5OD6WH2+mJUrpPCrEaHmWc6ciFXmM7J5/Xk7AMsWwBJ5w==", "6b10d59d-7a0f-4797-92b8-1c1b9f87b7d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba74332-a59d-4ea2-86fa-7f5c0ec7ee38", "AQAAAAEAACcQAAAAEDdVghZi54B+vJx7/6OAzbeDSphUU4ggmsfZ11Ms53Iy9VCTxgGwQCGXlfEi6H08PQ==", "e86f13e0-ffe3-4e1c-9638-2d2e0997e9bf" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 493, DateTimeKind.Local).AddTicks(3977), new DateTime(2022, 1, 16, 17, 6, 26, 497, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 497, DateTimeKind.Local).AddTicks(4839), new DateTime(2022, 1, 16, 17, 6, 26, 497, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 499, DateTimeKind.Local).AddTicks(5775), new DateTime(2022, 1, 16, 17, 6, 26, 499, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 499, DateTimeKind.Local).AddTicks(5807), new DateTime(2022, 1, 16, 17, 6, 26, 499, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2527), new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2547), new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2551), new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2555), new DateTime(2022, 1, 16, 17, 6, 26, 500, DateTimeKind.Local).AddTicks(2556) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "598d4705-4558-4216-888c-3801dfabab94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "8b22a296-4988-4923-9be4-1c441e85d33c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7be67c7a-8600-4e8e-85eb-9f3d8ee96c43", "AQAAAAEAACcQAAAAEMVoP0OCkWMB+9q7YyxCV/5fPhDBxrTtPQQCLzD3RlBbVOD6uRX77pY45Wv5KIjTCA==", "16532aa2-df3c-43be-a8dc-5cab55ec0c17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a0dfeb-53a0-445c-b8c0-fdbc286fc4fa", "AQAAAAEAACcQAAAAEKfvSPv4THSkY6xJeVgKUdcGC50rWvqKzeIizvcVoGryRi8+XErvijyZnBiS31ymIA==", "ec959aab-5b09-4e23-b954-c091e5e39293" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 937, DateTimeKind.Local).AddTicks(7806), new DateTime(2022, 1, 16, 17, 6, 6, 941, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 941, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 1, 16, 17, 6, 6, 941, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 944, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 1, 16, 17, 6, 6, 944, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 944, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 1, 16, 17, 6, 6, 944, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4292), new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4317), new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 1, 16, 17, 6, 6, 945, DateTimeKind.Local).AddTicks(4330) });
        }
    }
}
