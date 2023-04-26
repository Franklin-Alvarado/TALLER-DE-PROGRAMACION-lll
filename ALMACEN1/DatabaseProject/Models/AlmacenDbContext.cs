using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseProject.Models;

public partial class AlmacenDbContext : DbContext
{
    public AlmacenDbContext()
    {
    }

    public AlmacenDbContext(DbContextOptions<AlmacenDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Buy> Buys { get; set; }

    public virtual DbSet<BuyDetail> BuyDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-MSLULVE; Database=AlmacenDB; Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Buy>(entity =>
        {
            entity.Property(e => e.Supplier).HasMaxLength(50);
        });

        modelBuilder.Entity<BuyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Buy_Detail");

            entity.Property(e => e.IdBuy).HasColumnName("Id_Buy");
            entity.Property(e => e.IdProduct).HasColumnName("Id_Product");
            entity.Property(e => e.PriceUnit)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Price_ Unit");

            entity.HasOne(d => d.IdBuyNavigation).WithMany()
                .HasForeignKey(d => d.IdBuy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Buy_Detail_Buys1");

            entity.HasOne(d => d.IdProductNavigation).WithMany()
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Buy_Detail_Product1");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.BrandModel)
                .HasMaxLength(50)
                .HasColumnName("Brand_Model");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.IdType).HasColumnName("Id_Type");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.CodeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Code)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Stock");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Type");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.CodeProduct);

            entity.ToTable("Stock");

            entity.Property(e => e.CodeProduct)
                .ValueGeneratedNever()
                .HasColumnName("Code_Product");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.ToTable("Type");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
