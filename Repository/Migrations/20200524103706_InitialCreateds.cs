using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialCreateds : Migration
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

            migrationBuilder.AddColumn<int>(
                name: "AboutItemId",
                table: "AboutItems",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "AboutItems",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AboutItems_Settings_SettingId",
                table: "AboutItems",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutItems_AboutItems_AboutItemId",
                table: "AboutItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AboutItems_Settings_SettingId",
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

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "AboutItems");

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
