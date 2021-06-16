using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BCDL.Migrations
{
    public partial class LikesTables3 : Migration
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
                    Badge = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.AchievementId);
                    table.ForeignKey(
                        name: "FK_Achievements_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    UserEmail = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUsers", x => x.FollowUserId);
                    table.ForeignKey(
                        name: "FK_FollowUsers_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPosts", x => x.UserPostId);
                    table.ForeignKey(
                        name: "FK_UserPosts_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    ISBN = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookClubs", x => x.BookClubId);
                    table.ForeignKey(
                        name: "FK_BookClubs_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookClubs_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    BookPages = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksRead", x => x.BooksReadId);
                    table.ForeignKey(
                        name: "FK_BooksRead_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BooksRead_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    ISBN = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksToRead", x => x.BooksToReadId);
                    table.ForeignKey(
                        name: "FK_BooksToRead_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BooksToRead_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    ISBN = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.FavoriteBookId);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    ReceversEmails = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.RecommendationId);
                    table.ForeignKey(
                        name: "FK_Recommendations_Books_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recommendations_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    UserCommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserPostID = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.UserCommentId);
                    table.ForeignKey(
                        name: "FK_Comments_UserPosts_UserPostID",
                        column: x => x.UserPostID,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    UserEmail = table.Column<string>(type: "text", nullable: true)
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
                        name: "FK_UserPostLikes_Users_UserEmail",
                        column: x => x.UserEmail,
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
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                        name: "FK_ClubPosts_Users_UserEmail",
                        column: x => x.UserEmail,
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
                name: "CommentLikes",
                columns: table => new
                {
                    UserCommentLikesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Like = table.Column<bool>(type: "boolean", nullable: false),
                    Dislike = table.Column<bool>(type: "boolean", nullable: false),
                    UserCommentId = table.Column<int>(type: "integer", nullable: false),
                    UserEmail = table.Column<string>(type: "text", nullable: true),
                    UserPostId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentLikes", x => x.UserCommentLikesId);
                    table.ForeignKey(
                        name: "FK_CommentLikes_Comments_UserCommentId",
                        column: x => x.UserCommentId,
                        principalTable: "Comments",
                        principalColumn: "UserCommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_UserPosts_UserPostId",
                        column: x => x.UserPostId,
                        principalTable: "UserPosts",
                        principalColumn: "UserPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
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
                    UserEmail = table.Column<string>(type: "text", nullable: true)
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
                        name: "FK_ClubPostLikes_Users_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Users",
                        principalColumn: "UserEmail",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_UserEmail",
                table: "Achievements",
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
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_ISBN",
                table: "BooksRead",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_BooksRead_UserEmail",
                table: "BooksRead",
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
                name: "IX_ClubPostLikes_ClubPostId",
                table: "ClubPostLikes",
                column: "ClubPostId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPostLikes_UserEmail",
                table: "ClubPostLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_BookClubId",
                table: "ClubPosts",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_ClubPosts_UserEmail",
                table: "ClubPosts",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserCommentId",
                table: "CommentLikes",
                column: "UserCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserEmail",
                table: "CommentLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserPostId",
                table: "CommentLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEmail",
                table: "Comments",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserPostID",
                table: "Comments",
                column: "UserPostID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_ISBN",
                table: "FavoriteBooks",
                column: "ISBN");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_UserEmail",
                table: "FavoriteBooks",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_FollowClubs_BookClubId",
                table: "FollowClubs",
                column: "BookClubId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUsers_UserEmail",
                table: "FollowUsers",
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
                name: "IX_UserPostLikes_UserEmail",
                table: "UserPostLikes",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_UserPostLikes_UserPostId",
                table: "UserPostLikes",
                column: "UserPostId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPosts_UserEmail",
                table: "UserPosts",
                column: "UserEmail");
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
                name: "ClubPosts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "BookClubs");

            migrationBuilder.DropTable(
                name: "UserPosts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
