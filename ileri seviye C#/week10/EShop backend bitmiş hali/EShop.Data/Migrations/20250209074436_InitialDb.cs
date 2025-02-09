using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9acdf5-e36d-4579-9404-8f79c789f360", "AQAAAAIAAYagAAAAELSMVVVegcb8YvI4BuYOaStOM8gmV7MQzmFa6Dn1jZWoF/mAlDwuofTFgZnY5m6bfg==", "d166477c-e6b0-4b8a-9c2d-2fa1fbf18034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69608f67-3eb4-4ad0-a9f3-a575a55436b3", "AQAAAAIAAYagAAAAEE1zkTJnuI5JynFNEVnCIrIChcu0MKzLWwmHn9qrLczRYRAEyWzcn4KVqY93X5IMgQ==", "286242d9-2a5e-49df-a57b-1a6abb823952" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 153, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 153, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 9, 7, 44, 36, 77, DateTimeKind.Utc).AddTicks(3180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2fe392f-4f60-4963-ba3a-ea52b71fb53e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f02e72d-490e-4e4e-b1b6-101e5d490d47", "AQAAAAIAAYagAAAAEMy1AgTQvpZl8uFQ5nTpm/QOlVwwiBtd0EM233I9btBg5OL21h4ognuKu+VFtIBKoA==", "899093da-a475-4d85-9aa3-20c59b5fc8a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4757375-a497-496b-85dc-a510027bd9b1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c21c34-9ccf-460e-9ed2-5d90af948720", "AQAAAAIAAYagAAAAENm81w/aVmUtD/VET2p0sA3JnXDlD37G6Un0tSuGQ8Bb9/RKwzqBwBtNOwL1XueuJA==", "6def098d-ebd0-41aa-a986-352341e85a5a" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 467, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 467, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2025, 2, 2, 7, 55, 40, 318, DateTimeKind.Utc).AddTicks(5787));
        }
    }
}
