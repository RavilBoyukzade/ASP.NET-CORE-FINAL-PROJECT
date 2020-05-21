using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class RemoveAboutItemFromSettingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settings_AboutItems_AboutItemId",
                table: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Settings_AboutItemId",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AboutItemId",
                table: "Settings");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Settings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AboutItemId",
                table: "Settings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_AboutItemId",
                table: "Settings",
                column: "AboutItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_AboutItems_AboutItemId",
                table: "Settings",
                column: "AboutItemId",
                principalTable: "AboutItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
