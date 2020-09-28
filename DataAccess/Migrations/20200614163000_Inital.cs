using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertisementTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertisementTitle" },
                values: new object[] { 1, "Jr Net Core Developer" });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertisementTitle" },
                values: new object[] { 2, "Jr Angular Developer" });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertisementTitle" },
                values: new object[] { 3, "Jr Ionic Developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");
        }
    }
}
