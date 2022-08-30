using Microsoft.EntityFrameworkCore.Migrations;

namespace Doc2Shiping.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryCodeId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCodeId",
                table: "Countries");
        }
    }
}
