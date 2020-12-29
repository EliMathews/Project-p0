using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addstorename4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 2L,
                column: "Name",
                value: "One");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityID",
                keyValue: 3L,
                column: "Name",
                value: "Two");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Stores");
        }
    }
}
