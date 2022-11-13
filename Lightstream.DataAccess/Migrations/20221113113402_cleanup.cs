using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductInventory_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductInventory_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.DropTable(
                name: "MaterialInventories");

            migrationBuilder.DropTable(
                name: "ProductInventory");

            migrationBuilder.DropIndex(
                name: "IX_ProductionHistory_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropIndex(
                name: "IX_ProductionHistory_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductInventoryId",
                table: "SoldProduct",
                column: "ProductInventoryId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductionHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductInventoryId",
                table: "ProductionHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaterialInventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialInventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialInventories_ProductVariant_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInventory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHistory_ProductId",
                table: "ProductionHistory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHistory_ProductInventoryId",
                table: "ProductionHistory",
                column: "ProductInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialInventories_ProductVariantId",
                table: "MaterialInventories",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

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
    }
}
