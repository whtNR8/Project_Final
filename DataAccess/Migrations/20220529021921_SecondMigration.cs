using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentAge", "StudentCareer", "StudentName", "StudentSemester" },
                values: new object[] { 1078, 15, "Medicina", "Julian Alvarez", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1078);

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentAge", "StudentCareer", "StudentName", "StudentSemester" },
                values: new object[] { 10, 15, "Medicina", "Julian Alvarez", 6 });
        }
    }
}
