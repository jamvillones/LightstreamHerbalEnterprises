using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Login_LoginId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductInventory_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Login_LoginId",
                table: "Sale");

            migrationBuilder.DropTable(
                name: "SoldItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionHistory",
                table: "ProductionHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "ProductionHistory",
                newName: "ProducedProduct");

            migrationBuilder.RenameTable(
                name: "ProductInventory",
                newName: "ProductInventories");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_LoginId",
                table: "Sales",
                newName: "IX_Sales_LoginId");

            migrationBuilder.RenameIndex(
                name: "IX_Sale_CustomerId",
                table: "Sales",
                newName: "IX_Sales_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionHistory_ProductInventoryId",
                table: "ProducedProduct",
                newName: "IX_ProducedProduct_ProductInventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionHistory_ProductId",
                table: "ProducedProduct",
                newName: "IX_ProducedProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionHistory_LoginId",
                table: "ProducedProduct",
                newName: "IX_ProducedProduct_LoginId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProducedProduct",
                table: "ProducedProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SoldProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoldPrice = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    SoldQty = table.Column<int>(type: "int", nullable: false),
                    ProductInventoryId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldProducts_ProductInventories_ProductInventoryId",
                        column: x => x.ProductInventoryId,
                        principalTable: "ProductInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoldProducts_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoldProducts_ProductInventoryId",
                table: "SoldProducts",
                column: "ProductInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldProducts_SaleId",
                table: "SoldProducts",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProducedProduct_Login_LoginId",
                table: "ProducedProduct",
                column: "LoginId",
                principalTable: "Login",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProducedProduct_Product_ProductId",
                table: "ProducedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducedProduct_ProductInventories_ProductInventoryId",
                table: "ProducedProduct",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Product_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Login_LoginId",
                table: "Sales",
                column: "LoginId",
                principalTable: "Login",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProducedProduct_Login_LoginId",
                table: "ProducedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducedProduct_Product_ProductId",
                table: "ProducedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducedProduct_ProductInventories_ProductInventoryId",
                table: "ProducedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Product_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Login_LoginId",
                table: "Sales");

            migrationBuilder.DropTable(
                name: "SoldProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProducedProduct",
                table: "ProducedProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "ProductInventories",
                newName: "ProductInventory");

            migrationBuilder.RenameTable(
                name: "ProducedProduct",
                newName: "ProductionHistory");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_LoginId",
                table: "Sale",
                newName: "IX_Sale_LoginId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CustomerId",
                table: "Sale",
                newName: "IX_Sale_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventory",
                newName: "IX_ProductInventory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProducedProduct_ProductInventoryId",
                table: "ProductionHistory",
                newName: "IX_ProductionHistory_ProductInventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProducedProduct_ProductId",
                table: "ProductionHistory",
                newName: "IX_ProductionHistory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProducedProduct_LoginId",
                table: "ProductionHistory",
                newName: "IX_ProductionHistory_LoginId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventory",
                table: "ProductInventory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionHistory",
                table: "ProductionHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SoldItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductInventoryId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: true),
                    SoldPrice = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    SoldQty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoldItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoldItem_ProductInventory_ProductInventoryId",
                        column: x => x.ProductInventoryId,
                        principalTable: "ProductInventory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoldItem_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoldItem_ProductInventoryId",
                table: "SoldItem",
                column: "ProductInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SoldItem_SaleId",
                table: "SoldItem",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Login_LoginId",
                table: "ProductionHistory",
                column: "LoginId",
                principalTable: "Login",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory",
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
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Login_LoginId",
                table: "Sale",
                column: "LoginId",
                principalTable: "Login",
                principalColumn: "Id");
        }
    }
}
