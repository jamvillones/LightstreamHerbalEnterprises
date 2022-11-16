using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class added_payment_record : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductInventoryId",
                table: "SoldProduct");

            migrationBuilder.RenameColumn(
                name: "ProductInventoryId",
                table: "SoldProduct",
                newName: "ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProduct_ProductInventoryId",
                table: "SoldProduct",
                newName: "IX_SoldProduct_ProductVariantId");

            migrationBuilder.CreateTable(
                name: "PaymentRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRecord_Sale_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRecord_SaleId",
                table: "PaymentRecord",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductVariantId",
                table: "SoldProduct",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductVariantId",
                table: "SoldProduct");

            migrationBuilder.DropTable(
                name: "PaymentRecord");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId",
                table: "SoldProduct",
                newName: "ProductInventoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SoldProduct_ProductVariantId",
                table: "SoldProduct",
                newName: "IX_SoldProduct_ProductInventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoldProduct_ProductVariant_ProductInventoryId",
                table: "SoldProduct",
                column: "ProductInventoryId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
