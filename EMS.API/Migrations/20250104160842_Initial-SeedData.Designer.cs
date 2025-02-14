﻿// <auto-generated />
using System;
using Emp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EMS.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250104160842_Initial-SeedData")]
    partial class InitialSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("4510953c-aead-4a2e-91e8-4f006a3beda8"),
                            Date = new DateTime(2025, 1, 2, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4051),
                            EmployeeId = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("ba2e79dc-2274-444b-bcec-6a56c7caa65b"),
                            Date = new DateTime(2024, 12, 31, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4085),
                            EmployeeId = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("f3357838-b8a8-4d0b-a504-007d5bc49bbf"),
                            Date = new DateTime(2025, 1, 1, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4088),
                            EmployeeId = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("d7677131-1818-48ed-b048-bf35fe2db204"),
                            Date = new DateTime(2025, 1, 3, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4090),
                            EmployeeId = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("30a66e72-88bf-4e1c-b358-bb11aaf02505"),
                            Date = new DateTime(2025, 1, 4, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4092),
                            EmployeeId = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("dd1abaff-4c5d-4599-8b95-e32e5bf72f96"),
                            Date = new DateTime(2025, 1, 2, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4094),
                            EmployeeId = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("a49f3ea0-5522-43c8-98ce-509eb522d166"),
                            Date = new DateTime(2024, 12, 31, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4096),
                            EmployeeId = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
                            Status = 1
                        },
                        new
                        {
                            Id = new Guid("3694941f-c9f9-4d7a-ae74-b417781670c3"),
                            Date = new DateTime(2025, 1, 1, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4098),
                            EmployeeId = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
                            Status = 0
                        },
                        new
                        {
                            Id = new Guid("ff96918b-b392-44fb-a4b7-c0f4ed63856e"),
                            Date = new DateTime(2025, 1, 3, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4100),
                            EmployeeId = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
                            Status = 2
                        },
                        new
                        {
                            Id = new Guid("6af4a763-1545-4888-bb9a-7a29ed2558db"),
                            Date = new DateTime(2025, 1, 4, 22, 8, 41, 205, DateTimeKind.Local).AddTicks(4105),
                            EmployeeId = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
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
                            Id = new Guid("e78cedf4-24b4-488d-a91e-c66ef2154e0c"),
                            EmployeeCode = "E001",
                            Name = "Md. Sujad-ud Doula",
                            Salary = 35000.00m
                        },
                        new
                        {
                            Id = new Guid("4926d0d6-a1bf-4f03-a074-8bd4646be93c"),
                            EmployeeCode = "E002",
                            Name = "John Doe",
                            Salary = 50000.00m
                        });
                });

            modelBuilder.Entity("Emp.Domain.Entities.Attendance", b =>
                {
                    b.HasOne("Emp.Domain.Entities.Employee", "Employees")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Emp.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Attendances");
                });
#pragma warning restore 612, 618
        }
    }
}
