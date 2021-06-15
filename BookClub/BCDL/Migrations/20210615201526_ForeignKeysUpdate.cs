using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BCDL.Migrations
{
    public partial class ForeignKeysUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserEmail = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    PagesRead = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserEmail);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    AchievementId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    Badge = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.AchievementId);
                    table.ForeignKey(
                        name: "FK_Achievements_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FollowUsers",
                columns: table => new
                {
                    FollowUserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FollowerEmail = table.Column<string>(type: "text", nullable: true),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUsers", x => x.FollowUserId);
                    table.ForeignKey(
                        name: "FK_FollowUsers_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPosts",
                columns: table => new
                {
                    UserPostId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    Post = table.Column<string>(type: "text", nullable: true),
                    TotalLike = table.Column<int>(type: "integer", nullable: false),
                    TotalDislike = table.Column<int>(type: "integer", nullable: false),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.UserPostId);
                    table.ForeignKey(
                        name: "FK_UserPosts_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookClubs",
                columns: table => new
                {
                    BookClubId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    BookISBN = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookClubs", x => x.BookClubId);
                    table.ForeignKey(
                        name: "FK_BookClubs_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookClubs_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BooksRead",
                columns: table => new
                {
                    BooksReadId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    BookPages = table.Column<int>(type: "integer", nullable: false),
                    BookISBN = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksRead", x => x.BooksReadId);
                    table.ForeignKey(
                        name: "FK_BooksRead_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BooksRead_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BooksToRead",
                columns: table => new
                {
                    BooksToReadId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    BookISBN = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksToRead", x => x.BooksToReadId);
                    table.ForeignKey(
                        name: "FK_BooksToRead_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BooksToRead_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    FavoriteBookId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    BookISBN = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.FavoriteBookId);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    RecommendationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    ReceversEmails = table.Column<string>(type: "text", nullable: true),
                    BookISBN = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.RecommendationId);
                    table.ForeignKey(
                        name: "FK_Recommendations_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPostLikes",
                columns: table => new
                {
                    UserPostLikesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Dislike = table.Column<bool>(type: "boolean", nullable: false),
                    UserPostId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPostLikes", x => x.UserPostLikesId);
                    table.ForeignKey(
                        name: "FK_UserPostLikes_UserPosts_UserPostId",
                        column: x => x.UserPostId,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPostLikes_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubPosts",
                columns: table => new
                {
                    ClubPostId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    Post = table.Column<string>(type: "text", nullable: true),
                    BookClubId = table.Column<int>(type: "integer", nullable: false),
                    TotalLike = table.Column<int>(type: "integer", nullable: false),
                    TotalDislike = table.Column<int>(type: "integer", nullable: false),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubPosts", x => x.ClubPostId);
                    table.ForeignKey(
                        name: "FK_ClubPosts_BookClubs_BookClubId",
                        column: x => x.BookClubId,
                        principalTable: "BookClubs",
                        principalColumn: "BookClubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubPosts_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FollowClubs",
                columns: table => new
                {
                    FollowClubId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FollowerEmail = table.Column<string>(type: "text", nullable: true),
                    BookClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowClubs", x => x.FollowClubId);
                    table.ForeignKey(
                        name: "FK_FollowClubs_BookClubs_BookClubId",
                        column: x => x.BookClubId,
                        principalTable: "BookClubs",
                        principalColumn: "BookClubId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClubPostLikes",
                columns: table => new
                {
                    ClubPostLikesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Dislike = table.Column<bool>(type: "boolean", nullable: false),
                    ClubPostId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubPostLikes", x => x.ClubPostLikesId);
                    table.ForeignKey(
                        name: "FK_ClubPostLikes_ClubPosts_ClubPostId",
                        column: x => x.ClubPostId,
                        principalTable: "ClubPosts",
                        principalColumn: "ClubPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubPostLikes_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserPostID = table.Column<int>(type: "integer", nullable: false),
                    ClubPostID = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_ClubPosts_ClubPostID",
                        column: x => x.ClubPostID,
                        principalTable: "ClubPosts",
                        principalColumn: "ClubPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_UserPosts_UserPostID",
                        column: x => x.UserPostID,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommentLikes",
                columns: table => new
                {
                    CommentLikesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Dislike = table.Column<bool>(type: "boolean", nullable: false),
                    CommentId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    ClubPostId = table.Column<int>(type: "integer", nullable: false),
                    UserPostId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail1 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentLikes", x => x.CommentLikesId);
                    table.ForeignKey(
                        name: "FK_CommentLikes_ClubPosts_ClubPostId",
                        column: x => x.ClubPostId,
                        principalTable: "ClubPosts",
                        principalColumn: "ClubPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_UserPosts_UserPostId",
                        column: x => x.UserPostId,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_Users_UserEmail1",
                        column: x => x.UserEmail1,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserEmail1",
                table: "Achievements",
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
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_BookISBN",
                table: "BooksRead",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_UserEmail1",
                table: "BooksRead",
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
                name: "IX_ClubPostLikes_ClubPostId",
                table: "ClubPostLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPostLikes_UserEmail1",
                table: "ClubPostLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_BookClubId",
                table: "ClubPosts",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_UserEmail1",
                table: "ClubPosts",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_ClubPostId",
                table: "CommentLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_CommentId",
                table: "CommentLikes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserEmail1",
                table: "CommentLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserPostId",
                table: "CommentLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClubPostID",
                table: "Comments",
                column: "ClubPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail1",
                table: "Comments",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPostID",
                table: "Comments",
                column: "UserPostID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookISBN",
                table: "FavoriteBooks",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail1",
                table: "FavoriteBooks",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_FollowClubs_BookClubId",
                table: "FollowClubs",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUsers_UserEmail1",
                table: "FollowUsers",
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
                name: "IX_UserPostLikes_UserEmail1",
                table: "UserPostLikes",
                column: "UserEmail1");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserPostId",
                table: "UserPostLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserEmail1",
                table: "UserPosts",
                column: "UserEmail1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "BooksRead");

            migrationBuilder.DropTable(
                name: "BooksToRead");

            migrationBuilder.DropTable(
                name: "ClubPostLikes");

            migrationBuilder.DropTable(
                name: "CommentLikes");

            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.DropTable(
                name: "FollowClubs");

            migrationBuilder.DropTable(
                name: "FollowUsers");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "UserPostLikes");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ClubPosts");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "BookClubs");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
