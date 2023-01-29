﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelSozlesmeTakip.DAL.Context;

#nullable disable

namespace PersonelSozlesmeTakip.DAL.Migrations
{
    [DbContext(typeof(PersonelSozlesmeContext))]
    [Migration("20230129161536_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Campus", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<Guid>("UniversityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Campuses");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.DepartmentPerson", b =>
                {
                    b.Property<Guid>("PersonelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PersonelId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentPerson");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("CampusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<Guid>("UniversityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Personel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ContractEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntegratedPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.RolePersonel", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<Guid>("PersonelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "PersonelId");

                    b.HasIndex("PersonelId");

                    b.ToTable("RolePersonel");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.University", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CerateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Admin", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Campus", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.University", "University")
                        .WithMany("Campuses")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Department", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.DepartmentPerson", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Department", "Department")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Personel", "Personel")
                        .WithMany("Departments")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Faculty", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Admin", "Admin")
                        .WithMany("Faculties")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Campus", "Campus")
                        .WithMany("Faculties")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Campus");

                    b.Navigation("University");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Personel", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Faculty", "Faculty")
                        .WithMany("Personels")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.RolePersonel", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Personel", "Personel")
                        .WithMany("Roles")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Role", "Role")
                        .WithMany("Personels")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.University", b =>
                {
                    b.HasOne("PersonelSozlesmeTakip.Entities.Concreate.Admin", "Admin")
                        .WithMany("Universities")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Admin", b =>
                {
                    b.Navigation("Faculties");

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Campus", b =>
                {
                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Department", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Faculty", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Personels");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Personel", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.Role", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("PersonelSozlesmeTakip.Entities.Concreate.University", b =>
                {
                    b.Navigation("Campuses");

                    b.Navigation("Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
