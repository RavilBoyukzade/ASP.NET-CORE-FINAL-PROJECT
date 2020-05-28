using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddSliderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_Settings_SettingId",
                table: "Agents");

            migrationBuilder.DropIndex(
                name: "IX_Agents_SettingId",
                table: "Agents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ShortText",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "Agents");

            migrationBuilder.AddColumn<int>(
                name: "ServiceItemId",
                table: "Services",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ServiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(maxLength: 200, nullable: false),
                    ShortText = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceItems", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceItemId",
                table: "Services",
                column: "ServiceItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceItems_ServiceItemId",
                table: "Services",
                column: "ServiceItemId",
                principalTable: "ServiceItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceItems_ServiceItemId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "ServiceItems");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceItemId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceItemId",
                table: "Services");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Services",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortText",
                table: "Services",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Services",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "Agents",
                type: "int",
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
    }
}
