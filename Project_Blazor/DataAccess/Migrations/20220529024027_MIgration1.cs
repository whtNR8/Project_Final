using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class MIgration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1078);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductCategory", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[] { "Alimentos", "Gomitas", 100, 10 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCategory", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[] { 9, "Juguetería", "Motos", 10, 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentAge", "StudentCareer", "StudentName", "StudentSemester" },
                values: new object[,]
                {
                    { 1, 15, "Medicina", "Julian Alvarez", 6 },
                    { 3, 34, "Mecánica", "Mateo Fernandez", 8 },
                    { 5, 7, "Fisioterapia", "Lucas Perez", 78 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "ProductCategory", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[] { "Juguetería", "Motos", 10, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCategory", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[] { 8, "Alimentos", "Gomitas", 100, 10 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "StudentAge", "StudentCareer", "StudentName", "StudentSemester" },
                values: new object[,]
                {
                    { 4, 34, "Mecánica", "Mateo Fernandez", 8 },
                    { 99, 7, "Fisioterapia", "Lucas Perez", 78 },
                    { 1078, 15, "Medicina", "Julian Alvarez", 6 }
                });
        }
    }
}
