using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AdvertisementUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobType",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "JobDescription", "JobType", "Location" },
                values: new object[] { "5 Yıl deneyimli", "Full time", "İstanbul" });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "JobDescription", "JobType", "Location" },
                values: new object[] { "3 Yıl deneyimli", "Part time", "İzmir" });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "JobDescription", "JobType", "Location" },
                values: new object[] { "2 Yıl deneyimli", "Full time", "İstanbul" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "JobType",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Advertisements");
        }
    }
}
