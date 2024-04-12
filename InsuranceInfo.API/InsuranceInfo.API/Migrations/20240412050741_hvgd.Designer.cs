﻿// <auto-generated />
using System;
using InsuranceInfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    [DbContext(typeof(ApplicantInfoContext))]
    [Migration("20240412050741_hvgd")]
    partial class hvgd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("InsuranceInfo.API.Entities.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AnnualIncome")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTobaccoUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Applicant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnualIncome = 1000m,
                            DateOfBirth = new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5657),
                            FirstName = "Shweta",
                            IsTobaccoUser = true,
                            LastName = "Kumari"
                        },
                        new
                        {
                            Id = 2,
                            AnnualIncome = 3000m,
                            DateOfBirth = new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5691),
                            FirstName = "Kunal",
                            IsTobaccoUser = false,
                            LastName = "Kumar"
                        },
                        new
                        {
                            Id = 3,
                            AnnualIncome = 4000m,
                            DateOfBirth = new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5697),
                            FirstName = "Shivani",
                            IsTobaccoUser = false,
                            LastName = "Kumari"
                        },
                        new
                        {
                            Id = 4,
                            AnnualIncome = 4000m,
                            DateOfBirth = new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5702),
                            FirstName = "Shivani",
                            IsTobaccoUser = false,
                            LastName = "Kumari"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
