using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllergyHistory.DAL.Migrations
{
    public partial class AllergyHistoryInnitSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PatientName = table.Column<string>(nullable: true),
                    CISId = table.Column<int>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Provider = table.Column<string>(nullable: true),
                    Population = table.Column<string>(nullable: true),
                    AxisI = table.Column<string>(nullable: true),
                    ClientAllergyId = table.Column<string>(nullable: true),
                    Allergen = table.Column<string>(nullable: true),
                    deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Allergen", "AxisI", "CISId", "ClientAllergyId", "DOB", "Gender", "PatientName", "Population", "Provider", "deleted" },
                values: new object[] { 1, "", "", 3, "", new DateTime(2019, 3, 6, 15, 33, 53, 206, DateTimeKind.Local).AddTicks(997), "Male", "something", "Child", "something", false });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientId", "Allergen", "AxisI", "CISId", "ClientAllergyId", "DOB", "Gender", "PatientName", "Population", "Provider", "deleted" },
                values: new object[] { 2, "", "something", 4, "", new DateTime(2019, 3, 6, 15, 33, 53, 206, DateTimeKind.Local).AddTicks(8173), "Female", "", "Child", "something", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
