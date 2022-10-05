using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LightstreamHerbalEnterprise.Models
{
    public partial class Lightstream_DBContext : DbContext
    {
        public Lightstream_DBContext()
        {
        }

        public Lightstream_DBContext(DbContextOptions<Lightstream_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialProduct> MaterialProducts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EP1IGTA\\SQLEXPRESS;User ID=admin;Password=123;Database=Lightstream_DB;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UnitOfMeasurement).HasMaxLength(50);
            });

            modelBuilder.Entity<MaterialProduct>(entity =>
            {
                entity.ToTable("Material_Product");

                entity.Property(e => e.Detail).HasMaxLength(50);

                entity.Property(e => e.MaterialRequirment).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialProducts)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_Material_Product_Material");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MaterialProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Material_Product_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
