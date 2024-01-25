using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFConnection.Migrations
{
    /// <inheritdoc />
    public partial class PopulateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FacultyId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, null, "Albus", "Dumbledore" },
                    { 2, null, "Minerva", "McGonagall" },
                    { 3, null, "Alastor", "Moody" },
                    { 4, null, "Filius", "Flitwick" },
                    { 5, null, "Severus", "Snape" },
                    { 6, null, "Pomona", "Sprout" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "HeadId", "Name", "Points" },
                values: new object[,]
                {
                    { 1, 2, "Gryffindor", 0 },
                    { 2, 4, "Ravenclaw", 0 },
                    { 3, 6, "Hufflepuff", 0 },
                    { 4, 5, "Slytherin", 0 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "ProfessorId", "StudentId" },
                values: new object[,]
                {
                    { 1, "Defence Against the Dark Arts", 3, null },
                    { 2, "Transfiguration", 2, null },
                    { 3, "Potions", 5, null },
                    { 4, "Herbology", 6, null },
                    { 5, "Charms", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "Grade", "InFacultyId", "LastName" },
                values: new object[,]
                {
                    { 1, "Harry", 4, 1, "Potter" },
                    { 2, "Ron", 4, 1, "Weasley" },
                    { 3, "Hermione", 4, 1, "Granger" },
                    { 4, "Colin", 2, 1, "Creevey" },
                    { 5, "Hannah", 3, 2, "Abbott" },
                    { 6, "Ernie", 1, 2, "Macmillan" },
                    { 7, "Vincent", 4, 4, "Crabbe" },
                    { 8, "Gregory", 4, 4, "Goyle" },
                    { 9, "Cho", 3, 3, "Chang" },
                    { 10, "Padma", 3, 3, "Patil" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
