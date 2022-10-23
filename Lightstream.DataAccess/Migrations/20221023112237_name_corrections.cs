using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class name_corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_Sales_Customers_CustomerId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Login_LoginId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProducts_ProductInventories_ProductInventoryId",
                table: "SoldProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProducts_Sales_SaleId",
                table: "SoldProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoldProducts",
                table: "SoldProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProducedProduct",
                table: "ProducedProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "SoldProducts",
                newName: "SoldProduct");

            migrationBuilder.RenameTable(
                name: "Sales",
                newName: "Sale");

            migrationBuilder.RenameTable(
                name: "ProducedProduct",
                newName: "ProductionHistory");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProducts_SaleId",
                table: "SoldProduct",
                newName: "IX_SoldProduct_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProducts_ProductInventoryId",
                table: "SoldProduct",
                newName: "IX_SoldProduct_ProductInventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_LoginId",
                table: "Sale",
                newName: "IX_Sale_LoginId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CustomerId",
                table: "Sale",
                newName: "IX_Sale_CustomerId");

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
                name: "PK_SoldProduct",
                table: "SoldProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionHistory",
                table: "ProductionHistory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

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
                name: "FK_ProductionHistory_ProductInventories_ProductInventoryId",
                table: "ProductionHistory",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductInventories_ProductInventoryId",
                table: "SoldProduct",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_Sale_SaleId",
                table: "SoldProduct",
                column: "SaleId",
                principalTable: "Sale",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Login_LoginId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductInventories_ProductInventoryId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Login_LoginId",
                table: "Sale");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductInventories_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_Sale_SaleId",
                table: "SoldProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SoldProduct",
                table: "SoldProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionHistory",
                table: "ProductionHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "SoldProduct",
                newName: "SoldProducts");

            migrationBuilder.RenameTable(
                name: "Sale",
                newName: "Sales");

            migrationBuilder.RenameTable(
                name: "ProductionHistory",
                newName: "ProducedProduct");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProduct_SaleId",
                table: "SoldProducts",
                newName: "IX_SoldProducts_SaleId");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProduct_ProductInventoryId",
                table: "SoldProducts",
                newName: "IX_SoldProducts_ProductInventoryId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoldProducts",
                table: "SoldProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                table: "Sales",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProducedProduct",
                table: "ProducedProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProducts_ProductInventories_ProductInventoryId",
                table: "SoldProducts",
                column: "ProductInventoryId",
                principalTable: "ProductInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProducts_Sales_SaleId",
                table: "SoldProducts",
                column: "SaleId",
                principalTable: "Sales",
                principalColumn: "Id");
        }
    }
}
