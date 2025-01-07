﻿// <auto-generated />
using System;
using Emp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Emp.Domain.Entities.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f80bfa7-c328-4585-8731-a2480befb140"),
                            Date = new DateTime(2025, 1, 5, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8172),
                            EmployeeId = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("d4455b99-0c70-48ab-a788-df9540994b03"),
                            Date = new DateTime(2025, 1, 3, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8203),
                            EmployeeId = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("d020971a-025e-44b8-92ec-ef85e1dc14e5"),
                            Date = new DateTime(2025, 1, 4, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8210),
                            EmployeeId = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("3b2fb565-18e7-4efa-a2a1-d1d89341e63d"),
                            Date = new DateTime(2025, 1, 6, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8243),
                            EmployeeId = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("503530a7-db1d-44c2-92fc-38b70c823e27"),
                            Date = new DateTime(2025, 1, 7, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8249),
                            EmployeeId = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("beb7c4bc-b6d4-4b1d-b0e0-bcdbbe52e8bf"),
                            Date = new DateTime(2025, 1, 5, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8252),
                            EmployeeId = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("4b8a5ebd-8c83-43cb-91e6-309e16d9fd01"),
                            Date = new DateTime(2025, 1, 3, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8258),
                            EmployeeId = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("04e85637-51a2-4c67-8d69-cc99ed67caae"),
                            Date = new DateTime(2025, 1, 4, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8261),
                            EmployeeId = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("3f40815b-6570-479b-9900-6be47ca7dcfe"),
                            Date = new DateTime(2025, 1, 6, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8267),
                            EmployeeId = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("e1b25349-3482-477a-bfe4-547855f126aa"),
                            Date = new DateTime(2025, 1, 7, 11, 24, 24, 333, DateTimeKind.Local).AddTicks(8270),
                            EmployeeId = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            Status = 1
                        });
                });

            modelBuilder.Entity("Emp.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeCode")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("beb50209-b60e-4aed-8750-2a1cbf384783"),
                            EmployeeCode = "E001",
                            Name = "Md. Sujad-ud Doula",
                            Salary = 35000.00m
                        },
                        new
                        {
                            Id = new Guid("a4f9d95d-f638-40bd-a5e8-85a6eefddfed"),
                            EmployeeCode = "E002",
                            Name = "John Doe",
                            Salary = 50000.00m
                        });
                });

            modelBuilder.Entity("Emp.Domain.Entities.Attendance", b =>
                {
                    b.HasOne("Emp.Domain.Entities.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Emp.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Attendances");
                });
#pragma warning restore 612, 618
        }
    }
}
