using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noodles.Migrations
{
    public partial class hello2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "CreateDateUTC", "Email", "Message", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50), "noname@hotmail.com", "真的好细好细好细啊", "阿莱克斯" },
                    { 2, new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50), "noname@hotmail.com", "还是挺细的", "莱克斯" },
                    { 3, new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50), "noname@hotmail.com", "比细的粗点，比二细细点", "克斯" },
                    { 4, new DateTime(2024, 12, 26, 19, 1, 43, 637, DateTimeKind.Utc).AddTicks(50), "noname@hotmail.com", "粗的才有嚼劲", "克斯" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
