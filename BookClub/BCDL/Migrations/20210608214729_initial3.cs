using Microsoft.EntityFrameworkCore.Migrations;

namespace BCDL.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Achievements_Users_UserEmail",
                table: "Achievements");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Books_BookISBN",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryName",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Books_BookISBN",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksRead_Users_UserEmail",
                table: "BooksRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Books_BookISBN",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksToRead_Users_UserEmail",
                table: "BooksToRead");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_BookClubs_BookClubId",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ClubPosts_ClubPostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_UserPost_UserPostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEmail",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Books_BookISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Books_BookISBN",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Users_ReceversEmailsEmail",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_Recommendations_Users_UserEmail",
                table: "Recommendations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPost_Users_UserEmail",
                table: "UserPost");

            migrationBuilder.DropIndex(
                name: "IX_UserPost_UserEmail",
                table: "UserPost");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_BookISBN",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_ReceversEmailsEmail",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_Recommendations_UserEmail",
                table: "Recommendations");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_BookISBN",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ClubPostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserPostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_BookClubId",
                table: "ClubPosts");

            migrationBuilder.DropIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_BookISBN",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksToRead_UserEmail",
                table: "BooksToRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_BookISBN",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_BooksRead_UserEmail",
                table: "BooksRead");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryName",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_BookISBN",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_BookClubs_UserEmail",
                table: "BookClubs");

            migrationBuilder.DropIndex(
                name: "IX_Achievements_UserEmail",
                table: "Achievements");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "UserPost",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Recommendations",
                newName: "SenderEmail");

            migrationBuilder.RenameColumn(
                name: "ReceversEmailsEmail",
                table: "Recommendations",
                newName: "ReceversEmails");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "Recommendations",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "FavoriteBooks",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "FavoriteBooks",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserPostId",
                table: "Comments",
                newName: "UserPostID");

            migrationBuilder.RenameColumn(
                name: "ClubPostId",
                table: "Comments",
                newName: "ClubPostID");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Comments",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "BookClubId",
                table: "ClubPosts",
                newName: "BookClubID");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "ClubPosts",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "BooksToRead",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "BooksToRead",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "BooksRead",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "BooksRead",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "BookClubs",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "BookISBN",
                table: "BookClubs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Achievements",
                newName: "Email");

            migrationBuilder.AlterColumn<int>(
                name: "UserPostID",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClubPostID",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookClubID",
                table: "ClubPosts",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UserPost",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "SenderEmail",
                table: "Recommendations",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "ReceversEmails",
                table: "Recommendations",
                newName: "ReceversEmailsEmail");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Recommendations",
                newName: "BookISBN");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "FavoriteBooks",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "FavoriteBooks",
                newName: "BookISBN");

            migrationBuilder.RenameColumn(
                name: "UserPostID",
                table: "Comments",
                newName: "UserPostId");

            migrationBuilder.RenameColumn(
                name: "ClubPostID",
                table: "Comments",
                newName: "ClubPostId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Comments",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "BookClubID",
                table: "ClubPosts",
                newName: "BookClubId");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "ClubPosts",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "BooksToRead",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "BooksToRead",
                newName: "BookISBN");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "BooksRead",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "BooksRead",
                newName: "BookISBN");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "BookClubs",
                newName: "UserEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "BookClubs",
                newName: "BookISBN");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Achievements",
                newName: "UserEmail");

            migrationBuilder.AlterColumn<int>(
                name: "UserPostId",
                table: "Comments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ClubPostId",
                table: "Comments",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "BookClubId",
                table: "ClubPosts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_UserPost_UserEmail",
                table: "UserPost",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_BookISBN",
                table: "Recommendations",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_ReceversEmailsEmail",
                table: "Recommendations",
                column: "ReceversEmailsEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_UserEmail",
                table: "Recommendations",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookISBN",
                table: "FavoriteBooks",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClubPostId",
                table: "Comments",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPostId",
                table: "Comments",
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
                name: "IX_BooksToRead_BookISBN",
                table: "BooksToRead",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksToRead_UserEmail",
                table: "BooksToRead",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_BookISBN",
                table: "BooksRead",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_UserEmail",
                table: "BooksRead",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryName",
                table: "Books",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_BookClubs_BookISBN",
                table: "BookClubs",
                column: "BookISBN");

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
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Books_BookISBN",
                table: "BookClubs",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookClubs_Users_UserEmail",
                table: "BookClubs",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryName",
                table: "Books",
                column: "CategoryName",
                principalTable: "Categories",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Books_BookISBN",
                table: "BooksRead",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksRead_Users_UserEmail",
                table: "BooksRead",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Books_BookISBN",
                table: "BooksToRead",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksToRead_Users_UserEmail",
                table: "BooksToRead",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_BookClubs_BookClubId",
                table: "ClubPosts",
                column: "BookClubId",
                principalTable: "BookClubs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubPosts_Users_UserEmail",
                table: "ClubPosts",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ClubPosts_ClubPostId",
                table: "Comments",
                column: "ClubPostId",
                principalTable: "ClubPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_UserPost_UserPostId",
                table: "Comments",
                column: "UserPostId",
                principalTable: "UserPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserEmail",
                table: "Comments",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Books_BookISBN",
                table: "FavoriteBooks",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Users_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Books_BookISBN",
                table: "Recommendations",
                column: "BookISBN",
                principalTable: "Books",
                principalColumn: "ISBN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Users_ReceversEmailsEmail",
                table: "Recommendations",
                column: "ReceversEmailsEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recommendations_Users_UserEmail",
                table: "Recommendations",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPost_Users_UserEmail",
                table: "UserPost",
                column: "UserEmail",
                principalTable: "Users",
                principalColumn: "Email",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
