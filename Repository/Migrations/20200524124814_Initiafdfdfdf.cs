using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Initiafdfdfdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutCards_AboutItems_AboutItemsId",
                table: "AboutCards");

            migrationBuilder.DropIndex(
                name: "IX_AboutCards_AboutItemsId",
                table: "AboutCards");

            migrationBuilder.DropColumn(
                name: "AboutItemsId",
                table: "AboutCards");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "AboutItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AboutItems_CardId",
                table: "AboutItems",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutItems_AboutCards_CardId",
                table: "AboutItems",
                column: "CardId",
                principalTable: "AboutCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AboutItems_AboutCards_CardId",
                table: "AboutItems");

            migrationBuilder.DropIndex(
                name: "IX_AboutItems_CardId",
                table: "AboutItems");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "AboutItems");

            migrationBuilder.AddColumn<int>(
                name: "AboutItemsId",
                table: "AboutCards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AboutCards_AboutItemsId",
                table: "AboutCards",
                column: "AboutItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AboutCards_AboutItems_AboutItemsId",
                table: "AboutCards",
                column: "AboutItemsId",
                principalTable: "AboutItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
