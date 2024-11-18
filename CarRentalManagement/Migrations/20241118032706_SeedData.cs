using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1597), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1611), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1614), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1615), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1787), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1787), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1789), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1853), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1854), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1855), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1856), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1857), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 11, 18, 11, 27, 5, 225, DateTimeKind.Local).AddTicks(1859), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
