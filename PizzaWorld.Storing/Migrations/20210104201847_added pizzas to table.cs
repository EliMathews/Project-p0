using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addedpizzastotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityID",
                table: "APizzaModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APizzaModel",
                table: "APizzaModel");

            migrationBuilder.RenameTable(
                name: "APizzaModel",
                newName: "Pizzas");

            migrationBuilder.RenameIndex(
                name: "IX_APizzaModel_OrderEntityID",
                table: "Pizzas",
                newName: "IX_Pizzas_OrderEntityID");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "EntityID");

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "EntityID", "Crust", "Name", "OrderEntityID", "Size" },
                values: new object[,]
                {
                    { 1L, null, "Cheese Pizza", null, null },
                    { 2L, null, "Hawaiian Pizza", null, null },
                    { 3L, null, "Meat Pizza", null, null },
                    { 4L, null, "Pepperoni Pizza", null, null },
                    { 5L, null, "Veggie Pizza", null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID",
                principalTable: "Order",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "EntityID",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "APizzaModel");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_OrderEntityID",
                table: "APizzaModel",
                newName: "IX_APizzaModel_OrderEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APizzaModel",
                table: "APizzaModel",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityID",
                table: "APizzaModel",
                column: "OrderEntityID",
                principalTable: "Order",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
