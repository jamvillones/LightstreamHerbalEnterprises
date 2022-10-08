﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lightstream.Migrations
{
    public partial class removed_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Ingredient_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Ingredient_Product_Id",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_Ingredient_Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ingredient_Product_Id",
                table: "Ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
