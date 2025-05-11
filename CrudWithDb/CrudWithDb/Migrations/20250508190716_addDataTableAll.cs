using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrudWithDb.Migrations
{
    /// <inheritdoc />
    public partial class addDataTableAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emp",
                columns: new[] { "id", "city", "name", "salary", "state" },
                values: new object[,]
                {
                    { 1, "surat", "krunal", 20000, "Gujarat" },
                    { 2, "gawali", "keval", 30000, "MP" },
                    { 3, "wajipur", "samit", 50000, "Delhi" },
                    { 4, "mumbai", "aakash", 60000, "maharashtra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
