﻿// <auto-generated />
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230630060458_seedinf-data")]
    partial class seedinfdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Intern"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Software Engineer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Senior Software Engineer"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentRuleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkingHourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignationId");

                    b.HasIndex("PaymentRuleId");

                    b.HasIndex("WorkingHourId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DesignationId = 1,
                            Name = "smith",
                            PaymentRuleId = 1,
                            WorkingHourId = 1
                        },
                        new
                        {
                            Id = 2,
                            DesignationId = 2,
                            Name = "Nobitha",
                            PaymentRuleId = 2,
                            WorkingHourId = 2
                        },
                        new
                        {
                            Id = 3,
                            DesignationId = 3,
                            Name = "Doremon",
                            PaymentRuleId = 3,
                            WorkingHourId = 3
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.PaymentRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentRule");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RuleName = "Cash"
                        },
                        new
                        {
                            Id = 2,
                            RuleName = "Card"
                        },
                        new
                        {
                            Id = 3,
                            RuleName = "UPI"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.WorkingHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyMonthlyWorkingHour")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeMonthlyWorkingHour")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WorkingHour");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyMonthlyWorkingHour = 12,
                            EmployeeMonthlyWorkingHour = 8
                        },
                        new
                        {
                            Id = 2,
                            CompanyMonthlyWorkingHour = 12,
                            EmployeeMonthlyWorkingHour = 7
                        },
                        new
                        {
                            Id = 3,
                            CompanyMonthlyWorkingHour = 12,
                            EmployeeMonthlyWorkingHour = 6
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManagement.Models.PaymentRule", "PaymentRule")
                        .WithMany()
                        .HasForeignKey("PaymentRuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManagement.Models.WorkingHour", "WorkingHour")
                        .WithMany()
                        .HasForeignKey("WorkingHourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designation");

                    b.Navigation("PaymentRule");

                    b.Navigation("WorkingHour");
                });
#pragma warning restore 612, 618
        }
    }
}
