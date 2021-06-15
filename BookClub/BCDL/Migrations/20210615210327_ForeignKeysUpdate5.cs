using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class ForeignKeysUpdate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserEmail1",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Books_BookISBN",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Users_UserEmail1",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Books_BookISBN",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Users_UserEmail1",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Books_BookISBN",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Users_UserEmail1",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPostLikes_Users_UserEmail1",
                table: "ClubPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_Users_UserEmail1",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Users_UserEmail1",
                table: "CommentLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEmail1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Books_BookISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail1",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowUsers_Users_UserEmail1",
                table: "FollowUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Books_BookISBN",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Users_UserEmail1",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPostLikes_Users_UserEmail1",
                table: "UserPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPosts_Users_UserEmail1",
                table: "UserPosts");

            migrationBuilder.DropIndex(
                name: "IX_UserPosts_UserEmail1",
                table: "UserPosts");

            migrationBuilder.DropIndex(
                name: "IX_UserPostLikes_UserEmail1",
                table: "UserPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_BookISBN",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserEmail1",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_FollowUsers_UserEmail1",
                table: "FollowUsers");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_BookISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_UserEmail1",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserEmail1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_UserEmail1",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_UserEmail1",
                table: "ClubPosts");

            migrationBuilder.DropIndex(
                name: "IX_ClubPostLikes_UserEmail1",
                table: "ClubPostLikes");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_BookISBN",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_UserEmail1",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_BookISBN",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_UserEmail1",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_BookISBN",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_UserEmail1",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserEmail1",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "UserPosts");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "UserPostLikes");

            migrationBuilder.DropColumn(
                name: "BookISBN",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "Recommendations");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "FollowUsers");

            migrationBuilder.DropColumn(
                name: "BookISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "FavoriteBooks");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "CommentLikes");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "ClubPosts");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "ClubPostLikes");

            migrationBuilder.DropColumn(
                name: "BookISBN",
                table: "BooksToRead");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "BooksToRead");

            migrationBuilder.DropColumn(
                name: "BookISBN",
                table: "BooksRead");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "BooksRead");

            migrationBuilder.DropColumn(
                name: "BookISBN",
                table: "BookClubs");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "BookClubs");

            migrationBuilder.DropColumn(
                name: "UserEmail1",
                table: "Achievements");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "UserPosts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "ClubPosts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserEmail",
                table: "UserPosts",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserEmail",
                table: "UserPostLikes",
                column: "UserEmail");

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
                name: "IX_FavoriteBooks_ISBN",
                table: "FavoriteBooks",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "CommentLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts",
                column: "UserEmail");

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
                name: "FK_ClubPostLikes_Users_UserEmail",
                table: "ClubPostLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Users_UserEmail",
                table: "CommentLikes",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_ClubPostLikes_Users_UserEmail",
                table: "ClubPostLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentLikes_Users_UserEmail",
                table: "CommentLikes");

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
                name: "FK_FollowUsers_Users_UserEmail",
                table: "FollowUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Books_ISBN",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Users_UserEmail",
                table: "Recommendations");

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
                name: "IX_Recommendations_ISBN",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserEmail",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_FollowUsers_UserEmail",
                table: "FollowUsers");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_ISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "CommentLikes");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts");

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
                name: "IX_BookClubs_ISBN",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserEmail",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "UserPosts");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ClubPosts");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "UserPosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "UserPostLikes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookISBN",
                table: "Recommendations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "Recommendations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "FollowUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookISBN",
                table: "FavoriteBooks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "FavoriteBooks",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "Comments",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "CommentLikes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "ClubPosts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "ClubPostLikes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookISBN",
                table: "BooksToRead",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "BooksToRead",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookISBN",
                table: "BooksRead",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "BooksRead",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookISBN",
                table: "BookClubs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "BookClubs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail1",
                table: "Achievements",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserEmail1",
                table: "UserPosts",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserEmail1",
                table: "UserPostLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_BookISBN",
                table: "Recommendations",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserEmail1",
                table: "Recommendations",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUsers_UserEmail1",
                table: "FollowUsers",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookISBN",
                table: "FavoriteBooks",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail1",
                table: "FavoriteBooks",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail1",
                table: "Comments",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserEmail1",
                table: "CommentLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_UserEmail1",
                table: "ClubPosts",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPostLikes_UserEmail1",
                table: "ClubPostLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_BooksToRead_BookISBN",
                table: "BooksToRead",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksToRead_UserEmail1",
                table: "BooksToRead",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_BookISBN",
                table: "BooksRead",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_UserEmail1",
                table: "BooksRead",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_BookISBN",
                table: "BookClubs",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_UserEmail1",
                table: "BookClubs",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserEmail1",
                table: "Achievements",
                column: "UserEmail1");

            migrationBuilder.AddForeignKey(
                name: "FK_Achievements_Users_UserEmail1",
                table: "Achievements",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Books_BookISBN",
                table: "BookClubs",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Users_UserEmail1",
                table: "BookClubs",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Books_BookISBN",
                table: "BooksRead",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Users_UserEmail1",
                table: "BooksRead",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Books_BookISBN",
                table: "BooksToRead",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Users_UserEmail1",
                table: "BooksToRead",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPostLikes_Users_UserEmail1",
                table: "ClubPostLikes",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_Users_UserEmail1",
                table: "ClubPosts",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentLikes_Users_UserEmail1",
                table: "CommentLikes",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserEmail1",
                table: "Comments",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Books_BookISBN",
                table: "FavoriteBooks",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail1",
                table: "FavoriteBooks",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowUsers_Users_UserEmail1",
                table: "FollowUsers",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Books_BookISBN",
                table: "Recommendations",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Users_UserEmail1",
                table: "Recommendations",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPostLikes_Users_UserEmail1",
                table: "UserPostLikes",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPosts_Users_UserEmail1",
                table: "UserPosts",
                column: "UserEmail1",
                principalTable: "Users",
                principalColumn: "UserEmail",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
