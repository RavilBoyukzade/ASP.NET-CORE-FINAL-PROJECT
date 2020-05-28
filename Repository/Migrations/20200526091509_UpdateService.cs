using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceItems_ServiceItemId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceItemId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceItemId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "ShortText",
                table: "ServiceItems");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Services",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndPoint",
                table: "Services",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Services",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slogan",
                table: "Services",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Services",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "ServiceItems",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "ServiceItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ServiceItems",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "ServiceItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSpecs_ServiceId",
                table: "ServiceSpecs",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceItems_ServiceId",
                table: "ServiceItems",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceItems_Services_ServiceId",
                table: "ServiceItems",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceSpecs_Services_ServiceId",
                table: "ServiceSpecs",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceItems_Services_ServiceId",
                table: "ServiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceSpecs_Services_ServiceId",
                table: "ServiceSpecs");

            migrationBuilder.DropIndex(
                name: "IX_ServiceSpecs_ServiceId",
                table: "ServiceSpecs");

            migrationBuilder.DropIndex(
                name: "IX_ServiceItems_ServiceId",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "EndPoint",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Slogan",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "ServiceItems");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Services",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ServiceItemId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "ServiceItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ServiceItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ServiceItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "ServiceItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortText",
                table: "ServiceItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
    }
}
