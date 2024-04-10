using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataSeed20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 6, 56, 447, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 6, 56, 447, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 6, 56, 447, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.InsertData(
                table: "Applicant",
                columns: new[] { "Id", "AnnualIncome", "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { 1, 1000m, new DateTime(2024, 4, 8, 18, 6, 56, 447, DateTimeKind.Local).AddTicks(8386), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 5, 51, 277, DateTimeKind.Local).AddTicks(5835));
        }
    }
}
