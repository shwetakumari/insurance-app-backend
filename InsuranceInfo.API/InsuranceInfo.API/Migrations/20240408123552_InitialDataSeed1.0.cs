using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Applicant",
                columns: new[] { "Id", "AnnualIncome", "DateOfBirth", "IsTobaccoUser" },
                values: new object[,]
                {
                    { 2, 3000m, new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5802), false },
                    { 3, 4000m, new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5830), false },
                    { 4, 4000m, new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5835), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Applicant",
                columns: new[] { "Id", "AnnualIncome", "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { 1, 1000m, new DateTime(2024, 4, 8, 18, 1, 11, 171, DateTimeKind.Local).AddTicks(5836), false });
        }
    }
}
