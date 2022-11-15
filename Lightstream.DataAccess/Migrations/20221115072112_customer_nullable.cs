using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    public partial class customer_nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Sale",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Customer_CustomerId",
                table: "Sale",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
