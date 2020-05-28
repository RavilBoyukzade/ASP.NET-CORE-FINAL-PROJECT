using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Initialasdasaf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutItems_AboutItems_AboutItemId",
                table: "AboutItems");

            migrationBuilder.DropIndex(
                name: "IX_AboutItems_AboutItemId",
                table: "AboutItems");

            migrationBuilder.DropIndex(
                name: "IX_AboutItems_SettingId",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "AboutItemId",
                table: "AboutItems");

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_SettingId",
                table: "AboutItems",
                column: "SettingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AboutItems_SettingId",
                table: "AboutItems");

            migrationBuilder.AddColumn<int>(
                name: "AboutItemId",
                table: "AboutItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_AboutItemId",
                table: "AboutItems",
                column: "AboutItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_SettingId",
                table: "AboutItems",
                column: "SettingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AboutItems_AboutItems_AboutItemId",
                table: "AboutItems",
                column: "AboutItemId",
                principalTable: "AboutItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
