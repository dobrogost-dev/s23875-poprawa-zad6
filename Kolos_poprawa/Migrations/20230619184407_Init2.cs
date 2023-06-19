using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolos_poprawa.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2023, 6, 18, 9, 58, 58, 771, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 18, 9, 58, 58, 771, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 6, 18, 9, 58, 58, 771, DateTimeKind.Local).AddTicks(5460) });
        }
    }
}
