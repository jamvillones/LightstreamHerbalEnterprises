using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class archivable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Archived",
                table: "ProductVariant",
                newName: "IsArchived");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "ProductInventory",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Ingredient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "ProductInventory");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductVariant",
                newName: "Archived");
        }
    }
}
