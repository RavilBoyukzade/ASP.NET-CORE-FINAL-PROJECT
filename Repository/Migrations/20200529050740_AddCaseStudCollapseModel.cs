using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddCaseStudCollapseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CaseStuds",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CaseStuds",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceProfile",
                table: "CaseStuds",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CaseStudCollapses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CaseStudId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseStudCollapses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseStudCollapses_CaseStuds_CaseStudId",
                        column: x => x.CaseStudId,
                        principalTable: "CaseStuds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseStudCollapses_CaseStudId",
                table: "CaseStudCollapses",
                column: "CaseStudId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseStudCollapses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CaseStuds");

            migrationBuilder.DropColumn(
                name: "InsuranceProfile",
                table: "CaseStuds");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CaseStuds",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "ChallengeText",
                table: "CaseStuds",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "CaseStuds",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResultText",
                table: "CaseStuds",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SolutionText",
                table: "CaseStuds",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }
    }
}
