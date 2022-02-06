using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class updateddbvehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "e8cef36f-45bd-4b60-9eab-39ad3472947a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "48b04f6e-4313-486e-b59e-6ca82efd8ff8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1710ad8a-6815-45ac-bdb2-dcca997e939b", "AQAAAAEAACcQAAAAEAQneFfHahQqzCW2ii716YnSKVfML8ajkbxVuzllhN4ZOBgxPrEinlHZJXc+5o4s1A==", "35f98089-82fd-4986-8150-0a2e188bc2d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "s6d9f4v0-e72c-12es-0971-es2d21f0e898",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe02262-0263-4c99-8be1-e9d2ff326af8", "AQAAAAEAACcQAAAAEBEsuMrk7TwKiTYJ8TM0602ZtLe7G/pJxvosJLKGLHkcilxkt92iitzy8Xx2vd26QQ==", "3ee4f8a8-710a-42cf-bfcc-372a40294166" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 13, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 1, 16, 17, 6, 41, 16, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 16, DateTimeKind.Local).AddTicks(4971), new DateTime(2022, 1, 16, 17, 6, 41, 16, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(581), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(598), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6503), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6519), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 1, 16, 17, 6, 41, 18, DateTimeKind.Local).AddTicks(6528) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
