using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class hvgd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5702));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 19, 36, 20, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 19, 36, 20, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 19, 36, 20, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 12, 10, 19, 36, 20, DateTimeKind.Local).AddTicks(5161));
        }
    }
}
