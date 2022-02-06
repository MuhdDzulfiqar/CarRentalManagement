using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
