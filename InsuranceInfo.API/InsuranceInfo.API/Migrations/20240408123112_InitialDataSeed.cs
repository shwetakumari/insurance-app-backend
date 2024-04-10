using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Applicant",
                columns: new[] { "Id", "AnnualIncome", "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { 1, 1000m, new DateTime(2024, 4, 8, 18, 1, 11, 171, DateTimeKind.Local).AddTicks(5836), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
