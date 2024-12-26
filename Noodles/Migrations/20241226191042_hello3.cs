using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noodles.Migrations
{
    public partial class hello3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Noodles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Noodles");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50));
        }
    }
}
