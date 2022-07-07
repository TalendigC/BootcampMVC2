using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcamMVC2.Migrations
{
    public partial class seedSample1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 2, "Arias", "Heger" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 3, "Dominguez", "Jose" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
