using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class AddedDBCarBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarBrand",
                columns: new[] { "BrandID", "BrandName", "Country", "CreatedAt" },
                values: new object[] { 1, "Honda", "Japan", new DateTime(1955, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarBrand",
                keyColumn: "BrandID",
                keyValue: 1);
        }
    }
}
