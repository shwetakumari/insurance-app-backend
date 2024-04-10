using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class seedv20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Applicant",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Applicant",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 3, 30, 535, DateTimeKind.Local).AddTicks(2787), "Shweta", "Kumari" });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 3, 30, 535, DateTimeKind.Local).AddTicks(2822), "Kunal", "Kumar" });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 3, 30, 535, DateTimeKind.Local).AddTicks(2828), "Shivani", "Kumari" });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 3, 30, 535, DateTimeKind.Local).AddTicks(2832), "Shivani", "Kumari" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Applicant");

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2024, 4, 8, 18, 6, 56, 447, DateTimeKind.Local).AddTicks(8386));

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
        }
    }
}
