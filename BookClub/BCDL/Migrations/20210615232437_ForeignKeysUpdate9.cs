using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class ForeignKeysUpdate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserEmail",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Books_ISBN",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Books_ISBN",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Users_UserEmail",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Books_ISBN",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Users_UserEmail",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPostLikes_ClubPosts_ClubPostId",
                table: "ClubPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPostLikes_Users_UserEmail",
                table: "ClubPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_BookClubs_BookClubId",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_ClubPosts_ClubPostId",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Comments_CommentId",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_UserPosts_UserPostId",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Users_UserEmail",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ClubPosts_ClubPostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UserPosts_UserPostID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEmail",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Books_ISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowClubs_BookClubs_BookClubId",
                table: "FollowClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowUsers_Users_UserEmail",
                table: "FollowUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Books_ISBN",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Users_UserEmail",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPostLikes_UserPosts_UserPostId",
                table: "UserPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPostLikes_Users_UserEmail",
                table: "UserPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPosts_Users_UserEmail",
                table: "UserPosts");

            migrationBuilder.DropIndex(
                name: "IX_UserPosts_UserEmail",
                table: "UserPosts");

            migrationBuilder.DropIndex(
                name: "IX_UserPostLikes_UserEmail",
                table: "UserPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_UserPostLikes_UserPostId",
                table: "UserPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_ISBN",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserEmail",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_FollowUsers_UserEmail",
                table: "FollowUsers");

            migrationBuilder.DropIndex(
                name: "IX_FollowClubs_BookClubId",
                table: "FollowClubs");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_ISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ClubPostID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserPostID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_ClubPostId",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_CommentId",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_UserPostId",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_BookClubId",
                table: "ClubPosts");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts");

            migrationBuilder.DropIndex(
                name: "IX_ClubPostLikes_ClubPostId",
                table: "ClubPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_ClubPostLikes_UserEmail",
                table: "ClubPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_ISBN",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_UserEmail",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_ISBN",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_UserEmail",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_ISBN",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserEmail",
                table: "Achievements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserEmail",
                table: "UserPosts",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserEmail",
                table: "UserPostLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserPostId",
                table: "UserPostLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_ISBN",
                table: "Recommendations",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserEmail",
                table: "Recommendations",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUsers_UserEmail",
                table: "FollowUsers",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_FollowClubs_BookClubId",
                table: "FollowClubs",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_ISBN",
                table: "FavoriteBooks",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClubPostID",
                table: "Comments",
                column: "ClubPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPostID",
                table: "Comments",
                column: "UserPostID");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_ClubPostId",
                table: "CommentLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_CommentId",
                table: "CommentLikes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "CommentLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserPostId",
                table: "CommentLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_BookClubId",
                table: "ClubPosts",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPostLikes_ClubPostId",
                table: "ClubPostLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPostLikes_UserEmail",
                table: "ClubPostLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BooksToRead_ISBN",
                table: "BooksToRead",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksToRead_UserEmail",
                table: "BooksToRead",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_ISBN",
                table: "BooksRead",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_UserEmail",
                table: "BooksRead",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_ISBN",
                table: "BookClubs",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserEmail",
                table: "Achievements",
                column: "UserEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Users_UserEmail",
                table: "Achievements",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Books_ISBN",
                table: "BookClubs",
                column: "ISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Books_ISBN",
                table: "BooksRead",
                column: "ISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Users_UserEmail",
                table: "BooksRead",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Books_ISBN",
                table: "BooksToRead",
                column: "ISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Users_UserEmail",
                table: "BooksToRead",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPostLikes_ClubPosts_ClubPostId",
                table: "ClubPostLikes",
                column: "ClubPostId",
                principalTable: "ClubPosts",
                principalColumn: "ClubPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPostLikes_Users_UserEmail",
                table: "ClubPostLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_BookClubs_BookClubId",
                table: "ClubPosts",
                column: "BookClubId",
                principalTable: "BookClubs",
                principalColumn: "BookClubId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_ClubPosts_ClubPostId",
                table: "CommentLikes",
                column: "ClubPostId",
                principalTable: "ClubPosts",
                principalColumn: "ClubPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Comments_CommentId",
                table: "CommentLikes",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "CommentId",
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
                name: "FK_Comments_ClubPosts_ClubPostID",
                table: "Comments",
                column: "ClubPostID",
                principalTable: "ClubPosts",
                principalColumn: "ClubPostId",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Books_ISBN",
                table: "FavoriteBooks",
                column: "ISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowClubs_BookClubs_BookClubId",
                table: "FollowClubs",
                column: "BookClubId",
                principalTable: "BookClubs",
                principalColumn: "BookClubId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUsers_Users_UserEmail",
                table: "FollowUsers",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Books_ISBN",
                table: "Recommendations",
                column: "ISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Users_UserEmail",
                table: "Recommendations",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPostLikes_UserPosts_UserPostId",
                table: "UserPostLikes",
                column: "UserPostId",
                principalTable: "UserPosts",
                principalColumn: "UserPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPostLikes_Users_UserEmail",
                table: "UserPostLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPosts_Users_UserEmail",
                table: "UserPosts",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
