﻿// <auto-generated />
using System;
using Lightstream.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lightstream.DataAccess.Migrations
{
    [DbContext(typeof(LHE_DBContext))]
    [Migration("20221112065556_purchase_order")]
    partial class purchase_order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "FromUnitId" }, "IX_Conversion_FromUnitId");

                    b.HasIndex(new[] { "ToUnitId" }, "IX_Conversion_ToUnitId");

                    b.ToTable("Conversion", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactDetails")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
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

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

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

                    b.Property<DateTime>("DateTimeRegistered")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Login", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.MaterialInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("MaterialInventories");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("UnitQtyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitQtyId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInventory", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTimeProduction")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoginId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductInventoryId")
                        .HasColumnType("int");

                    b.Property<int>("QtyProduced")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoginId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductInventoryId");

                    b.ToTable("ProductionHistory", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductVariant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductVariant");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("DateOrdered")
                        .HasColumnType("datetime2");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseOrder");
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
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IngredientId" }, "IX_ProductToIngredientBridge_IngredientId");

                    b.HasIndex(new[] { "ProductId" }, "IX_ProductToIngredientBridge_ProductId");

                    b.HasIndex(new[] { "ConversionId" }, "IX_Recipe_ConversionId");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoginId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LoginId");

                    b.ToTable("Sale", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.SoldProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductInventoryId")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<decimal>("SoldPrice")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("SoldQty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductInventoryId");

                    b.HasIndex("SaleId");

                    b.ToTable("SoldProduct", (string)null);
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactDetails")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.SupplierToIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("SupplierId");

                    b.ToTable("SupplierToIngredient");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("PluralName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SingularName")
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

            modelBuilder.Entity("Lightstream.DataAccess.Models.MaterialInventory", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Ingredient", "Ingredient")
                        .WithMany("MaterialInventories")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Product", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Unit", "UnitQty")
                        .WithMany("Products")
                        .HasForeignKey("UnitQtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnitQty");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductInventory", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductionHistory", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Login", "Login")
                        .WithMany("ProductionHistories")
                        .HasForeignKey("LoginId");

                    b.HasOne("Lightstream.DataAccess.Models.Product", "Product")
                        .WithMany("ProductionHistory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lightstream.DataAccess.Models.ProductInventory", null)
                        .WithMany("ProductionHistories")
                        .HasForeignKey("ProductInventoryId");

                    b.Navigation("Login");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductVariant", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Product", "Product")
                        .WithMany("ProductVariants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.PurchaseOrder", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Ingredient", "Ingredient")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lightstream.DataAccess.Models.Supplier", "Supplier")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Ingredient");

                    b.Navigation("Supplier");
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

            modelBuilder.Entity("Lightstream.DataAccess.Models.Sale", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lightstream.DataAccess.Models.Login", "Login")
                        .WithMany("Transactons")
                        .HasForeignKey("LoginId");

                    b.Navigation("Customer");

                    b.Navigation("Login");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.SoldProduct", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.ProductInventory", "ProductInventory")
                        .WithMany("SoldItems")
                        .HasForeignKey("ProductInventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lightstream.DataAccess.Models.Sale", null)
                        .WithMany("SoldItems")
                        .HasForeignKey("SaleId");

                    b.Navigation("ProductInventory");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.SupplierToIngredient", b =>
                {
                    b.HasOne("Lightstream.DataAccess.Models.Ingredient", "Ingredient")
                        .WithMany("SupplierToIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lightstream.DataAccess.Models.Supplier", "Supplier")
                        .WithMany("SupplierToIngredients")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Conversion", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Customer", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Ingredient", b =>
                {
                    b.Navigation("MaterialInventories");

                    b.Navigation("PurchaseOrders");

                    b.Navigation("Recipes");

                    b.Navigation("SupplierToIngredients");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Login", b =>
                {
                    b.Navigation("ProductionHistories");

                    b.Navigation("Transactons");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Product", b =>
                {
                    b.Navigation("ProductInventories");

                    b.Navigation("ProductVariants");

                    b.Navigation("ProductionHistory");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.ProductInventory", b =>
                {
                    b.Navigation("ProductionHistories");

                    b.Navigation("SoldItems");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Sale", b =>
                {
                    b.Navigation("SoldItems");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Supplier", b =>
                {
                    b.Navigation("PurchaseOrders");

                    b.Navigation("SupplierToIngredients");
                });

            modelBuilder.Entity("Lightstream.DataAccess.Models.Unit", b =>
                {
                    b.Navigation("ConversionFromUnits");

                    b.Navigation("ConversionToUnits");

                    b.Navigation("Ingredients");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
