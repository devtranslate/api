using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTranslate.Api.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Author", "ImageUrl", "Language", "Status", "Title", "TranslationType", "Translator", "Url" },
                values: new object[] { 1, "Gajus Kuizinas", "https://image.ibb.co/b9GdKb/1.png", 1, 1, "Pare de usar CSS no JavaScript para desenvolvimento web", 1, "Carlos Eduardo Olivieri", "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
