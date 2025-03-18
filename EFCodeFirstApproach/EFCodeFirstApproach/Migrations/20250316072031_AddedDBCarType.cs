using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class AddedDBCarType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarType",
                columns: new[] { "TypeID", "CreateAt", "Description", "TypeName" },
                values: new object[] { 1, new DateTime(2000, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Car Is 4*4", "OffRoaded" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarType",
                keyColumn: "TypeID",
                keyValue: 1);
        }
    }
}
