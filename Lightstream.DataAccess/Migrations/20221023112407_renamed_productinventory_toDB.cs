using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class renamed_productinventory_toDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Product_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductInventories_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductInventories_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories");

            migrationBuilder.RenameTable(
                name: "ProductInventories",
                newName: "ProductInventory");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventory",
                newName: "IX_ProductInventory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_ProductInventory_ProductInventoryId",
                table: "ProductionHistory",
                column: "ProductInventoryId",
                principalTable: "ProductInventory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductInventory_ProductInventoryId",
                table: "SoldProduct",
                column: "ProductInventoryId",
                principalTable: "ProductInventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductInventory_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductInventory_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory");

            migrationBuilder.RenameTable(
                name: "ProductInventory",
                newName: "ProductInventories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Product_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_ProductInventories_ProductInventoryId",
                table: "ProductionHistory",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductInventories_ProductInventoryId",
                table: "SoldProduct",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
