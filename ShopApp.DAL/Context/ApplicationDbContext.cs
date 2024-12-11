using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Entities;

namespace ShopApp.DAL.Context;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-3T4FVQ3\\SQLEXPRESS;Database=ShopDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(15)
                .HasColumnName("categoryname");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CreationUser).HasColumnName("creation_user");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteUser).HasColumnName("delete_user");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("modify_date");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Empid);

            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Address)
                .HasMaxLength(60)
                .HasColumnName("address");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .HasColumnName("country");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CreationUser).HasColumnName("creation_user");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteUser).HasColumnName("delete_user");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Firstname)
                .HasMaxLength(10)
                .HasColumnName("firstname");
            entity.Property(e => e.Hiredate)
                .HasColumnType("datetime")
                .HasColumnName("hiredate");
            entity.Property(e => e.Lastname)
                .HasMaxLength(20)
                .HasColumnName("lastname");
            entity.Property(e => e.Mgrid).HasColumnName("mgrid");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("modify_date");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(10)
                .HasColumnName("postalcode");
            entity.Property(e => e.Region)
                .HasMaxLength(15)
                .HasColumnName("region");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .HasColumnName("title");
            entity.Property(e => e.Titleofcourtesy)
                .HasMaxLength(25)
                .HasColumnName("titleofcourtesy");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CreationUser).HasColumnName("creation_user");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteUser).HasColumnName("delete_user");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Discontinued).HasColumnName("discontinued");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("modify_date");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            entity.Property(e => e.Productname)
                .HasMaxLength(40)
                .HasColumnName("productname");
            entity.Property(e => e.Supplierid).HasColumnName("supplierid");
            entity.Property(e => e.Unitprice)
                .HasColumnType("money")
                .HasColumnName("unitprice");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.Supplierid).HasColumnName("supplierid");
            entity.Property(e => e.Address)
                .HasMaxLength(60)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Companyname)
                .HasMaxLength(40)
                .HasColumnName("companyname");
            entity.Property(e => e.Contactname)
                .HasMaxLength(30)
                .HasColumnName("contactname");
            entity.Property(e => e.Contacttitle)
                .HasMaxLength(30)
                .HasColumnName("contacttitle");
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .HasColumnName("country");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.CreationUser).HasColumnName("creation_user");
            entity.Property(e => e.DeleteDate)
                .HasColumnType("datetime")
                .HasColumnName("delete_date");
            entity.Property(e => e.DeleteUser).HasColumnName("delete_user");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Fax)
                .HasMaxLength(24)
                .HasColumnName("fax");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("modify_date");
            entity.Property(e => e.ModifyUser).HasColumnName("modify_user");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasColumnName("phone");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(10)
                .HasColumnName("postalcode");
            entity.Property(e => e.Region)
                .HasMaxLength(15)
                .HasColumnName("region");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
