using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 9, 2, 31, 37, 696, DateTimeKind.Local).AddTicks(3981), new DateTime(2025, 1, 9, 2, 31, 37, 696, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 9, 2, 31, 37, 696, DateTimeKind.Local).AddTicks(4002), new DateTime(2025, 1, 9, 2, 31, 37, 696, DateTimeKind.Local).AddTicks(4002) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2025, 1, 9, 2, 14, 17, 867, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 1, 9, 2, 14, 17, 867, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 9, 2, 14, 17, 867, DateTimeKind.Local).AddTicks(1962), new DateTime(2025, 1, 9, 2, 14, 17, 867, DateTimeKind.Local).AddTicks(1963) });
        }
    }
}
