using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AboutCardInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutItems_AboutCards_CardId",
                table: "AboutItems");

            migrationBuilder.DropTable(
                name: "AboutCards");

            migrationBuilder.DropIndex(
                name: "IX_AboutItems_CardId",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "AboutItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "AboutItems",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "AboutItems",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "InformText",
                table: "AboutItems",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutItems",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "CardIcon",
                table: "AboutItems",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "AboutItems",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardText",
                table: "AboutItems",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardIcon",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "CardName",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "CardText",
                table: "AboutItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "AboutItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "AboutItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "InformText",
                table: "AboutItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AboutItems",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "AboutItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AboutCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutCards_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_CardId",
                table: "AboutItems",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutCards_ServiceId",
                table: "AboutCards",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutItems_AboutCards_CardId",
                table: "AboutItems",
                column: "CardId",
                principalTable: "AboutCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
