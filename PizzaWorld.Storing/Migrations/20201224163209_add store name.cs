using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addstorename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stores",
                column: "EntityID",
                value: 2L);

            migrationBuilder.InsertData(
                table: "Stores",
                column: "EntityID",
                value: 3L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 3L);
        }
    }
}
