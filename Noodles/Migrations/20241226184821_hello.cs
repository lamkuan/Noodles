using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noodles.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Noodles",
                columns: new[] { "Id", "HResult", "HelpLink", "ImageUrl", "LongDescription", "Name", "Price", "ShortDescription", "Source" },
                values: new object[,]
                {
                    { 1, -2146233088, null, "/images/毛细.png", "真的好细好细好细啊", "毛细", 12m, "如发丝般细", null },
                    { 2, -2146233088, null, "/images/细.png", "还是挺细的", "细", 10m, "普通细", null },
                    { 3, -2146233088, null, "/images/三细.png", "比细的粗点，比二细细点", "三细", 11m, "有点粗了", null },
                    { 4, -2146233088, null, "/images/二细.png", "粗的才有嚼劲", "二细", 10m, "粗了", null },
                    { 5, -2146233088, null, "/images/二柱子.png", "粗得快咬不动了", "二柱子", 11m, "太粗了", null },
                    { 6, -2146233088, null, "/images/韭叶子.png", "韭猜叶一样宽", "韭叶子", 12m, "扁的", null },
                    { 7, -2146233088, null, "/images/薄宽.png", "比韭叶宽一点，比大宽窄一点", "薄宽", 11m, "开始宽了", null },
                    { 8, -2146233088, null, "/images/大宽.png", "比嘴还宽了", "大宽", 10m, "裤带面", null },
                    { 9, -2146233088, null, "/images/荞麦棱子.png", "好像知道师傅怎么拉出来的", "荞麦棱子", 15m, "立方体的", null },
                    { 10, -2146233088, null, "/images/一窝丝.png", "我也没吃过", "一窝丝", 15m, "这是啥", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Noodles",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
