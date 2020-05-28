using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateCaseStud : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaseStudId",
                table: "CaseStudSpecs");

            migrationBuilder.DropColumn(
                name: "OrderBy",
                table: "CaseStudSpecs");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CaseStudSpecs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "CaseStudSpecs",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "CaseStudyId",
                table: "CaseStudSpecs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChallengeText",
                table: "CaseStuds",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "CaseStuds",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResultText",
                table: "CaseStuds",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SolutionText",
                table: "CaseStuds",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "CaseStuds",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CaseStuds",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CaseStudSpecs_CaseStudyId",
                table: "CaseStudSpecs",
                column: "CaseStudyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseStudSpecs_CaseStuds_CaseStudyId",
                table: "CaseStudSpecs",
                column: "CaseStudyId",
                principalTable: "CaseStuds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseStudSpecs_CaseStuds_CaseStudyId",
                table: "CaseStudSpecs");

            migrationBuilder.DropIndex(
                name: "IX_CaseStudSpecs_CaseStudyId",
                table: "CaseStudSpecs");

            migrationBuilder.DropColumn(
                name: "CaseStudyId",
                table: "CaseStudSpecs");

            migrationBuilder.DropColumn(
                name: "ChallengeText",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "ResultText",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "SolutionText",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CaseStuds");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CaseStudSpecs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "CaseStudSpecs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaseStudId",
                table: "CaseStudSpecs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderBy",
                table: "CaseStudSpecs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
