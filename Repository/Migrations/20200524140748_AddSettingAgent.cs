using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddSettingAgent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "Agents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agents_SettingId",
                table: "Agents",
                column: "SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_Settings_SettingId",
                table: "Agents",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Settings_SettingId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_SettingId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "Agents");
        }
    }
}
