using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace March14Assignments.Models;

public partial class CgContext : DbContext
{
    public CgContext()
    {
    }

    public CgContext(DbContextOptions<CgContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VIVEK-SRIVASTAV\\SQLEXPRESS;Database=cgefdb1;Trusted_Connection=True;TrustServerCertificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasIndex(e => e.AuthorId, "IX_Courses_AuthorId");

            entity.Property(e => e.Level).HasColumnName("level");

            entity.HasOne(d => d.Author).WithMany(p => p.Courses).HasForeignKey(d => d.AuthorId);

            entity.HasMany(d => d.Students).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseStudent",
                    r => r.HasOne<Student>().WithMany().HasForeignKey("StudentsId"),
                    l => l.HasOne<Course>().WithMany().HasForeignKey("CoursesId"),
                    j =>
                    {
                        j.HasKey("CoursesId", "StudentsId");
                        j.ToTable("CourseStudent");
                        j.HasIndex(new[] { "StudentsId" }, "IX_CourseStudent_StudentsId");
                    });
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
