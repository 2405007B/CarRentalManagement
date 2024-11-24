using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "880d21dd-84d4-4c48-9b87-9d0ff3db1173", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEN/abj21aTG4+GAgbKG3UTti0LQg0n4YEmCevckk4avAyomXp6w7W+uoT7Xw1VjLpQ==", null, false, "a31b6216-e981-4f86-ae93-3f4bf65909ad", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5213), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5445), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5523), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 11, 25, 4, 16, 4, 528, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9616), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9699), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9703), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9704), new DateTime(2024, 11, 18, 11, 52, 10, 780, DateTimeKind.Local).AddTicks(9705) });
        }
    }
}
