using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class UpdateBestPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BestPlans_Labeles_LabelId",
                table: "BestPlans");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "BestPlans");

            migrationBuilder.AlterColumn<int>(
                name: "LabelId",
                table: "BestPlans",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BestPlans_Labeles_LabelId",
                table: "BestPlans",
                column: "LabelId",
                principalTable: "Labeles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BestPlans_Labeles_LabelId",
                table: "BestPlans");

            migrationBuilder.AlterColumn<int>(
                name: "LabelId",
                table: "BestPlans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BestPlans",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_BestPlans_Labeles_LabelId",
                table: "BestPlans",
                column: "LabelId",
                principalTable: "Labeles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
