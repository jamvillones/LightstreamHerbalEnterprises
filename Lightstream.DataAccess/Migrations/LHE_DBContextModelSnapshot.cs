﻿// <auto-generated />
using System;
using Lightstream.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    [DbContext(typeof(LHE_DBContext))]
    partial class LHE_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lightstream.DataAccess.Models.Conversion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FromUnitId")
                        .HasColumnType("int");

                    b.Property<int>("ToUnitId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "FromUnitId" }, "IX_Conversion_FromUnitId");

                    b.HasIndex(new[] { "ToUnitId" }, "IX_Conversion_ToUnitId");

                    b.ToTable("Conversion", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UnitMeasurementId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UnitMeasurementId" }, "IX_Ingredient_UnitMeasurementId");

                    b.ToTable("Ingredient", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(101)
                        .HasColumnType("nvarchar(101)")
                        .HasComputedColumnSql("(concat([FIRSTNAME],' ',[LASTNAME]))", false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ConversionId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Qty")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IngredientId" }, "IX_ProductToIngredientBridge_IngredientId");

                    b.HasIndex(new[] { "ProductId" }, "IX_ProductToIngredientBridge_ProductId");

                    b.HasIndex(new[] { "ConversionId" }, "IX_Recipe_ConversionId");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Unit", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Conversion", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Unit", "FromUnit")
                        .WithMany("ConversionFromUnits")
                        .HasForeignKey("FromUnitId")
                        .IsRequired()
                        .HasConstraintName("FK_Conversion_Unit_From");

                    b.HasOne("Lightstream.DataAccess.Models.Unit", "ToUnit")
                        .WithMany("ConversionToUnits")
                        .HasForeignKey("ToUnitId")
                        .IsRequired()
                        .HasConstraintName("FK_Conversion_Unit_To");

                    b.Navigation("FromUnit");

                    b.Navigation("ToUnit");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Ingredient", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Unit", "UnitMeasurement")
                        .WithMany("Ingredients")
                        .HasForeignKey("UnitMeasurementId")
                        .IsRequired()
                        .HasConstraintName("FK_Ingredients_Unit");

                    b.Navigation("UnitMeasurement");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Recipe", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Conversion", "Conversion")
                        .WithMany("Recipes")
                        .HasForeignKey("ConversionId")
                        .HasConstraintName("FK_Recipe_Conversion");

                    b.HasOne("Lightstream.DataAccess.Models.Ingredient", "Ingredient")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_Ingredients");

                    b.HasOne("Lightstream.DataAccess.Models.Product", "Product")
                        .WithMany("Recipes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Recipe_Products");

                    b.Navigation("Conversion");

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Conversion", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Ingredient", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Product", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Unit", b =>
                {
                    b.Navigation("ConversionFromUnits");

                    b.Navigation("ConversionToUnits");

                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
