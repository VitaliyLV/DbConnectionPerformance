using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFConnection.Migrations
{
    /// <inheritdoc />
    public partial class AddMarks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentMarks",
                columns: new[] { "Id", "StudentId", "SubjectId", "TotalScore" },
                values: new object[,]
                {
                    { 16, 6, 1, 6 },
                    { 17, 6, 4, 2 },
                    { 18, 7, 5, 7 },
                    { 19, 7, 1, 4 },
                    { 20, 8, 4, 5 },
                    { 21, 8, 5, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentMarks",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
