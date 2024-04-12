
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTobaccoUser",
                table: "Applicant",
                newName: "ifTobaccoUser");

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "ifTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 47, 28, 757, DateTimeKind.Local).AddTicks(2650), 0 });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "ifTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 47, 28, 757, DateTimeKind.Local).AddTicks(2690), 1 });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "ifTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 47, 28, 757, DateTimeKind.Local).AddTicks(2697), 0 });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "ifTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 47, 28, 757, DateTimeKind.Local).AddTicks(2701), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ifTobaccoUser",
                table: "Applicant",
                newName: "IsTobaccoUser");

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5657), true });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5691), false });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5697), false });

            migrationBuilder.UpdateData(
                table: "Applicant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "IsTobaccoUser" },
                values: new object[] { new DateTime(2024, 4, 12, 10, 37, 40, 69, DateTimeKind.Local).AddTicks(5702), false });
        }
    }
}
