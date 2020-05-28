using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddDbSetBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Services_ServiceId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_Blog_BlogId",
                table: "BlogComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogImage_Blog_BlogId",
                table: "BlogImage");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogSlogan_Blog_BlogId",
                table: "BlogSlogan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogSlogan",
                table: "BlogSlogan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogImage",
                table: "BlogImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogComment",
                table: "BlogComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.RenameTable(
                name: "BlogSlogan",
                newName: "BlogSlogans");

            migrationBuilder.RenameTable(
                name: "BlogImage",
                newName: "BlogImages");

            migrationBuilder.RenameTable(
                name: "BlogComment",
                newName: "BlogComments");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_BlogSlogan_BlogId",
                table: "BlogSlogans",
                newName: "IX_BlogSlogans_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogImage_BlogId",
                table: "BlogImages",
                newName: "IX_BlogImages_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComment_BlogId",
                table: "BlogComments",
                newName: "IX_BlogComments_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_ServiceId",
                table: "Blogs",
                newName: "IX_Blogs_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogSlogans",
                table: "BlogSlogans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogImages",
                table: "BlogImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogImages_Blogs_BlogId",
                table: "BlogImages",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Services_ServiceId",
                table: "Blogs",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogSlogans_Blogs_BlogId",
                table: "BlogSlogans",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogImages_Blogs_BlogId",
                table: "BlogImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Services_ServiceId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogSlogans_Blogs_BlogId",
                table: "BlogSlogans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogSlogans",
                table: "BlogSlogans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogImages",
                table: "BlogImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments");

            migrationBuilder.RenameTable(
                name: "BlogSlogans",
                newName: "BlogSlogan");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameTable(
                name: "BlogImages",
                newName: "BlogImage");

            migrationBuilder.RenameTable(
                name: "BlogComments",
                newName: "BlogComment");

            migrationBuilder.RenameIndex(
                name: "IX_BlogSlogans_BlogId",
                table: "BlogSlogan",
                newName: "IX_BlogSlogan_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_ServiceId",
                table: "Blog",
                newName: "IX_Blog_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogImages_BlogId",
                table: "BlogImage",
                newName: "IX_BlogImage_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_BlogId",
                table: "BlogComment",
                newName: "IX_BlogComment_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogSlogan",
                table: "BlogSlogan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogImage",
                table: "BlogImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogComment",
                table: "BlogComment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Services_ServiceId",
                table: "Blog",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_Blog_BlogId",
                table: "BlogComment",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogImage_Blog_BlogId",
                table: "BlogImage",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogSlogan_Blog_BlogId",
                table: "BlogSlogan",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
