﻿// <auto-generated />
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20220529021921_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 3,
                            ProductCategory = "Electrónica",
                            ProductName = "Celular",
                            ProductPrice = 1000,
                            ProductStock = 100
                        },
                        new
                        {
                            ProductId = 8,
                            ProductCategory = "Alimentos",
                            ProductName = "Gomitas",
                            ProductPrice = 100,
                            ProductStock = 10
                        },
                        new
                        {
                            ProductId = 6,
                            ProductCategory = "Juguetería",
                            ProductName = "Motos",
                            ProductPrice = 10,
                            ProductStock = 1
                        });
                });

            modelBuilder.Entity("Entities.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<int>("StudentAge")
                        .HasColumnType("int");

                    b.Property<string>("StudentCareer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentSemester")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1078,
                            StudentAge = 15,
                            StudentCareer = "Medicina",
                            StudentName = "Julian Alvarez",
                            StudentSemester = 6
                        },
                        new
                        {
                            StudentId = 4,
                            StudentAge = 34,
                            StudentCareer = "Mecánica",
                            StudentName = "Mateo Fernandez",
                            StudentSemester = 8
                        },
                        new
                        {
                            StudentId = 99,
                            StudentAge = 7,
                            StudentCareer = "Fisioterapia",
                            StudentName = "Lucas Perez",
                            StudentSemester = 78
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
