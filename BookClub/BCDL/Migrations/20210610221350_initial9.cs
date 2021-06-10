using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class initial9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost");

            migrationBuilder.RenameTable(
                name: "UserPost",
                newName: "UserPosts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPosts",
                table: "UserPosts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPosts",
                table: "UserPosts");

            migrationBuilder.RenameTable(
                name: "UserPosts",
                newName: "UserPost");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPost",
                table: "UserPost",
                column: "Id");
        }
    }
}
