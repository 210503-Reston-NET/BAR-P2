using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class CommentLikeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubPostId",
                table: "CommentLikes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserPostId",
                table: "CommentLikes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClubPostId",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "UserPostId",
                table: "CommentLikes");
        }
    }
}
