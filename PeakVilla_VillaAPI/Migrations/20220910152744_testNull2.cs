using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeakVilla_VillaAPI.Migrations
{
    public partial class testNull2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 27, 43, 897, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 27, 43, 897, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 27, 43, 897, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 27, 43, 897, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 27, 43, 897, DateTimeKind.Local).AddTicks(5142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 24, 45, 167, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 24, 45, 167, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 24, 45, 167, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 24, 45, 167, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 10, 22, 24, 45, 167, DateTimeKind.Local).AddTicks(9066));
        }
    }
}
