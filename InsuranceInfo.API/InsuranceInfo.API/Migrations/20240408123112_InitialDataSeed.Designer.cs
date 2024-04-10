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
    [Migration("20240408123112_InitialDataSeed")]
    partial class InitialDataSeed
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

                    b.Property<bool>("IsTobaccoUser")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Applicant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnualIncome = 1000m,
                            DateOfBirth = new DateTime(2024, 4, 8, 18, 1, 11, 171, DateTimeKind.Local).AddTicks(5836),
                            IsTobaccoUser = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
