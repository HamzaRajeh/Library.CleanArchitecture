using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Models;

public partial class DblibraryContext : DbContext
{
    public DblibraryContext()
    {
    }

    public DblibraryContext(DbContextOptions<DblibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tbauthor> Tbauthors { get; set; }

    public virtual DbSet<Tbbook> Tbbooks { get; set; }

    public virtual DbSet<Tbcategory> Tbcategories { get; set; }

    public virtual DbSet<Tbprice> Tbprices { get; set; }

    public virtual DbSet<Tbpriod> Tbpriods { get; set; }

    public virtual DbSet<Tbrent> Tbrents { get; set; }

    public virtual DbSet<Tbstatus> Tbstatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-QFFH4D5I\\MSSQLSERVER2019;Database=DBlibrary;User Id=admins;Password=H@123654;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_100_CS_AS");

        modelBuilder.Entity<Tbauthor>(entity =>
        {
            entity.ToTable("TBAuthor");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Tbbook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TBBooks_1");

            entity.ToTable("TBBooks");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
            entity.Property(e => e.BooksImg)
                .HasColumnType("image")
                .HasColumnName("Books_IMG");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Guid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("GUID");

            entity.HasOne(d => d.Author).WithMany(p => p.Tbbooks)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_TBBooks_TBAuthor");

            entity.HasOne(d => d.Category).WithMany(p => p.Tbbooks)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TBBooks_TBCategory");
        });

        modelBuilder.Entity<Tbcategory>(entity =>
        {
            entity.ToTable("TBCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategioryDescription).HasColumnName("Categiory_Description");
        });

        modelBuilder.Entity<Tbprice>(entity =>
        {
            entity.ToTable("TBPrice");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.PriceLateBook).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.PriceRentBook).HasColumnType("numeric(38, 2)");
            entity.Property(e => e.PriodId).HasColumnName("PriodID");

            entity.HasOne(d => d.Book).WithMany(p => p.Tbprices)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_TBPrice_TBBooks");

            entity.HasOne(d => d.Priod).WithMany(p => p.Tbprices)
                .HasForeignKey(d => d.PriodId)
                .HasConstraintName("FK_TBPrice_TBPriod");
        });

        modelBuilder.Entity<Tbpriod>(entity =>
        {
            entity.ToTable("TBPriod");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Tbrent>(entity =>
        {
            entity.ToTable("TBRent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriodId).HasColumnName("PriodID");
            entity.Property(e => e.ReRentDate).HasColumnType("date");
            entity.Property(e => e.ReciveDate).HasColumnType("date");
            entity.Property(e => e.RentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Book).WithMany(p => p.Tbrents)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_TBRent_TBBooks");

            entity.HasOne(d => d.Priod).WithMany(p => p.Tbrents)
                .HasForeignKey(d => d.PriodId)
                .HasConstraintName("FK_TBRent_TBPriod");

            entity.HasOne(d => d.Status).WithMany(p => p.Tbrents)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_TBRent_TBStatus");
        });

        modelBuilder.Entity<Tbstatus>(entity =>
        {
            entity.ToTable("TBStatus");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
