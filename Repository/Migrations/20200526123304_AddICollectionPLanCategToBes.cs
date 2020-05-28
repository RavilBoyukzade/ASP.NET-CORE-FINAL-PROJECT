using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddICollectionPLanCategToBes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "BestPlanCategs");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BestPlanCategs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "BestPlanCategs");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "BestPlanCategs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
