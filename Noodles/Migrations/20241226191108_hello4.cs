using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noodles.Migrations
{
    public partial class hello4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 11, 8, 692, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 11, 8, 692, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 11, 8, 692, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 11, 8, 692, DateTimeKind.Utc).AddTicks(5620));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 10, 42, 449, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 10, 42, 449, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 10, 42, 449, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 10, 42, 449, DateTimeKind.Utc).AddTicks(4730));
        }
    }
}
