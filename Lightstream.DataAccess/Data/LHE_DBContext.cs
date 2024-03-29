﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Lightstream.DataAccess.Models;

namespace Lightstream.DataAccess.Data
{
    public partial class LHE_DBContext : DbContext
    {
        public LHE_DBContext()
        {
        }

        public LHE_DBContext(DbContextOptions<LHE_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;
        public virtual DbSet<AuditTrail> AuditTrails { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductVariant> ProductVariants { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SoldProduct> SoldProducts { get; set; } = null!;
        public virtual DbSet<ProductionHistory> ProducedProducts { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LHE_DB;Trusted_Connection=True; Integrated Security=true;");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);

            configurationBuilder.Properties<decimal>().HavePrecision(18, 4);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductionHistory>(entity => { entity.ToTable(nameof(ProductionHistory)); });
            modelBuilder.Entity<Sale>(entity => { entity.ToTable(nameof(Sale)); });
            modelBuilder.Entity<SoldProduct>(entity => { entity.ToTable(nameof(SoldProduct)); });
            modelBuilder.Entity<Customer>(entity => { entity.ToTable(nameof(Customer)); });

            modelBuilder.Entity<Conversion>(entity =>
            {
                entity.ToTable("Conversion");

                entity.HasIndex(e => e.FromUnitId, "IX_Conversion_FromUnitId");

                entity.HasIndex(e => e.ToUnitId, "IX_Conversion_ToUnitId");

                entity.HasOne(d => d.FromUnit)
                    .WithMany(p => p.ConversionFromUnits)
                    .HasForeignKey(d => d.FromUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Conversion_Unit_From");

                entity.HasOne(d => d.ToUnit)
                    .WithMany(p => p.ConversionToUnits)
                    .HasForeignKey(d => d.ToUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Conversion_Unit_To");
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.HasIndex(e => e.UnitMeasurementId, "IX_Ingredient_UnitMeasurementId");

                entity.HasOne(d => d.UnitMeasurement)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey(d => d.UnitMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ingredients_Unit");

                entity.Property(p => p.Cost).HasPrecision(18, 2);

                //entity.Navigation(i => i.UnitMeasurement).AutoInclude();
                //entity.Navigation(i => i.PurchaseOrders).AutoInclude();
                //entity.Navigation(i => i.Recipes).AutoInclude();
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.FullName)
                    .HasMaxLength(101)
                    .HasComputedColumnSql("(concat([FIRSTNAME],' ',[LASTNAME]))", false);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                //entity.Navigation(i => i.ProductVariants).AutoInclude();
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.HasIndex(e => e.IngredientId, "IX_ProductToIngredientBridge_IngredientId");

                entity.HasIndex(e => e.ProductId, "IX_ProductToIngredientBridge_ProductId");                

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.IngredientId)
                    .HasConstraintName("FK_Recipe_Ingredients");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Recipe_Products");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");
            });

            modelBuilder.Entity<ProductVariant>(ent =>
            {
                ent.Property(e => e.Price).HasPrecision(18, 2);
                ent.Property(e => e.Cost).HasPrecision(18, 2);
            });

            modelBuilder.Entity<PurchaseOrder>(e => e.Property(e => e.Cost).HasPrecision(18, 2));
            modelBuilder.Entity<SupplierToIngredient>(si => si.Property(s => s.Cost).HasPrecision(18, 2));

            //modelBuilder.Entity<ProductVariant>(ent => ent.Property(e => e.Price).HasPrecision(18, 2));

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
