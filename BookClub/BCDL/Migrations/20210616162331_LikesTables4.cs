using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BCDL.Migrations
{
    public partial class LikesTables4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Comments_UserCommentId",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_UserPosts_UserPostId",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Users_UserEmail",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UserPosts_UserPostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEmail",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommentLikes",
                table: "CommentLikes");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "UserComments");

            migrationBuilder.RenameTable(
                name: "CommentLikes",
                newName: "UserCommentLikes");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserPostID",
                table: "UserComments",
                newName: "IX_UserComments_UserPostID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserEmail",
                table: "UserComments",
                newName: "IX_UserComments_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_CommentLikes_UserPostId",
                table: "UserCommentLikes",
                newName: "IX_UserCommentLikes_UserPostId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "UserCommentLikes",
                newName: "IX_UserCommentLikes_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_CommentLikes_UserCommentId",
                table: "UserCommentLikes",
                newName: "IX_UserCommentLikes_UserCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserComments",
                table: "UserComments",
                column: "UserCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCommentLikes",
                table: "UserCommentLikes",
                column: "UserCommentLikesId");

            migrationBuilder.CreateTable(
                name: "ClubComments",
                columns: table => new
                {
                    ClubCommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ClubPostID = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubComments", x => x.ClubCommentId);
                    table.ForeignKey(
                        name: "FK_ClubComments_ClubPosts_ClubPostID",
                        column: x => x.ClubPostID,
                        principalTable: "ClubPosts",
                        principalColumn: "ClubPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubComments_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubCommentLikes",
                columns: table => new
                {
                    ClubCommentLikesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Dislike = table.Column<bool>(type: "boolean", nullable: false),
                    ClubCommentId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ClubPostId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubCommentLikes", x => x.ClubCommentLikesId);
                    table.ForeignKey(
                        name: "FK_ClubCommentLikes_ClubComments_ClubCommentId",
                        column: x => x.ClubCommentId,
                        principalTable: "ClubComments",
                        principalColumn: "ClubCommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubCommentLikes_ClubPosts_ClubPostId",
                        column: x => x.ClubPostId,
                        principalTable: "ClubPosts",
                        principalColumn: "ClubPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubCommentLikes_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubCommentLikes_ClubCommentId",
                table: "ClubCommentLikes",
                column: "ClubCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubCommentLikes_ClubPostId",
                table: "ClubCommentLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubCommentLikes_UserEmail",
                table: "ClubCommentLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ClubComments_ClubPostID",
                table: "ClubComments",
                column: "ClubPostID");

            migrationBuilder.CreateIndex(
                name: "IX_ClubComments_UserEmail",
                table: "ClubComments",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCommentLikes_UserComments_UserCommentId",
                table: "UserCommentLikes",
                column: "UserCommentId",
                principalTable: "UserComments",
                principalColumn: "UserCommentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCommentLikes_UserPosts_UserPostId",
                table: "UserCommentLikes",
                column: "UserPostId",
                principalTable: "UserPosts",
                principalColumn: "UserPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCommentLikes_Users_UserEmail",
                table: "UserCommentLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_UserPosts_UserPostID",
                table: "UserComments",
                column: "UserPostID",
                principalTable: "UserPosts",
                principalColumn: "UserPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_Users_UserEmail",
                table: "UserComments",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserCommentLikes_UserComments_UserCommentId",
                table: "UserCommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCommentLikes_UserPosts_UserPostId",
                table: "UserCommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCommentLikes_Users_UserEmail",
                table: "UserCommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_UserPosts_UserPostID",
                table: "UserComments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_Users_UserEmail",
                table: "UserComments");

            migrationBuilder.DropTable(
                name: "ClubCommentLikes");

            migrationBuilder.DropTable(
                name: "ClubComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserComments",
                table: "UserComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCommentLikes",
                table: "UserCommentLikes");

            migrationBuilder.RenameTable(
                name: "UserComments",
                newName: "Comments");

            migrationBuilder.RenameTable(
                name: "UserCommentLikes",
                newName: "CommentLikes");

            migrationBuilder.RenameIndex(
                name: "IX_UserComments_UserPostID",
                table: "Comments",
                newName: "IX_Comments_UserPostID");

            migrationBuilder.RenameIndex(
                name: "IX_UserComments_UserEmail",
                table: "Comments",
                newName: "IX_Comments_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_UserCommentLikes_UserPostId",
                table: "CommentLikes",
                newName: "IX_CommentLikes_UserPostId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCommentLikes_UserEmail",
                table: "CommentLikes",
                newName: "IX_CommentLikes_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_UserCommentLikes_UserCommentId",
                table: "CommentLikes",
                newName: "IX_CommentLikes_UserCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "UserCommentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommentLikes",
                table: "CommentLikes",
                column: "UserCommentLikesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Comments_UserCommentId",
                table: "CommentLikes",
                column: "UserCommentId",
                principalTable: "Comments",
                principalColumn: "UserCommentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_UserPosts_UserPostId",
                table: "CommentLikes",
                column: "UserPostId",
                principalTable: "UserPosts",
                principalColumn: "UserPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Users_UserEmail",
                table: "CommentLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UserPosts_UserPostID",
                table: "Comments",
                column: "UserPostID",
                principalTable: "UserPosts",
                principalColumn: "UserPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserEmail",
                table: "Comments",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
