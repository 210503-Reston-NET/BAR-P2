// <auto-generated />
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

            modelBuilder.Entity("BCModel.ClubComment", b =>
                {
                    b.Property<int>("ClubCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubPostID")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("ClubCommentId");

                    b.HasIndex("ClubPostID");

                    b.HasIndex("UserEmail");

                    b.ToTable("ClubComments");
                });

            modelBuilder.Entity("BCModel.ClubCommentLikes", b =>
                {
                    b.Property<int>("ClubCommentLikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubCommentId")
                        .HasColumnType("integer");

                    b.Property<int>("ClubPostId")
                        .HasColumnType("integer");

                    b.Property<bool>("Dislike")
                        .HasColumnType("boolean");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.HasKey("ClubCommentLikesId");

                    b.HasIndex("ClubCommentId");

                    b.HasIndex("ClubPostId");

                    b.HasIndex("UserEmail");

                    b.ToTable("ClubCommentLikes");
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

            modelBuilder.Entity("BCModel.UserComment", b =>
                {
                    b.Property<int>("UserCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<int>("UserPostID")
                        .HasColumnType("integer");

                    b.HasKey("UserCommentId");

                    b.HasIndex("UserEmail");

                    b.HasIndex("UserPostID");

                    b.ToTable("UserComments");
                });

            modelBuilder.Entity("BCModel.UserCommentLikes", b =>
                {
                    b.Property<int>("UserCommentLikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Dislike")
                        .HasColumnType("boolean");

                    b.Property<bool>("Like")
                        .HasColumnType("boolean");

                    b.Property<int>("UserCommentId")
                        .HasColumnType("integer");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<int>("UserPostId")
                        .HasColumnType("integer");

                    b.HasKey("UserCommentLikesId");

                    b.HasIndex("UserCommentId");

                    b.HasIndex("UserEmail");

                    b.HasIndex("UserPostId");

                    b.ToTable("UserCommentLikes");
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

            modelBuilder.Entity("BCModel.ClubComment", b =>
                {
                    b.HasOne("BCModel.ClubPost", "ClubPost")
                        .WithMany()
                        .HasForeignKey("ClubPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("ClubPost");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BCModel.ClubCommentLikes", b =>
                {
                    b.HasOne("BCModel.ClubComment", "ClubComment")
                        .WithMany()
                        .HasForeignKey("ClubCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.ClubPost", "ClubPost")
                        .WithMany()
                        .HasForeignKey("ClubPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.Navigation("ClubComment");

                    b.Navigation("ClubPost");

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

            modelBuilder.Entity("BCModel.UserComment", b =>
                {
                    b.HasOne("BCModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmail");

                    b.HasOne("BCModel.UserPost", "UserPost")
                        .WithMany()
                        .HasForeignKey("UserPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserPost");
                });

            modelBuilder.Entity("BCModel.UserCommentLikes", b =>
                {
                    b.HasOne("BCModel.UserComment", "UserComment")
                        .WithMany()
                        .HasForeignKey("UserCommentId")
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

                    b.Navigation("User");

                    b.Navigation("UserComment");

                    b.Navigation("UserPost");
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
