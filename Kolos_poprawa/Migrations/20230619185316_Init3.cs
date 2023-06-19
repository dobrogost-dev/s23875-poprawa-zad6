using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolos_poprawa.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 19, 20, 53, 16, 260, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 19, 20, 53, 16, 260, DateTimeKind.Local).AddTicks(8918), new DateTime(2023, 6, 19, 20, 53, 16, 260, DateTimeKind.Local).AddTicks(8988) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 19, 20, 44, 7, 875, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 19, 20, 44, 7, 875, DateTimeKind.Local).AddTicks(9319), new DateTime(2023, 6, 19, 20, 44, 7, 875, DateTimeKind.Local).AddTicks(9370) });
        }
    }
}
