using System;
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

        public virtual DbSet<Conversion> Conversions { get; set; } = null!;
        public virtual DbSet<Ingredient> Ingredients { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LHE_DB;Trusted_Connection=True; Integrated Security=true;");
            }
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);

            configurationBuilder.Properties<decimal>().HavePrecision(18, 2);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversion>(entity =>
            {
                entity.ToTable("Conversion");

                entity.HasIndex(e => e.FromUnitId, "IX_Conversion_FromUnitId");

                entity.HasIndex(e => e.ToUnitId, "IX_Conversion_ToUnitId");

                //entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

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

                //entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UnitMeasurement)
                    .WithMany(p => p.Ingredients)
                    .HasForeignKey(d => d.UnitMeasurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ingredients_Unit");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                //entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .HasMaxLength(101)
                    .HasComputedColumnSql("(concat([FIRSTNAME],' ',[LASTNAME]))", false);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                //entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("Recipe");

                entity.HasIndex(e => e.IngredientId, "IX_ProductToIngredientBridge_IngredientId");

                entity.HasIndex(e => e.ProductId, "IX_ProductToIngredientBridge_ProductId");

                entity.HasIndex(e => e.ConversionId, "IX_Recipe_ConversionId");

                entity.HasOne(d => d.Conversion)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.ConversionId)
                    .HasConstraintName("FK_Recipe_Conversion");

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

                //entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
