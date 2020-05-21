using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateSettingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Agents_AgentId",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Areas_AreaId",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Settings_SettingId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_SettingId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Settings_AgentId",
                table: "Settings");

            migrationBuilder.DropIndex(
                name: "IX_Settings_AreaId",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Areas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "SocialMedias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Settings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Settings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Areas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_SettingId",
                table: "SocialMedias",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_AgentId",
                table: "Settings",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_AreaId",
                table: "Settings",
                column: "AreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Agents_AgentId",
                table: "Settings",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Areas_AreaId",
                table: "Settings",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Settings_SettingId",
                table: "SocialMedias",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
