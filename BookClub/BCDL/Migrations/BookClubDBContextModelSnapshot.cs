﻿// <auto-generated />
using System;
using BCDL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BCDL.Migrations
{
    [DbContext(typeof(BookClubDBContext))]
    partial class BookClubDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BCModel.Achievement", b =>
                {
                    b.Property<int>("AchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Badge")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("AchievementId");

                    b.HasIndex("UserEmail");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("BCModel.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ISBN");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BCModel.BookClub", b =>
                {
                    b.Property<int>("BookClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("BookClubId");

                    b.HasIndex("ISBN");

                    b.HasIndex("UserEmail");

                    b.ToTable("BookClubs");
                });

            modelBuilder.Entity("BCModel.BooksRead", b =>
                {
                    b.Property<int>("BooksReadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookPages")
                        .HasColumnType("integer");

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("BooksReadId");

                    b.HasIndex("ISBN");

                    b.HasIndex("UserEmail");

                    b.ToTable("BooksRead");
                });

            modelBuilder.Entity("BCModel.BooksToRead", b =>
                {
                    b.Property<int>("BooksToReadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("BooksToReadId");

                    b.HasIndex("ISBN");

                    b.HasIndex("UserEmail");

                    b.ToTable("BooksToRead");
                });

            modelBuilder.Entity("BCModel.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BCModel.ClubPost", b =>
                {
                    b.Property<int>("ClubPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Post")
                        .HasColumnType("text");

                    b.Property<int>("TotalDislike")
                        .HasColumnType("integer");

                    b.Property<int>("TotalLike")
                        .HasColumnType("integer");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("ClubPostId");

                    b.HasIndex("BookClubId");

                    b.HasIndex("UserEmail");

                    b.ToTable("ClubPosts");
                });

            modelBuilder.Entity("BCModel.ClubPostLikes", b =>
                {
                    b.Property<int>("ClubPostLikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubPostId")
                        .HasColumnType("integer");

                    b.Property<bool>("Dislike")
                        .HasColumnType("boolean");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("ClubPostLikesId");

                    b.HasIndex("ClubPostId");

                    b.HasIndex("UserEmail");

                    b.ToTable("ClubPostLikes");
                });

            modelBuilder.Entity("BCModel.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubPostID")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<int>("UserPostID")
                        .HasColumnType("integer");

                    b.HasKey("CommentId");

                    b.HasIndex("ClubPostID");

                    b.HasIndex("UserEmail");

                    b.HasIndex("UserPostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BCModel.CommentLikes", b =>
                {
                    b.Property<int>("CommentLikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubPostId")
                        .HasColumnType("integer");

                    b.Property<int>("CommentId")
                        .HasColumnType("integer");

                    b.Property<bool>("Dislike")
                        .HasColumnType("boolean");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<int>("UserPostId")
                        .HasColumnType("integer");

                    b.HasKey("CommentLikesId");

                    b.HasIndex("ClubPostId");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserEmail");

                    b.HasIndex("UserPostId");

                    b.ToTable("CommentLikes");
                });

            modelBuilder.Entity("BCModel.FavoriteBook", b =>
                {
                    b.Property<int>("FavoriteBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("FavoriteBookId");

                    b.HasIndex("ISBN");

                    b.HasIndex("UserEmail");

                    b.ToTable("FavoriteBooks");
                });

            modelBuilder.Entity("BCModel.FollowClub", b =>
                {
                    b.Property<int>("FollowClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BookClubId")
                        .HasColumnType("integer");

                    b.Property<string>("FollowerEmail")
                        .HasColumnType("text");

                    b.HasKey("FollowClubId");

                    b.HasIndex("BookClubId");

                    b.ToTable("FollowClubs");
                });

            modelBuilder.Entity("BCModel.FollowUser", b =>
                {
                    b.Property<int>("FollowUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FollowerEmail")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("FollowUserId");

                    b.HasIndex("UserEmail");

                    b.ToTable("FollowUsers");
                });

            modelBuilder.Entity("BCModel.Recommendation", b =>
                {
                    b.Property<int>("RecommendationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("ReceversEmails")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("RecommendationId");

                    b.HasIndex("ISBN");

                    b.HasIndex("UserEmail");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("BCModel.User", b =>
                {
                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("PagesRead")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("UserEmail");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BCModel.UserPost", b =>
                {
                    b.Property<int>("UserPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Post")
                        .HasColumnType("text");

                    b.Property<int>("TotalDislike")
                        .HasColumnType("integer");

                    b.Property<int>("TotalLike")
                        .HasColumnType("integer");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("UserPostId");

                    b.HasIndex("UserEmail");

                    b.ToTable("UserPosts");
                });

            modelBuilder.Entity("BCModel.UserPostLikes", b =>
                {
                    b.Property<int>("UserPostLikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Dislike")
                        .HasColumnType("boolean");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<int>("UserPostId")
                        .HasColumnType("integer");

                    b.HasKey("UserPostLikesId");

                    b.HasIndex("UserEmail");

                    b.HasIndex("UserPostId");

                    b.ToTable("UserPostLikes");
                });

            modelBuilder.Entity("BCModel.Achievement", b =>
                {
                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.Book", b =>
                {
                    b.HasOne("BCModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BCModel.BookClub", b =>
                {
                    b.HasOne("BCModel.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN");

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.BooksRead", b =>
                {
                    b.HasOne("BCModel.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN");

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.BooksToRead", b =>
                {
                    b.HasOne("BCModel.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN");

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.ClubPost", b =>
                {
                    b.HasOne("BCModel.BookClub", "BookClub")
                        .WithMany()
                        .HasForeignKey("BookClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("BookClub");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.ClubPostLikes", b =>
                {
                    b.HasOne("BCModel.ClubPost", "ClubPost")
                        .WithMany()
                        .HasForeignKey("ClubPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("ClubPost");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.Comment", b =>
                {
                    b.HasOne("BCModel.ClubPost", "ClubPost")
                        .WithMany()
                        .HasForeignKey("ClubPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.HasOne("BCModel.UserPost", "UserPost")
                        .WithMany()
                        .HasForeignKey("UserPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClubPost");

                    b.Navigation("User");

                    b.Navigation("UserPost");
                });

            modelBuilder.Entity("BCModel.CommentLikes", b =>
                {
                    b.HasOne("BCModel.ClubPost", "ClubPost")
                        .WithMany()
                        .HasForeignKey("ClubPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.HasOne("BCModel.UserPost", "UserPost")
                        .WithMany()
                        .HasForeignKey("UserPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClubPost");

                    b.Navigation("Comment");

                    b.Navigation("User");

                    b.Navigation("UserPost");
                });

            modelBuilder.Entity("BCModel.FavoriteBook", b =>
                {
                    b.HasOne("BCModel.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN");

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.FollowClub", b =>
                {
                    b.HasOne("BCModel.BookClub", "BookClub")
                        .WithMany()
                        .HasForeignKey("BookClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookClub");
                });

            modelBuilder.Entity("BCModel.FollowUser", b =>
                {
                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.Recommendation", b =>
                {
                    b.HasOne("BCModel.Book", "Book")
                        .WithMany()
                        .HasForeignKey("ISBN");

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.UserPost", b =>
                {
                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.UserPostLikes", b =>
                {
                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.HasOne("BCModel.UserPost", "UserPost")
                        .WithMany()
                        .HasForeignKey("UserPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserPost");
                });
#pragma warning restore 612, 618
        }
    }
}
