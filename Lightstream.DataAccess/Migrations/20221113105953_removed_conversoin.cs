using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class removed_conversoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInventories_Ingredient_IngredientId",
                table: "MaterialInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Conversion",
                table: "Recipe");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "MaterialInventories",
                newName: "ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInventories_IngredientId",
                table: "MaterialInventories",
                newName: "IX_MaterialInventories_ProductVariantId");

            migrationBuilder.AddColumn<decimal>(
                name: "RequiredQty",
                table: "ProductVariant",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductionHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "ProductionHistory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantId",
                table: "ProductionHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Qty",
                table: "MaterialInventories",
                type: "decimal(18,4)",
                precision: 18,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHistory_IngredientId",
                table: "ProductionHistory",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHistory_ProductVariantId",
                table: "ProductionHistory",
                column: "ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInventories_ProductVariant_ProductVariantId",
                table: "MaterialInventories",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Ingredient_IngredientId",
                table: "ProductionHistory",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_ProductVariant_ProductVariantId",
                table: "ProductionHistory",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Conversion_ConversionId",
                table: "Recipe",
                column: "ConversionId",
                principalTable: "Conversion",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaterialInventories_ProductVariant_ProductVariantId",
                table: "MaterialInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Ingredient_IngredientId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_ProductVariant_ProductVariantId",
                table: "ProductionHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Conversion_ConversionId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_ProductionHistory_IngredientId",
                table: "ProductionHistory");

            migrationBuilder.DropIndex(
                name: "IX_ProductionHistory_ProductVariantId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "RequiredQty",
                table: "ProductVariant");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "ProductVariantId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "MaterialInventories");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId",
                table: "MaterialInventories",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialInventories_ProductVariantId",
                table: "MaterialInventories",
                newName: "IX_MaterialInventories_IngredientId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductionHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialInventories_Ingredient_IngredientId",
                table: "MaterialInventories",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Product_ProductId",
                table: "ProductionHistory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Conversion",
                table: "Recipe",
                column: "ConversionId",
                principalTable: "Conversion",
                principalColumn: "Id");
        }
    }
}
