using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceInfo.API.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrationdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AnnualIncome = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsTobaccoUser = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");
        }
    }
}
