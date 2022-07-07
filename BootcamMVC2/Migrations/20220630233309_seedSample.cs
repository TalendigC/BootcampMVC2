using Microsoft.EntityFrameworkCore.Migrations;

namespace BootcamMVC2.Migrations
{
    public partial class seedSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 1, "Santos", "Gerson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
