using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class remove_prodhistory_ingredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionHistory_Ingredient_IngredientId",
                table: "ProductionHistory");

            migrationBuilder.DropIndex(
                name: "IX_ProductionHistory_IngredientId",
                table: "ProductionHistory");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "ProductionHistory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "ProductionHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHistory_IngredientId",
                table: "ProductionHistory",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionHistory_Ingredient_IngredientId",
                table: "ProductionHistory",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id");
        }
    }
}
