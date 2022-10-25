using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Unit",
                newName: "SingularName");

            migrationBuilder.AddColumn<string>(
                name: "Abbreviation",
                table: "Unit",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PluralName",
                table: "Unit",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abbreviation",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "PluralName",
                table: "Unit");

            migrationBuilder.RenameColumn(
                name: "SingularName",
                table: "Unit",
                newName: "Name");
        }
    }
}
