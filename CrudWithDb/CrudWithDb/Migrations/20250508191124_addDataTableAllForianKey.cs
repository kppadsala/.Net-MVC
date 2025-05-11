using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudWithDb.Migrations
{
    /// <inheritdoc />
    public partial class addDataTableAllForianKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Emp",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 1,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 2,
                column: "LanguageId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 3,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Emp",
                keyColumn: "id",
                keyValue: 4,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "Indian Language", "Hindi" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "USA Language", "English" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "France Language", "French" });

            migrationBuilder.CreateIndex(
                name: "IX_Emp_LanguageId",
                table: "Emp",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Language_LanguageId",
                table: "Emp",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Language_LanguageId",
                table: "Emp");

            migrationBuilder.DropIndex(
                name: "IX_Emp_LanguageId",
                table: "Emp");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Emp");

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "indian language", "hindi" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "usa language", "english" });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Desc", "Title" },
                values: new object[] { "france language", "france" });
        }
    }
}
