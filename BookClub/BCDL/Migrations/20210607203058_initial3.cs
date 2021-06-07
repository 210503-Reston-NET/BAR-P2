using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "BookClubs",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "BookClubs");
        }
    }
}
