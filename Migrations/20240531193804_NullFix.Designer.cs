﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240531193804_NullFix")]
    partial class NullFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Address = "123 Main St",
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            LastName = "Doe",
                            Name = "John",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Address = "456 Elm St",
                            DateOfBirth = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jane.smith@example.com",
                            LastName = "Smith",
                            Name = "Jane",
                            Phone = "987-654-3210"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.LeaveApplication", b =>
                {
                    b.Property<int>("LeaveApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveApplicationId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LeaveApplicationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveApplications");

                    b.HasData(
                        new
                        {
                            LeaveApplicationId = 1,
                            CreatedDate = new DateTime(2024, 5, 31, 21, 38, 3, 797, DateTimeKind.Local).AddTicks(9130),
                            EmployeeId = 1,
                            EndDate = new DateTime(2032, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveTypeId = 1,
                            StartDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LeaveApplicationId = 2,
                            CreatedDate = new DateTime(2024, 5, 31, 21, 38, 3, 797, DateTimeKind.Local).AddTicks(9138),
                            EmployeeId = 2,
                            EndDate = new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeaveTypeId = 2,
                            StartDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.LeaveType", b =>
                {
                    b.Property<int>("LeaveTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LeaveTypeId");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            LeaveTypeId = 1,
                            TypeName = "Holiday"
                        },
                        new
                        {
                            LeaveTypeId = 2,
                            TypeName = "Sick Leave"
                        },
                        new
                        {
                            LeaveTypeId = 3,
                            TypeName = "Care of Children"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.LeaveApplication", b =>
                {
                    b.HasOne("WebApplication1.Models.Employee", "Employee")
                        .WithMany("LeaveApplications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.LeaveType", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("WebApplication1.Models.Employee", b =>
                {
                    b.Navigation("LeaveApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
